using defensoresCRUD.Models;
using System;
using System.Threading.Tasks;

namespace defensoresCRUD.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Exercise> ExerciseRepository { get; }
        IRepository<User> UserRepository { get; }
        IRepository<Rol> RolRepository { get; }
        IRepository<MaximumRep> MaximumRepsRepository { get; }
        void SaveChanges();
        Task<bool> SaveChangesAsync();
    }
}
