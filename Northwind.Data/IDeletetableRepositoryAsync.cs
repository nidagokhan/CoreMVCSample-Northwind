using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public interface IDeletetableRepositoryAsync<T>:IRepositoryAsync<T> where T:class,IEntity
    {
        //todo void vardı burdan emin ol
        Task DeleteAsync(T deletedValue, bool isHardDelete);
    }
}
