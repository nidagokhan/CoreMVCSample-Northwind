using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.ExceptionHandling
{
    public class BusinessLogicException:ExceptionBase
    {
        public BusinessLogicException()
        {

        }
        public BusinessLogicException(string msg):base(msg)
        {
                
        }
        public BusinessLogicException(string msg, Exception innerEx):base(msg, innerEx)
        {

        }

        //public BusinessLogicException(string msg, Exception innerEx, int i):this(msg) //msg thise atarsak, (this bu class demek) this keywordu ile var olan sınıftki(üzerine gelince 2. cons atıyor) datayı oraya gönderiyor. bu şu demek eğer bu class 4 overload çalışmaya başlarsa burası çalışmadan msg yi 2.conc gönder çalıştır sonrasında gel burayı çalıştır demektir.
        //{

        //}
    }
}
