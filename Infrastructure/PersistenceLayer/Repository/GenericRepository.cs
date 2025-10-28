using DomainLayer.Contracts;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using PersistenceLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Repository
{
    public class GenericRepository<TEntity, TKey> (StorDbContext _storDbContext) : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {

        public async Task AddAsync(TEntity entity)
            => await _storDbContext.Set<TEntity>().AddRangeAsync(entity);

        public async Task<IEnumerable<TEntity>> GetAllAsync()
            => await _storDbContext.Set<TEntity>().ToListAsync();

        public async Task<TEntity?> GetByIdAsync(TKey id) 
            
            => await _storDbContext.Set<TEntity>().FindAsync(id);

        public void Remove(TEntity entity) 
            
            => _storDbContext.Set<TEntity>().Remove(entity);

        public void Update(TEntity entity)
            => _storDbContext.Set<TEntity>().Update(entity);
    }
}
