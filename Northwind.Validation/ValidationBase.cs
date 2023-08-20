using Northwind.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Validation
{
    public abstract class ValidationBase<TModel> where TModel:class, IModel //validation, kullanıcıdan en doğru dataları almaya yada db en doğru şekilde veri göndermek için kullanılır.hem entity hem model olsun diye tmodel dedik
    {
        public ValidationBase(TModel onValidateModel)
        {
            Validationmessages = new List<string>();
            IsValid = false;
            OnValidate();
            Model=onValidateModel;

        }

        public bool IsValid { get; protected set; }
        public List<string> Validationmessages { get; private set; }
        public TModel Model { get; private set; }

        public abstract void OnValidate();
    }
}
