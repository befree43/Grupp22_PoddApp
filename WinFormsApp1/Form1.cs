using DataAccessLayer;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            _ = RSS.HämtaPodcastFrånRss("asdad");
        }
    }
}
