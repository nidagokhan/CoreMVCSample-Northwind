using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public interface ISelectableRepositoryAsync<T> : IRepositoryAsync<T> where T:class,IEntity
    {
        Task GetAllAsync();
        Task GetByIDAsync(object id);
        Task GetByAsync(Func<T, bool> whereCondition);
    }
}
