using MultipleTableMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleTableMVC.Controllers
{
    public class MultipleTableController : Controller
    {
        // GET: MultipleTable
        public ActionResult Index()
        {

            MVCCRUDDBEntities db = new MVCCRUDDBEntities();
            List<Product> list = db.Products.ToList();
            ViewBag.ProductList = new SelectList(list, "ProductID", "ProductName");
            return View();


        }
        [HttpPost]
        public ActionResult Index(ProductViewModel model)
        {
            MVCCRUDDBEntities db = new MVCCRUDDBEntities();
            List<Product> list = db.Products.ToList();
            ViewBag.ProductList = new SelectList(list, "ProductID", "ProductName");

            Product product = new Product();
            product.ProductID = model.ProductID;
            product.ProductName = model.ProductName;
            product.Category = model.Category;
            int productid = product.ProductID;

            db.Products.Add(product);
            db.SaveChanges();


            Order order = new Order();
            order.OrderNumber = model.OrderNumber;
            order.PersonName = model.PersonName;
            order.ProductID = productid;

            db.Orders.Add(order);
            db.SaveChanges();

            return View(model);
        }
    }
}