using DataAccessLayer.Repository;
using System;
using System.Threading.Tasks;
using Models;
using BusinessLayer.Controller;
using System.ServiceModel.Syndication;
using System.Xml;

public class PodcastController
{
    private static readonly string filePath = FilController.GetFilePath();
    private static readonly PodRepository podcastRepository = new PodRepository(filePath);

    public static async Task<bool> AddPodcastFromRssAsync(string url, string category, string name)
    {
        try
        {
            Podcast newPodcast = await FetchPodcastFromRssAsync(category, name, url);

            if (newPodcast == null) {
                throw new Exception("Error retrieving the podcast.");
            }
                
            // Use the repository to insert the podcast
            podcastRepository.InsertAsync(newPodcast);

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding the podcast: {ex.Message}");
            return false;
        }
    }

    public static async Task<Podcast> FetchPodcastFromRssAsync(string category, string name, string url)
    {
        try
        {
            using (XmlReader xmlReader = XmlReader.Create(url))
            {
                SyndicationFeed podcastFeed = await Task.Run(() => SyndicationFeed.Load(xmlReader));
                if (podcastFeed == null) throw new Exception("The RSS feed could not be read.");

                return new Podcast(podcastFeed.Title.Text, category, name, url);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching the RSS feed: {ex.Message}");
            return null;
        }
    }
}
