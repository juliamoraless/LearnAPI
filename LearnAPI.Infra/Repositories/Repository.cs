using LearnAPI.Domain.Interfaces.Repositories;
using LearnAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Infra.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly LearnContext _context;
        public Repository(LearnContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity?> GetById(Guid id)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
        }

        public virtual async Task<List<TEntity>> GetAll(TEntity entity)
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task Create(TEntity entity)
        {
            _context.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Update(TEntity entity)
        {
            _context.Update(entity);
            await SaveChanges();
        }

        public virtual async Task Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            //TODO: implementar um try catch aqui
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
