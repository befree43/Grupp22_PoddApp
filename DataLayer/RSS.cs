﻿using System;
using System.Diagnostics;
using System.IO.Enumeration;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using DataAccessLayer.Repository;
using Models;


namespace DataAccessLayer
{
    public class RSS
    {
       
    public static async Task<Podcast> HämtaPodcastFrånRssAsync(string kategori, string namn, string url)
    {
        try
            {
                using (XmlReader minXMLlasare = XmlReader.Create(url))
                {
                    SyndicationFeed podcastFlode = await Task.Run(() => SyndicationFeed.Load(minXMLlasare));
                    if (podcastFlode == null) throw new Exception("RSS-flödet kunde inte läsas.");

                    // Skapa en ny Podcast-instans
                    Podcast enPodcast = new Podcast(podcastFlode.Title.Text, kategori, namn, url);

                    // Lägg till avsnitt
                    foreach (var item in podcastFlode.Items)
                    {
                        var avsnitt = new Avsnitt(
                            item.Title.Text,
                            item.Summary.Text,
                            item.Id
                        );
                        enPodcast.Avsnitt.Add(avsnitt);
                    }

                    return enPodcast;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Kunde inte läsa RSS-flöde från URL: {url}. Fel: {ex.Message}");
                return null;
            }
        }
    }
}
                }
            }


        //XmlReader minXMLlasare = XmlReader.Create(url);
        //SyndicationFeed podcastFlode = SyndicationFeed.Load(minXMLlasare);

        //Podcast enPodcast = new Podcast(podcastFlode.Title.Text, kategori, namn , url);

    }
}
}

