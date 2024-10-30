using DataAccessLayer;
using DataAccessLayer.Repository;
using Models;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.Controller
{
    public class PodcastController
    {
        private readonly IRepository<Podcast> podcastRepository;

        public PodcastController()
        {
            podcastRepository = new PodRepository();
        }
        public async Task<bool> LäggTillPodcastFrånRssAsync(Kategori kategori, string namn, string url)
        {
            try
            {

                // Hämta podcast och dess avsnitt från RSS
                Podcast podcast = await RSS.HämtaPodcastFrånRssAsync(kategori, namn, url);

                if (podcast != null)
                {
                    podcastRepository.Insert(podcast);  // Spara podcasten i databasen
                    return true;
            }
            else
            {
                Console.WriteLine("Podcast kunde inte hämtas från angiven URL");
                return false;
            }
        }
        catch (Exception ex)
            {
            Console.WriteLine($"Fel vid hämtning av podcast från RSS: {ex.Message}");
            return false;
            }
    }

        public async Task<List<Avsnitt>> LäggTillAvsnittFrånRssAsync(string podcastUrl)
        {
            try
            {
                List<Avsnitt> avsnittList = await RSS.HämtaAvsnittFrånRssAsync(podcastUrl);

                return avsnittList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid hämtning av podcast från RSS: {ex.Message}");
                return null;
            }
        }

    }
}








//test uppdatering11
