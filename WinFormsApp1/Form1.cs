using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Controller;
using DataAccessLayer;
using Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private PodcastController podcastController;
        private Serializer<Podcast> podcastSerializer;


        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            podcastSerializer = new Serializer<Podcast>("podcasts");
            LoadPodcastsToListView();
        }


        private async void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {
            string namn = tbTitel.Text;
            string kategori = cboxKategori.Text;
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
                item.SubItems.Add(podcast.Titel); // L�gg till andra subitems om det beh�vs
                lvPrenumerationer.Items.Add(item); 
            }

        }

        private void lvPrenumerationer_SelectedIndexChanged(object sender, EventArgs e)
        { 
            // Hantera h�ndelsen n�r ett objekt v�ljs i ListView, om n�dv�ndigt
        }
    }
}


//RSS.H�mtaPodcastFr�nRss(kategori, namn, URL);