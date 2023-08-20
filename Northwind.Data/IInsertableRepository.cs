using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public interface IInsertableRepository<T> :IRepository<T> where T:class, IEntity
    {
        //neden void değil de T veya List<T> yaptık? eklediğimiz şeyi göstermek amaçlı bu şekilde döndürüyoruz, işimize yararsa diye
        T Add(T addValue);
        List<T> AddRange(List<T> addValues);
    }
}
