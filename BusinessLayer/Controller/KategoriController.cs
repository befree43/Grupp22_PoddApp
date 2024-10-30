using DataAccessLayer.Repository;
using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controller
{
    class KategoriController
    {
        private readonly IRepository<Kategori> kategoriRepository;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
        }
        public async Task<bool> LäggTillPodcastFrånRssAsync(string kategori, string namn, string url)
        {
            try
            {

                // Hämta podcast och dess avsnitt från RSS
                Podcast podcast = await RSS.HämtaPodcastFrånRssAsync(kategori, namn, url);

                if (podcast != null)
                {
                    Kategori kategoriObjekt = new Kategori(kategori, namn);
                    kategoriRepository.Insert(kategoriObjekt);  // Spara kategorin i databasen
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
    }
}


    
