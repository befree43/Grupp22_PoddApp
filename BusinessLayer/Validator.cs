using BusinessLayer.Controller;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Validator
    {
        public static bool FaltValidator(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        //Ny kod
        public static bool ArUnikUrl(string url, PodcastController podcastController)
        {
            var befintligPodcast = podcastController.HämtaPodcastViaUrl(url);
            return befintligPodcast == null;
        }

        public static bool ArUniktNamn(string namn, PodcastController podcastController)
        {
            var befintligPodcast = podcastController.KollaPodcastNamn(namn);
            return befintligPodcast == null;
        }

        public static bool ArUnikKategori(string namn, KategoriController kategoriController)
        {
            var befintligKategori = kategoriController.KollaKategoriNamn(namn);
            return befintligKategori == null;
        }
    }
}
