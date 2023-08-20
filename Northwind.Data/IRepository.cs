using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public interface IRepository<T> where T:class, IEntity
    {
        //birim birim işlem işlem db etkilemek için buraya kendi SaveChanges metodumuzu yazıyoruz
        void SaveChanges();
    }
}
