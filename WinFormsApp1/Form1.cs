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

        //private PodcastController podcastController = new PodcastController();
        //private AvsnittController avsnittController = new AvsnittController();
        //private KategoriController kategoriController = new KategoriController();


        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
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
            }
            else
            {
                MessageBox.Show("Kunde inte l�gga till podcasten. Kontrollera URL och f�rs�k igen.");
            }
       

        }
    }
}


//RSS.H�mtaPodcastFr�nRss(kategori, namn, URL);