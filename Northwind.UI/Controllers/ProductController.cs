using Microsoft.AspNetCore.Mvc;
using Northwind.UI.DAL.Interfaces;
using Northwind.UI.DatabaseApp.Context;
using Northwind.UI.DatabaseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Northwind.UI.GUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductDAL _pDal;
        public ProductController(IProductDAL pDal)
        {
           _pDal= pDal;
        }
        public IActionResult Index()
        {
            var result = _pDal.GetAll();
            return View(result);
        }

     
        //public ActionResult Delete(int id)
        //{
        //    ViewData["Title"] = id;
        //    Product deletedValue= _pDal.GetByID(id);
        //    if (deletedValue is not null)
        //    {
        //        _pDal.Delete(deletedValue, true);
        //        _pDal.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Hata");
        //    }         
        //}
    }
}
