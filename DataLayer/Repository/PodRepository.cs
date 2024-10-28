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
        private readonly Serializer<Podcast> PodcastSerializer;
        private List<Podcast> ListAvPodcastar;

        public PodRepository()
        {
            PodcastSerializer = new Serializer<Podcast>("podcasts");
            ListAvPodcastar = PodcastSerializer.Deserialize();
        }

        public List<Podcast> GetAll()
        {
            return ListAvPodcastar;
        }

        public Podcast GetByUrl(string url)
        {
            return ListAvPodcastar.FirstOrDefault(p => p.Url == url);
        }

        public void Insert(Podcast theObject)
        {
            ListAvPodcastar.Add(theObject);
            SaveChanges();
        }

        public void Update(int index, Podcast theNewObject)
        {
            if (index >= 0 && index < ListAvPodcastar.Count)
            {
                ListAvPodcastar[index] = theNewObject;
            }
            SaveChanges();
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < ListAvPodcastar.Count)
            {
                ListAvPodcastar.RemoveAt(index);
            }
            SaveChanges();
        }

        public void SaveChanges()
        {
            PodcastSerializer.Serialize(ListAvPodcastar);
        }
    }

    //Serializer<Podcast> PodcastSerializer;
    //List<Podcast> ListAvPodcastar;
    //public PodRepository()
    //{
    //    ListAvPodcastar = new List<Podcast>();
    //    PodcastSerializer = new Serializer<Podcast>(nameof(ListAvPodcastar));
    //}
    //public List<Podcast> GetAll()
    //{
    //    return PodcastSerializer.Deserialize();
    //}
    //public Podcast GetByUrl(string url)
    //{
    //    Podcast Podcast = null;
    //    foreach (var item in PodcastSerializer.Deserialize())
    //    {
    //        if (item.Url.Equals(url))
    //        {
    //            Podcast = item;
    //        }
    //    }
    //    return Podcast;
    //}
    //public void Insert(Podcast theObject)
    //{
    //    ListAvPodcastar.Add(theObject);
    //    SaveChanges();
    //}
    //public void Update(int index, Podcast theNewObject)
    //{
    //    if (index >= 0)
    //    {
    //        ListAvPodcastar[index] = theNewObject;
    //    }
    //    SaveChanges();
    //}
    //public void Delete(int index)
    //{
    //    ListAvPodcastar.RemoveAt(index);
    //    SaveChanges();
    //}
    //public void SaveChanges()
    //{
    //    PodcastSerializer.Serialize(ListAvPodcastar);
    //}
}
}
