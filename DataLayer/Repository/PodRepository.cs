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

        public List<Podcast> GetAll(string categoryName)
        {
            List<Podcast> podcasts = GetAll();

            var filteredPodcasts = podcasts.Where(p => p.Kategori.namn == categoryName).ToList();

            return filteredPodcasts;
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

        

        //Ny Kod

        public Podcast HamtaPodcastMedNamn(string namn)
        {
            return ListAvPodcastar.FirstOrDefault(p => p.Namn.Equals(namn, StringComparison.OrdinalIgnoreCase));
        }

        //public bool FinnsPodcastMedTitel(string titel)
        //{
        //    return ListAvPodcastar.Any(p => p.Namn.Equals(titel, StringComparison.OrdinalIgnoreCase));
        //}

    }

}

