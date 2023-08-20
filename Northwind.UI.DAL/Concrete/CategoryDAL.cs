using Northwind.Data.EfBase;
using Northwind.UI.DAL.Interfaces;
using Northwind.UI.DatabaseApp.Entities;
using Northwind.UI.DatabaseApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.UI.DAL.Concrete
{
    public class CategoryDAL:EfBaseRepository<NorthwindContext,Category>,ICategoryDAL
    {
        public CategoryDAL()
        {

        }
        private NorthwindContext _context;
        public CategoryDAL(NorthwindContext context):base(context)
        {
            _context= context;
        }
    }
}
