using Northwind.Data;
using Northwind.UI.DatabaseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.UI.DAL.Interfaces
{
    public interface IShipperDAL:ISelectableRepository<Shipper>,IInsertableRepository<Shipper>,IDeletetableRepository<Shipper>, IUpdatetableRepository<Shipper>
    {
    }
}
