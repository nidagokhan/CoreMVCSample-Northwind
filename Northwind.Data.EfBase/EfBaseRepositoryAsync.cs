using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.EfBase
{
    public abstract class EfBaseRepositoryAsync<TContext, TEntity> :
        ISelectableRepositoryAsync<TEntity>,
        IInsertableRepositoryAsync<TEntity>,
        IDeletetableRepositoryAsync<TEntity>,
        IUpdatetableRepositoryAsync<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext, new()
    {
        private readonly TContext _context;
        public EfBaseRepositoryAsync()
        {
            _context=new TContext();
        }

        public EfBaseRepositoryAsync(TContext context)
        {
             _context= context;
        }

        public Task AddAsync(TEntity addValue)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(List<TEntity> addValues)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity deletedValue, bool isHardDelete)
        {
            throw new NotImplementedException();
        }

        public Task GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetByAsync(Func<TEntity, bool> whereCondition)
        {
            throw new NotImplementedException();
        }

        public Task GetByIDAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity updateValue)
        {
            throw new NotImplementedException();
        }
    }
}
