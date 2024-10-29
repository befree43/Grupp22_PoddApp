using System;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLayer;
using BusinessLayer.Controller;
using DataAccessLayer;
using Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form    
    {

    


        public Form1()
        {
            InitializeComponent();
            FilController.EnsureFileExists();
        }


       
        private async void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {
            string namn = tbTitel.Text;
            string kategori = cboxKategori.Text;
            string URL = tbURL.Text;

            bool lyckades = await PodcastController.AddPodcastFromRssAsync(URL, kategori, namn);

            if (lyckades)
            {
                MessageBox.Show("Podcasten har lagts till!");
            }
            else
            {
                MessageBox.Show("Kunde inte lägga till podcasten. Kontrollera URL och försök igen.");
            }
       

        }
    }
}

