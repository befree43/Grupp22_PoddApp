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
        Task InsertAsync(T theObject);
        Task UpdateAsync(int index, T theObject);
        Task DeleteAsync(int index);
        Task SaveChangesAsync();
    }
}