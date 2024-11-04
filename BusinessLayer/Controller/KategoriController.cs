
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

        public void LäggTillKategori(string namn)
        {
            Kategori nyKategori = new Kategori(namn);
            kategoriRepository.Insert(nyKategori);  
        }

        public List<Kategori> getAllCategory() { 
            return kategoriRepository.GetAll();
        }

        public void deleteCategory(int index)
        {
            kategoriRepository.Delete(index);
        }

        public void updateKategory(int index, Kategori kategori)
        {
            kategoriRepository.Update(index,kategori);
        }

        //Ny kod
        public Kategori KollaKategoriNamn(string namn)
        {
            return ((KategoriRepository)kategoriRepository).GetByName(namn);
        }

    }

}

