using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MyStore.Models;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyStore.Controllers
{
    public class ProductController : Controller
    {
        Models.MyStoreContext DB = new Models.MyStoreContext();
        // GET: /<controller>/
        public IActionResult IndexProduct()
        {
            var data = DB.Product.ToList();
            ViewBag.Title("ASD");
            return View(data);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertProduct(Product rs)
        {
            if (ModelState.IsValid)
            {
                DB.Product.Add(rs);
                DB.SaveChanges();
                return RedirectToAction("IndexProduct");
            }
            return View(rs);
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var data = DB.Product.Where(b => b.ProductID == id).Single();
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product rs)
        {
            if (ModelState.IsValid)
            {
                DB.Entry(rs).State = EntityState.Modified;
                DB.SaveChanges();
                return RedirectToAction("IndexProduct");
            }
            return View(rs);
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            string msg = "";
            try
            {
                var data = DB.Product.Where(b => b.ProductID == id).Single();
                DB.Product.Remove(data);
                DB.SaveChanges();
                return RedirectToAction("IndexProduct");
            }
            catch (Exception e)
            {
                msg = "Error Delete " + e.Message;
                return Json(new { valid = false, Message = msg });
            }
        }
    }
}
