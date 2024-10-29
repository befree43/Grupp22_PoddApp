using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByUrlAsync(string url);
        void InsertAsync(T theObject);
        void UpdateAsync(int index, T theObject);
        void DeleteAsync(int index);
        void SaveChangesAsync();
    }


}
