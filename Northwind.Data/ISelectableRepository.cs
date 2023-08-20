using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public interface ISelectableRepository<T>:IRepository<T> where T:class,IEntity
    {
        //IRepository interfacenin içinde SvaChanges methodu var. normal şartlarda interface implemente edildiğinde hata verip içindeki metodun çağırılmasını sağlar. ancak bu durum classlara implemente edldiğinde geçerlidir. Interfaceler interfacelere implemente edildiğinde implementasyon yapmaz direkt içindeki methodu aktarır.
        //Interface tanımlanan herşey bir classa implemete edildiğinde ancak için doldurabiliriz
        List<T> GetAll();
        T GetByID(object id); //id tipleri her tabloda farklı (int, nvarchar, uniqıd. bu 3 tipi karşılayan tip) olduğu için object verdik. dip not: var'ı parametrelerde kullanamıypurz
        List<T> GetBy(Func<T, bool> whereCondition);
    }
}
