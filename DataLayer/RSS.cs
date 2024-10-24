using System.ServiceModel.Syndication;
using System.Xml;
using DataAccessLayer.Repository;
using Models;


namespace DataAccessLayer
{
    public class RSS
    {
        private PodRepository podRepository;

        public RSS()
        {
            podRepository = new PodRepository(); // Skapa en instans av PodRepository
        }

        public string? Titel { get; private set; }

        public List<Podcast> HämtaPodcastFrånRss(string url)
        {
            List<Podcast> podcasts = new List<Podcast>();

            using (XmlReader xmlReader = XmlReader.Create(url)) // Skapa en XML-läsare för att läsa RSS
            {
                SyndicationFeed podcastFlode = SyndicationFeed.Load(xmlReader);

                foreach (SyndicationItem item in podcastFlode.Items)
                {
                    Podcast enPodcast = new Podcast()
                    {
                        Url = item.Id.ToString(),
                        Titel = item.Title.Text
                    };

                    podcasts.Add(enPodcast); // Lägg till varje podcast i listan
                }
            }

            return podcasts; // Returnera listan med podcasts
        }
    }
}

