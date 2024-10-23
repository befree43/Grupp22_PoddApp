using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;



namespace DataAccessLayer.Repository
{
    public class PodRepository : IRepository<Podcast>
    {
        Serializer<Podcast> PodcastSerializer;
        List<Podcast> ListAvPodcastar;
        public PodRepository()
        {
            ListAvPodcastar = new List<Podcast>();
            PodcastSerializer = new Serializer<Podcast>(nameof(ListAvPodcastar));
        }
        public List<Podcast> GetAll()
        {
            return PodcastSerializer.Deserialize();
        }
        public Podcast GetByID(string id)
        {
            Podcast Podcast = null;
            foreach (var item in PodcastSerializer.Deserialize())
            {
                if (item.PodcastNummer.Equals(id))
                {
                    Podcast = item;
                }
            }
            return Podcast;
        }
        public void Insert(Podcast theObject)
        {
            ListAvPodcastar.Add(theObject);
            SaveChanges();
        }
        public void Update(int index, Podcast theNewObject)
        {
            if (index >= 0)
            {
                ListAvPodcastar[index] = theNewObject;
            }
            SaveChanges();
        }
        public void Podcastete(int index)
        {
            ListAvPodcastar.RemoveAt(index);
            SaveChanges();
        }
        public void SaveChanges()
        {
            PodcastSerializer.Serialize(ListAvPodcastar);
        }
    }
}
