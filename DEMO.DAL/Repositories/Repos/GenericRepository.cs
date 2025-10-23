
using DEMO.DAL.Data.Contexts;
using DEMO.DAL.Models.Shared;
using DEMO.DAL.Repositories.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.DAL.Repositories.Repos
{
    public class GenericRepository<TEntity>(ApplicationDbContext _context) : IGenericRepository<TEntity> where TEntity : BaseEntity
    {

        // CRUD
        // Get TEntity By Id
        public TEntity? GetById(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);

            return entity;
        }
        // Get All TEntity
        public IEnumerable<TEntity> GetAll(bool withTracking = false)
        {
            if (withTracking) return _context.Set<TEntity>().ToList();
            else return _context.Set<TEntity>().AsNoTracking().ToList();
        }
        // Add TEntity
        public int Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChanges();
        }


        // Update TEntity
        public int Update(TEntity entity)
        {

            _context.Set<TEntity>().Update(entity);
            return _context.SaveChanges();
        }
        // Delete TEntity 

        public int Remove(TEntity entity)
        {

            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChanges();
        }
    }
}
