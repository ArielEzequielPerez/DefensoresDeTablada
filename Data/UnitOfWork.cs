using defensoresCRUD.Data.Interfaces;
using defensoresCRUD.Models;
using DefensoresDeTablada.Data;
using System.Threading.Tasks;

namespace defensoresCRUD.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private readonly IRepository<Exercise> _exerciseRepository;
        private readonly IRepository<MaximumRep> _maximumRepRepository;
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Rol> _rolRepository;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public IRepository<Exercise> ExerciseRepository => _exerciseRepository ?? new Repository<Exercise>(_context);
        public IRepository<MaximumRep> MaximumRepsRepository => _maximumRepRepository ?? new Repository<MaximumRep>(_context);
        public IRepository<User> UserRepository => _userRepository ?? new Repository<User>(_context);
        public IRepository<Rol> RolRepository => _rolRepository ?? new Repository<Rol>(_context);

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0 ;
        }
    }
   
        
}
