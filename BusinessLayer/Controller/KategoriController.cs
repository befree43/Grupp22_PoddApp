
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

    }

}

