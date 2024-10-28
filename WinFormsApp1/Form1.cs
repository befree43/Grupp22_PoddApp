using BusinessLayer;
using Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form    
    {
        private PodcastController podcastController = new PodcastController();
        private AvsnittController avsnittController = new AvsnittController();
        private KategoriController kategoriController = new KategoriController();

    
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            string namn = tbTitel.Text;
            string kategori = cboxKategori.Text;
            string URL = tbURL.Text;


            


        }
    }
}
