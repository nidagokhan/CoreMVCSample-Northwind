using Microsoft.AspNetCore.Mvc;
using Northwind.UI.DAL.Interfaces;
using Northwind.UI.DatabaseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.UI.GUI.Controllers
{
    public class ShipperController : Controller
    {
        private readonly IShipperDAL _sDal;
        public ShipperController(IShipperDAL sDal)
        {
            _sDal = sDal;
        }
        public IActionResult Index()
        {
            var result = _sDal.GetAll();
            return View(result);
        }
        public ActionResult Delete(int id)
        {
            Shipper deletedValue = _sDal.GetByID(id);
            if (deletedValue is not null)
            {
                _sDal.Delete(deletedValue, false);
                _sDal.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                //todo Hata ındexi ekle
                return RedirectToAction("Hata");
            }
        }

        public ActionResult Edit(int id)
        {
            Shipper updatedValue = _sDal.GetByID(id);
            if (updatedValue is not null)
            {
                return View(updatedValue);
            }
            else
            {
                return RedirectToAction("Hata");
            }

        }

        [HttpPost]
        public ActionResult Edit(Shipper updatedValue)
        {
            if (updatedValue is not null)
            {
                _sDal.Update(updatedValue);
                _sDal.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Hata");
            }
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Shipper addedValue)
        {
            if (addedValue is not null)
            {
                _sDal.Add(addedValue);
                _sDal.SaveChanges();
                return RedirectToAction("Index"); 
            }

          
            return View(addedValue);
        }
    }
}
