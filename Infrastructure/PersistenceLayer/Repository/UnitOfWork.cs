using DomainLayer.Contracts;
using DomainLayer.Models;
using PersistenceLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Repository
{
    public class UnitOfWork (StorDbContext _storeDbContext ) : IUnitOfWork
    {

        private readonly Dictionary<string , object> _repository = [];
        public IGenericRepository<TEntity, Tkey> GetRepository<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>
        {
            
            var typeName = typeof(TEntity).Name;

            //if (_repository.ContainsKey(typeName))
            //    return (IGenericRepository<TEntity, Tkey>)_repository[typeName];

                if (_repository.TryGetValue(typeName , out object? value))
                return (IGenericRepository<TEntity, Tkey>)value;

            else
            {
                var repo = new GenericRepository<TEntity,Tkey>(_storeDbContext);

                //_repository[typeName] = repo;

                _repository.Add(typeName, repo);

                return repo;


            }
        }

        public async Task<int> SaveChangesAsync()
            => await _storeDbContext.SaveChangesAsync();
    }
}
