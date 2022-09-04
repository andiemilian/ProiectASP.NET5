using Microsoft.EntityFrameworkCore;
using ProiectASP.NET5.net.Context;
using ProiectASP.NET5.Repositories.GenericRepository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_asp.net.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public readonly Context _context;
        public GenericRepository(Context context)
        {
            _context = context;
        }

        protected Context Context => _context;

        public void Create(TEntity entity)
        {


            Context.Set<TEntity>().Add(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public async Task<bool> SaveAsync()
        {
            return await Context.SaveChangesAsync() > 0;
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
        }

        IQueryable<TEntity> IGenericRepository<TEntity>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Task<TEntity> IGenericRepository<TEntity>.GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<bool> IGenericRepository<TEntity>.SaveAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
