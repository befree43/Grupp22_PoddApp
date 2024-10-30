
using Models;



namespace DataAccessLayer.Repository
{
    public class KategoriController 
    {
        private readonly IRepository<Kategori> kategoriRepository;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
        }

        public void LäggTillKategori(string namn, string beskrivning)
        {
            Kategori nyKategori = new Kategori(namn, beskrivning);
            kategoriRepository.Insert(nyKategori);  
        }

    }

}

