using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public interface IRepositoryAsync<T> where T : class,IEntity
    {
        Task SaveChangesAsync();
    }
}
