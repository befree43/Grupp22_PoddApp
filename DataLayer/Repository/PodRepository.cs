using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer.Repository
{
    public class PodRepository : IRepository<Podcast>
    {
        private readonly Serializer<Podcast> podcastSerializer;
        private List<Podcast> podcastList;

        // Constructor now accepts a file path
        public PodRepository(string filePath)
        {
            podcastSerializer = new Serializer<Podcast>(filePath);
            podcastList = podcastSerializer.Deserialize(); 
        }

        public Task<List<Podcast>> GetAllAsync()
        {
            return Task.FromResult(podcastList);
        }

        public Task<Podcast> GetByUrlAsync(string url)
        {
            return Task.FromResult(podcastList.FirstOrDefault(p => p.Url == url));
        }

        public void InsertAsync(Podcast podcast)
        {
            podcastList.Add(podcast);
            SaveChangesAsync();
        }

        public void UpdateAsync(int index, Podcast newPodcast)
        {
            if (index >= 0 && index < podcastList.Count)
            {
                podcastList[index] = newPodcast;
                SaveChangesAsync();
            }
        }

        public void DeleteAsync(int index)
        {
            if (index >= 0 && index < podcastList.Count)
            {
                podcastList.RemoveAt(index);
                SaveChangesAsync();
            }
        }

        public void SaveChangesAsync()
        {
            podcastSerializer.Serialize(podcastList);
        }
    }
}
