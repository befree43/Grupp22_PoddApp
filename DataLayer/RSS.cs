using System.Diagnostics;
using System.ServiceModel.Syndication;
using System.Xml;
using DataAccessLayer.Repository;
using Models;


namespace DataAccessLayer
{
    public class RSS
    {
       
    public static void HämtaPodcastFrånRss(string kategori, string namn, string url)
    {

        XmlReader minXMLlasare = XmlReader.Create("https://rss.podplaystudio.com/1477.xml");
        SyndicationFeed podcastFlode = SyndicationFeed.Load(minXMLlasare);

        Podcast enPodcast = new Podcast(podcastFlode.Title.Text, kategori, namn , url);
            
       //lägg till enPodcast i xml fil


    }
}
}

