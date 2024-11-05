using System;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Controller;
using DataAccessLayer;
using DataAccessLayer.Repository;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            btnÄndraKategori.Visible = false;
        }


        private async void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {
            string namn = tbTitel.Text;
            Kategori kategori = new Kategori(cboxKategori.Text);
            string URL = tbURL.Text;

            if (!Validator.FaltValidator(namn))
            {
                MessageBox.Show("Namnet får inte vara tomt!");
                return; 
            }

            if(!Validator.ArUniktNamn(namn, podcastController)) 
            {
                MessageBox.Show("Vänligen välj ett unikt namn!");
                return; 
            }

            if (cboxKategori.Text == "Välj en kategori")
            {
                MessageBox.Show("Välj en kategori!");
                return;
            }
            if (!Validator.ArUnikUrl(URL, podcastController))
            {
                MessageBox.Show("Denna URL är redan sparad. Vänligen ange en annan URL.");
                return; 
            }

            else
            {
                bool lyckades = await podcastController.LäggTillPodcastFrånRssAsync(kategori, namn, URL);

                if (lyckades)
                {
                    MessageBox.Show("Podcasten har lagts till!");
                    tbTitel.Clear();
                    cboxKategori.SelectedIndex = 0;
                    tbURL.Clear();
                    LoadPodcastsToListView();
                }
                else
                {
                    MessageBox.Show("Kunde inte lägga till podcasten. Kontrollera URL och försök igen.");
                }
            }
        }

        private void LoadPodcastsToListView()
        {
            List<Podcast> podcasts = podcastSerializer.Deserialize();
            lvPrenumerationer.Items.Clear(); 
            foreach (var podcast in podcasts)
            {
                ListViewItem item = new ListViewItem(podcast.Namn);
                item.SubItems.Add(podcast.Titel);
                item.SubItems.Add(podcast.Kategori.namn);
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

                Kategori kategori = new Kategori(selectedItem.SubItems[2].Text);
                LoadPodcastInfo(selectedItem.SubItems[0].Text, selectedItem.SubItems[1].Text, kategori);
            }
        }

        private async Task LoadAvsnittToListBox(string podcastUrl)
        {
            try
            {
                List<Avsnitt> avsnittList = await podcastController.LäggTillAvsnittFrånRssAsync(podcastUrl);

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

        private async Task LoadPodcastInfo(string podNamn, string podTitel, Kategori podKategori)
        {
            int podIndex = -1;
            for (int i = 0; i < cbPodKategori.Items.Count; i++)
            {
                if (((Kategori)cbPodKategori.Items[i]).namn == podKategori.namn)
                {
                    podIndex = i;
                    break;
                }
            }

            if (podIndex >= 0)
            {
                cbPodKategori.SelectedIndex = podIndex;
            }

            lblPodTitle.Text = podTitel;
            tbPodNamn.Text = podNamn;
        }

        private void lboxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxAvsnitt.SelectedIndex != -1)
            {
                Avsnitt selectedAvsnitt = (Avsnitt)lboxAvsnitt.SelectedItem;
                rtbBeskrivning.Text = selectedAvsnitt.Beskrivning;
            }
        }

        private void btnLäggTillKategori_Click(object sender, EventArgs e)
        {
            string kategoriNamn = tbNyKategori.Text;
            if (!Validator.FaltValidator(kategoriNamn))
            {
                MessageBox.Show("Vänligen skriv in ett kategorinamn!");
                return;
            }

            if (!Validator.ArUnikKategori(kategoriNamn, kategoriController))
            {
                MessageBox.Show("Kategorin finns redan!");
                return;
            }
            kategoriController.LäggTillKategori(kategoriNamn);
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
            cbPodKategori.Items.Clear();

            cboxKategori.DisplayMember = "namn";
            cboxSorteraPodcast.DisplayMember = "namn";
            cbPodKategori.DisplayMember = "namn";

            cboxKategori.Items.Add("Välj en kategori");

            Kategori defaultKategori = new Kategori("Alla");
            cboxSorteraPodcast.Items.Add(defaultKategori);

            foreach (var kategori in kategorier)
            {
                cboxKategori.Items.Add(kategori);
                cboxSorteraPodcast.Items.Add(kategori);
                cbPodKategori.Items.Add(kategori);
            }

            cboxKategori.SelectedIndex = 0;
            cboxSorteraPodcast.SelectedIndex = 0;
            cbPodKategori.SelectedIndex = -1;
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {

            List<Podcast> podcastsWithCategory = podcastController.FilterPodByCategory(lboxKategori.SelectedItem.ToString());

            if (podcastsWithCategory.Count > 0)
            {
                MessageBox.Show("Du kan inte radera en kategori som används");

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Vill du radera kategorin?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   
                    kategoriController.deleteCategory(lboxKategori.SelectedIndex);
                    LoadCategoriesToComboBoxes();
                    LoadCategoryToListBox();
                    tbNyKategori.Clear();
                      
                }
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

        private void btnÄndraKategori_Click(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedIndex != -1)
            {
                Kategori newCategory = new Kategori(tbNyKategori.Text);
                kategoriController.updateKategory(lboxKategori.SelectedIndex, newCategory);
                podcastController.updatePodcastsCategory(lboxKategori.SelectedItem.ToString(), newCategory);
                LoadCategoriesToComboBoxes();
                LoadCategoryToListBox();
                LoadPodcastsToListView();
                tbNyKategori.Clear();
            }
        }

        private void tbNyKategori_TextChanged(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedIndex != -1)
            {
                btnÄndraKategori.Visible = true;
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

        private void btnSparaPod_Click(object sender, EventArgs e)
        {
            int foundIndex = findPodIndex();

            if (foundIndex != -1)
            {
                ListViewItem foundItem = lvPrenumerationer.Items[foundIndex];
                string url = foundItem.SubItems[3].Text;
                Podcast updatedPodcast = new Podcast(lblPodTitle.Text, (Kategori)cbPodKategori.SelectedItem, tbPodNamn.Text, url);

                podcastController.UpdatePodcast(foundIndex, updatedPodcast);

                LoadPodcastsToListView();
            }
        }

        private void btnRaderaPod_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vill du radera podcasten?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int foundIndex = findPodIndex();
                if (foundIndex != -1)
                {
                    podcastController.deletPodcast(foundIndex);
                    LoadPodcastsToListView();
                    lblPodTitle.Text = "Podcast";
                    tbPodNamn.Text = "";
                    cbPodKategori.SelectedIndex = -1;
                    lboxAvsnitt.Items.Clear();
                    rtbBeskrivning.Text = "";

                    MessageBox.Show("Podcast borttagen");
                }
            }

        }

        private int findPodIndex() {
            string searchTitle = lblPodTitle.Text; 
            int foundIndex = -1;

            for (int i = 0; i < lvPrenumerationer.Items.Count; i++)
            {
                if (lvPrenumerationer.Items[i].SubItems[1].Text == searchTitle)
                {
                    foundIndex = i;
                    
                    break;
                }
            }

            return foundIndex;
        }
    }
}

