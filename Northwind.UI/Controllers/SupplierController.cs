using Microsoft.AspNetCore.Mvc;
using Northwind.UI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.UI.GUI.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierDAL _supDal;
        public SupplierController(ISupplierDAL supDal)
        {
            _supDal= supDal;
        }
        public IActionResult Index()
        {
            var result = _supDal.GetAll();
            return View(result);
        }
    }
}
