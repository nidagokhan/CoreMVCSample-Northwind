using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public interface IDeletetableRepository<T> : IRepository<T> where T : class, IEntity
    {
        void Delete(T deletedValue, bool isHardDelete);
    }
}
