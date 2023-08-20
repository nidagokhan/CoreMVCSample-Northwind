using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    //T, bir class olacak IUpdatetable implemente edeceğimiz yerde ama IEntity den türeyen bir class olacak.
    //Örn: Category IEntity implemente etmemişse IUpdatetable interfaceini kullanamaz demektir
    //T class olması yetmez bi de Ientityden de türesin diyoruz.
   public interface IUpdatetableRepository<T>:IRepository<T> where T:class,IEntity
    {
        void Update(T updateValue);
    }
}
