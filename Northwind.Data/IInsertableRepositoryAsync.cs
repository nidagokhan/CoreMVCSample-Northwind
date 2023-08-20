using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    //c# da senkron olarak bir işi bir thread yapar. bir işi bölümleyerek yaptırmak istediğimizde bu threadleri artırmak gerekir. db gidip data eklicez dediğimizde thread formu,view bırakır db data götürmekle uğraşır. bu sırada form,page,vew donar. hem sayfa işini yapmaya devam etsin hem de db ekleme yapalım dediğimizde iki thread kullanmamız gerekir. bu threadlerin gelişmiş versiyonları TASK isminde bir tip oluyor.  bu tiple async işlemlerini yürütüyoruz.
    //zaman bazlı değil zamansız olarak bu tiple işlmleri yapıyoruz. 
    public interface IInsertableRepositoryAsync<T> : IRepositoryAsync<T> where T:class,IEntity
    {
        Task AddAsync(T addValue);
        Task AddRangeAsync(List<T> addValues);
    }
}
