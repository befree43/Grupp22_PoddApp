using System.ServiceModel.Syndication;
using DataAccessLayer.Repository;
using Models;

namespace DataAccessLayer
{
    public class RSS
    {
        public void HämtaPodcastFrånRss(string url);
        SyndicationFeed podcastFlode = SyndicationFeed.Load(minXMLlasare);

        foreach (SyndicationItem item in podcastFlode.Items)
            {
            Podcast enPodcast = new Podcast
            {
                Url = item.Id.ToString(),
                Titel = item.Title.Text
            };

        
    }
}
