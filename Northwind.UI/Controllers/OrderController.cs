using Microsoft.AspNetCore.Mvc;
using Northwind.UI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.UI.GUI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderDAL _oDal;
        public OrderController(IOrderDAL oDal)
        {
            _oDal= oDal;
        }

        //todo order da shipperıd bulunamadı hatası veriyor bak!
        public IActionResult Index()
        {
            var result = _oDal.GetAll();
            return View(result);
        }
    }
}
