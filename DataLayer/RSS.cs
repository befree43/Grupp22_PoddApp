using System;
using System.Diagnostics;
using System.IO.Enumeration;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using DataAccessLayer.Repository;
using Models;


namespace DataAccessLayer
{
    public class RSS
    {
        

        public static async Task<Podcast?> HämtaPodcastFrånRssAsync(string kategori, string namn, string url, ListView listview)
        {
            // Hämta användarens dokumentmapp
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filnamn = Path.Combine(documentsPath, "podcasts.xml");
            
            try
            {
                using (XmlReader minXMLlasare = XmlReader.Create(url))
                {
                    SyndicationFeed podcastFlode = await Task.Run(() => SyndicationFeed.Load(minXMLlasare));
                    if (podcastFlode == null) throw new Exception("RSS-flödet kunde inte läsas.");

                    Podcast enPodcast = new Podcast(podcastFlode.Title.Text, kategori, namn, url);

                    foreach (var item in podcastFlode.Items)
                        { string summaryText = item.Summary != null ? item.Summary.Text : "Ingen sammanfattning tillgänglig";
                        Avsnitt avsnitt = new Avsnitt(item.Title.Text, summaryText, item.Id);
                        enPodcast.Avsnitt.Add(avsnitt); 
                    }
                    ListViewItem listViewItem = new ListViewItem(new string[]
                    {
                    namn, // Användarnamn
                    podcastFlode.Title.Text, // Titel från RSS-flödet
                    enPodcast.Avsnitt.Count.ToString(), // Antal avsnitt kategori
                    kategori // Vald kategori
                    });

                    listView.Items.Add(listViewItem);

                    return enPodcast;
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid hämtning av RSS-flödet: {ex.Message}");
                return null;
            }
        }
    }
}
    

        //XmlReader minXMLlasare = XmlReader.Create(url);
        //SyndicationFeed podcastFlode = SyndicationFeed.Load(minXMLlasare);

        //Podcast enPodcast = new Podcast(podcastFlode.Title.Text, kategori, namn , url);

