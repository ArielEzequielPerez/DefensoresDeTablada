using defensoresCRUD.Models;
using DefensoresDeTablada.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace defensoresCRUD.Data
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DataContext _context;
        protected readonly DbSet<T> _entities;
        public Repository(DataContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable().Where(x => x.SoftDelete);
        }
        public T GetById(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id && x.SoftDelete);
        }
        public void Add(T entity)
        {
            _entities.AddAsync(entity);
        }
        public void Update(T entity)
        {
            _entities.Update(entity);
        }

        public async Task<T> Delete(int id)
        {
            T entidad = await _entities.FirstOrDefaultAsync(x => x.Id == id && x.SoftDelete);
            if (entidad == null)
            {
                return entidad;
            }
            entidad.SoftDelete = false;
            entidad.LastModified = DateTime.Now;
            return entidad;
        }
    }
}

