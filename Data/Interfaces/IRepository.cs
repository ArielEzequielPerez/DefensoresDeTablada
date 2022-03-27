using defensoresCRUD.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace defensoresCRUD.Data
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        Task<T> Delete(int id);
    }
}