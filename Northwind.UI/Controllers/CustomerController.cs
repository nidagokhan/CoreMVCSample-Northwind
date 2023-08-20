using Microsoft.AspNetCore.Mvc;
using Northwind.UI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.UI.GUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerDAL _cDal;
        public CustomerController(ICustomerDAL cDal)
        {
            _cDal = cDal;
        }
        public IActionResult Index()
        {
            var result = _cDal.GetAll();
            return View(result);
        }
    }
}
