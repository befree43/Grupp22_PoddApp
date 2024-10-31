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

            bool lyckades = await podcastController.LäggTillPodcastFrånRssAsync(kategori, namn, URL);

            if (lyckades)
            {
                MessageBox.Show("Podcasten har lagts till!");
                LoadPodcastsToListView();
            }
            else
            {
                MessageBox.Show("Kunde inte lägga till podcasten. Kontrollera URL och försök igen.");
            }


        }

        private void LoadPodcastsToListView()
        {
            List<Podcast> podcasts = podcastSerializer.Deserialize();
            lvPrenumerationer.Items.Clear(); // Rensa ListView innan den fylls på nytt
            foreach (var podcast in podcasts)
            {
                ListViewItem item = new ListViewItem(podcast.Namn);
                item.SubItems.Add(podcast.Titel); // Lägg till andra subitems om det behövs
                lvPrenumerationer.Items.Add(item); 
            }

        }

        private void lvPrenumerationer_SelectedIndexChanged(object sender, EventArgs e)
        { 
            // Hantera händelsen när ett objekt väljs i ListView, om nödvändigt
        }
    }
}


//RSS.HämtaPodcastFrånRss(kategori, namn, URL);