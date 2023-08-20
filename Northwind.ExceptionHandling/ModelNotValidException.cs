using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.ExceptionHandling
{
    public class ModelNotValidException:ExceptionBase
    {
        public List<string> ValidationMessages { get; private set; } //newlerken cons. aldığımız için içine data bir daha değer atanmasın diye private yaptık
        public ModelNotValidException(List<string> validationMessages)
        {
            ValidationMessages=validationMessages;
        }
        public ModelNotValidException(List<string> validationMessages,string exceptionMsg):base(exceptionMsg)
        {
            ValidationMessages= validationMessages;
        }
        public ModelNotValidException(List<string> validationMessages,string exceptionMsg, Exception innerEx):base(exceptionMsg,innerEx)
        {
            ValidationMessages=validationMessages;
        }
    }
}
