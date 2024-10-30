using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;



namespace DataAccessLayer.Repository
{
    public class KategoriRepository : IRepository<Kategori>
    {
        private readonly Serializer<Kategori> KategoriSerializer;
        private List<Kategori> ListAvKategorier;

        public KategoriRepository()
        {
            KategoriSerializer = new Serializer<Kategori>("kategorier");
            ListAvKategorier = KategoriSerializer.Deserialize();
        }

        public List<Kategori> GetAll()
        {
            return ListAvKategorier;
        }

        public Kategori GetByName(string namn)
        {
            return ListAvKategorier.FirstOrDefault(k => k.KategoriNamn == namn);
        }

        public void Insert(Kategori theObject)
        {
            ListAvKategorier.Add(theObject);
            SaveChanges();
        }

        public void Update(int index, Kategori theNewObject)
        {
            if (index >= 0 && index < ListAvKategorier.Count)
            {
                ListAvKategorier[index] = theNewObject;
            }
            SaveChanges();
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < ListAvKategorier.Count)
            {
                ListAvKategorier.RemoveAt(index);
            }
            SaveChanges();
        }

        public void SaveChanges()
        {
            KategoriSerializer.Serialize(ListAvKategorier);
        }

        public Kategori GetByUrl(string url) // Implementera metoden
        {
            return ListAvKategorier.FirstOrDefault(k => k.KategoriUrl == url);
        }
    }
}

   



