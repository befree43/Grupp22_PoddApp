using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Controller;
using DataAccessLayer;
using DataAccessLayer.Repository;
using Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private PodcastController podcastController;
        private Serializer<Podcast> podcastSerializer;

        private KategoriController kategoriController;
        private Serializer<Kategori> kategoriSerializer;
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            podcastSerializer = new Serializer<Podcast>("podcasts");

            kategoriController = new KategoriController();
            kategoriSerializer = new Serializer<Kategori>("categories");

            LoadPodcastsToListView();
            LoadCategoryToListBox();
        }


        private async void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {
            string namn = tbTitel.Text;
            Kategori kategori = new Kategori(cboxKategori.Text);
            string URL = tbURL.Text;

            bool lyckades = await podcastController.L�ggTillPodcastFr�nRssAsync(kategori, namn, URL);

            if (lyckades)
            {
                MessageBox.Show("Podcasten har lagts till!");
                LoadPodcastsToListView();
            }
            else
            {
                MessageBox.Show("Kunde inte l�gga till podcasten. Kontrollera URL och f�rs�k igen.");
            }


        }

        private void LoadPodcastsToListView()
        {
            List<Podcast> podcasts = podcastSerializer.Deserialize();
            lvPrenumerationer.Items.Clear(); // Rensa ListView innan den fylls p� nytt
            foreach (var podcast in podcasts)
            {
                ListViewItem item = new ListViewItem(podcast.Namn);
                item.SubItems.Add(podcast.Url);
                item.SubItems.Add(podcast.Kategori.namn);// L�gg till andra subitems om det beh�vs
                lvPrenumerationer.Items.Add(item);
            }

        }

        private void lvPrenumerationer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPrenumerationer.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPrenumerationer.SelectedItems[0];

                string url = selectedItem.SubItems[1].Text;

                LoadAvsnittToListBox(url);

            }
        }

        private async Task LoadAvsnittToListBox(string podcastUrl)
        {
            try
            {
                List<Avsnitt> avsnittList = await podcastController.L�ggTillAvsnittFr�nRssAsync(podcastUrl);

                lboxAvsnitt.Items.Clear();
                if (avsnittList != null)
                {
                    lboxAvsnitt.DisplayMember = "Titel";
                    foreach (var avsnitt in avsnittList)
                    {
                        lboxAvsnitt.Items.Add(avsnitt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void lboxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxAvsnitt.SelectedIndex != -1)
            {

                Avsnitt selectedAvsnitt = (Avsnitt)lboxAvsnitt.SelectedItem;
                rtbBeskrivning.Text = selectedAvsnitt.Beskrivning;
            }
        }

        private void btnL�ggTillKategori_Click(object sender, EventArgs e)
        {
            string kategoriNamn = tbNyKategori.Text;
            kategoriController.L�ggTillKategori(kategoriNamn);
            LoadCategoryToListBox();
        }

        private void LoadCategoryToListBox()
        {
            List<Kategori> kategorier = kategoriSerializer.Deserialize();
            lboxKategori.Items.Clear();
            if (kategorier != null)
            {
                foreach (var kategori in kategorier)
                {
                    lboxKategori.Items.Add(kategori.namn);
                }
            }

        }
    }
}


//RSS.H�mtaPodcastFr�nRss(kategori, namn, URL);