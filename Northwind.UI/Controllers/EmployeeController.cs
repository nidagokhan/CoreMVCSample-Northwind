using Microsoft.AspNetCore.Mvc;
using Northwind.UI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.UI.GUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeDAL _eDal;
        public EmployeeController(IEmployeeDAL eDal)
        {
            _eDal= eDal;
        }
        public IActionResult Index()
        {
            var result = _eDal.GetAll();
            return View(result);
        }
    }
}
