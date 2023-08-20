using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.ExceptionHandling
{
    public abstract class ExceptionBase : Exception
    {
        public ExceptionBase()
        {

        }

        public ExceptionBase(string msg):base(msg) //exception throwlanabilsin. exception üertildiğinde bir try catch bloğu bizim üereteceğimiz exception ı yakayabilsin diye üst sınıfa string msj gönderiyoruz.
        {

        }

        public ExceptionBase(string msg, Exception ex):base(msg, ex)
        {

        }
    }
}
