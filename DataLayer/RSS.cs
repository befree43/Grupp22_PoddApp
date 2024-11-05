using System;
using System.Diagnostics;
using System.IO.Enumeration;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using DataAccessLayer.Repository;
using Models;


namespace DataAccessLayer
{
    public class RSS
    {
        public static async Task<Podcast> HämtaPodcastFrånRssAsync(Kategori kategori, string namn, string url)
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

                    return enPodcast;
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid hämtning av RSS-flödet: {ex.Message}");
                return null;
            }
        }

        public static async Task<List<Avsnitt>> HämtaAvsnittFrånRssAsync(string url)
        {

            try
            {
                List<Avsnitt> allaAvsnitt = new List<Avsnitt>();
                using (XmlReader minXMLlasare = XmlReader.Create(url))
                {
                    SyndicationFeed podcastFlode = await Task.Run(() => SyndicationFeed.Load(minXMLlasare));
                    if (podcastFlode == null) throw new Exception("RSS-flödet kunde inte läsas.");

                    foreach (SyndicationItem item in podcastFlode.Items) {
                        string summary = "Ingen beskrivning att visa";

                        if (item.Summary != null && item.Summary.Text != null) {
                            summary = item.Summary.Text;
                        }
                        Avsnitt avsnitt = new Avsnitt(item.Title.Text, summary, item.Id);
                        allaAvsnitt.Add(avsnitt);
                    }

                    return allaAvsnitt;
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
    

       
