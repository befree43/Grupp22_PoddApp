using System.Diagnostics;
using System.IO.Enumeration;
using System.ServiceModel.Syndication;
using System.Xml;
using DataAccessLayer.Repository;
using Models;


namespace DataAccessLayer
{
    public class RSS
    {
       
  
            public static async Task HämtaPodcastFrånRssOchSparaAsync(string kategori, string namn, string url, string filnamn)
            {


            // Hämta användarens dokumentmapp
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filname = Path.Combine(documentsPath, "podcasts.xml"); 

            // Hämta RSS-flödet från URL asynkront
            using (XmlReader xmlReader = XmlReader.Create(url, new XmlReaderSettings { Async = true }))
            {
                SyndicationFeed podcastFeed = await Task.Run(() => SyndicationFeed.Load(xmlReader));

                // Skapa en podcast-objekt baserat på RSS-flödet
                Podcast enPodcast = new Podcast(podcastFeed.Title.Text, kategori, namn, url);

                // Serialisera podcasten och spara till en XML-fil asynkront
                Serializer<Podcast> serializer = new Serializer<Podcast>(filnamn); // Här används filnamn korrekt
                List<Podcast> podcasts = new List<Podcast> { enPodcast };  // Lägg till podcast i en lista

                // Använd Task.Run för att köra serialisering asynkront
                await Task.Run(() => serializer.Serialize(podcasts));
            }

            }
}
}

