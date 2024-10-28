using DataAccessLayer;
using DataAccessLayer.Repository;
using Models;

namespace BusinessLayer.Controller
{
    public class PodcastController
    {
        private readonly IRepository<Podcast> podcastRepository;
        
        public PodcastController()
        {
            podcastRepository = new PodRepository();
        }
        public async Podcast LäggTillPodcastFrånRssAsync(string kategori, string namn, string url)
        {
            // Hämta podcast och dess avsnitt från RSS
            Podcast podcast = await RSS.HämtaPodcastFrånRssAsync(kategori, namn, url);

            if (podcast != null)
            {
                podcastRepository.Insert(podcast);  // Spara podcasten i databasen
            }
            return podcast;
        }
    }
}








//test uppdatering8
