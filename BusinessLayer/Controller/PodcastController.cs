using DataAccessLayer.Repository;
using Models;

namespace BusinessLayer.Controller
{
    public class PodcastController
    {
        IRepository<Podcast> podcastRepository;
        public PodcastController()
        {
            podcastRepository = new PodRepository();
        }
    }
}








//test uppdatering7
