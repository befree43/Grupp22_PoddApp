using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Kategori
    {
        public string? KategoriNamn { get; set; }
        public string? KategoriUrl { get; set; }

        public List<Podcast> Podcasts { get; set; }

        public Kategori(string? kategoriNamn, string? kategoriUrl)
        {
            KategoriNamn = kategoriNamn;
            KategoriUrl = kategoriUrl;
        }
        public Kategori() { }
    }
}
