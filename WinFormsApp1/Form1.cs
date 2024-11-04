using System;
using System.Security.Policy;
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

        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            podcastSerializer = new Serializer<Podcast>("podcasts");

            kategoriController = new KategoriController();

            LoadPodcastsToListView();
            LoadCategoryToListBox();
            LoadCategoriesToComboBoxes();

            btn�ndraKategori.Visible = false;
        }


        private async void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {
            string namn = tbTitel.Text;
            Kategori kategori = new Kategori(cboxKategori.Text);
            string URL = tbURL.Text;

            if (!Validator.FaltValidator(namn))
            {
                MessageBox.Show("Namnet f�r inte vara tomt!");
                return; // Avbryt om titeln �r tom
            }

            if(!Validator.ArUniktNamn(namn, podcastController)) 
            {
                MessageBox.Show("V�nligen v�lj ett unikt namn!");
                return; // Avbryt om titeln �r tom
            }

            if (cboxKategori.Text == "V�lj en kategori")
            {
                MessageBox.Show("V�lj en kategori!");

            }
            if (!Validator.ArUnikUrl(URL, podcastController))
            {
                MessageBox.Show("Denna URL �r redan sparad. V�nligen ange en annan URL.");
                return; // Avbryt om URL:en redan �r sparad
            }

            else
            {
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








        }

        private void LoadPodcastsToListView()
        {
            List<Podcast> podcasts = podcastSerializer.Deserialize();
            lvPrenumerationer.Items.Clear(); // Rensa ListView innan den fylls p� nytt
            foreach (var podcast in podcasts)
            {
                ListViewItem item = new ListViewItem(podcast.Namn);
                item.SubItems.Add(podcast.Titel);
                item.SubItems.Add(podcast.Kategori.namn);// L�gg till andra subitems om det beh�vs
                item.SubItems.Add(podcast.Url);

                lvPrenumerationer.Items.Add(item);
            }

        }

        private void lvPrenumerationer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPrenumerationer.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPrenumerationer.SelectedItems[0];

                string url = selectedItem.SubItems[3].Text;

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
            if (!Validator.FaltValidator(kategoriNamn))
            {
                MessageBox.Show("V�nligen skriv in ett kategorinamn!");
                return;
            }

            if (!Validator.ArUnikKategori(kategoriNamn, kategoriController))
            {
                MessageBox.Show("Kategorin finns redan!");
                return;
            }
            kategoriController.L�ggTillKategori(kategoriNamn);
            LoadCategoryToListBox();
            LoadCategoriesToComboBoxes();
        }

        private void LoadCategoryToListBox()
        {
            List<Kategori> kategorier = kategoriController.getAllCategory();
            lboxKategori.Items.Clear();
            if (kategorier != null)
            {
                foreach (var kategori in kategorier)
                {
                    lboxKategori.Items.Add(kategori.namn);
                }
            }

        }

        private void LoadCategoriesToComboBoxes()
        {
            List<Kategori> kategorier = kategoriController.getAllCategory();

            cboxKategori.Items.Clear();
            cboxSorteraPodcast.Items.Clear();

            cboxKategori.DisplayMember = "namn";
            cboxSorteraPodcast.DisplayMember = "namn";

            cboxKategori.Items.Add("V�lj en kategori");

            Kategori defaultKategori = new Kategori("Alla");
            cboxSorteraPodcast.Items.Add(defaultKategori);

            foreach (var kategori in kategorier)
            {
                cboxKategori.Items.Add(kategori);
                cboxSorteraPodcast.Items.Add(kategori);
            }

            cboxKategori.SelectedIndex = 0;
            cboxSorteraPodcast.SelectedIndex = 0;
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedIndex != -1)
            {
                kategoriController.deleteCategory(lboxKategori.SelectedIndex);
                LoadCategoriesToComboBoxes();
                LoadCategoryToListBox();
                tbNyKategori.Clear();
            }
        }

        private void lboxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedIndex != -1)
            {
                string selectedCategory = lboxKategori.SelectedItem.ToString();
                tbNyKategori.Text = selectedCategory;
            }
        }

        private void btn�ndraKategori_Click(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedIndex != -1)
            {
                Kategori newCategory = new Kategori(tbNyKategori.Text);
                kategoriController.updateKategory(lboxKategori.SelectedIndex, newCategory);
                LoadCategoriesToComboBoxes();
                LoadCategoryToListBox();
            }
        }

        private void tbNyKategori_TextChanged(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedIndex != -1)
            {
                btn�ndraKategori.Visible = true;
            }

        }

        private void cboxSorteraPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cboxSorteraPodcast.SelectedItem;

            if (selectedItem is Kategori selectedKategori)
            {
                string categoryName = selectedKategori.namn;
                lvPrenumerationer.Items.Clear(); 
                List<Podcast> podcasts = podcastController.FilterPodByCategory(categoryName);
                foreach (var podcast in podcasts)
                {
                    ListViewItem item = new ListViewItem(podcast.Namn);
                    item.SubItems.Add(podcast.Titel);
                    item.SubItems.Add(podcast.Kategori.namn);
                    item.SubItems.Add(podcast.Url);
                    lvPrenumerationer.Items.Add(item);
                }
            }
           
        }
    }
}

