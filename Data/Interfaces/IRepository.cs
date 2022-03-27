using System.Collections.Generic;
using System.Threading.Tasks;

namespace defensoresCRUD.Data
{
    public interface IRepository <T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}