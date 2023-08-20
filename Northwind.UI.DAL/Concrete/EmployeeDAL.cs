using Northwind.Data.EfBase;
using Northwind.UI.DAL.Interfaces;
using Northwind.UI.DatabaseApp.Context;
using Northwind.UI.DatabaseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.UI.DAL.Concrete
{
    public class EmployeeDAL:EfBaseRepository<NorthwindContext,Employee>,IEmployeeDAL
    {
        public EmployeeDAL()
        {

        }

       private NorthwindContext _context;
        public EmployeeDAL(NorthwindContext context):base(context)
        {
            _context=context;
        }
    }
}
