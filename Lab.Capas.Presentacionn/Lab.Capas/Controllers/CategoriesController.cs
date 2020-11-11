using Lab.Demo.Entities;
using Lab.Demo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Capas.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            var logic = new CategoriesLogic();
            var categories = logic.GetAll();
            return View(categories);
        }
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Categories category)
        {
            var logic = new CategoriesLogic();
            var categoryEntity = new Categories() { CategoryName = category.CategoryName, Description = category.Description };
            logic.Insert(categoryEntity);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Edit (int id)
        {
            CategoriesLogic logic = new CategoriesLogic();
            Categories categories = logic.GetOne(id);
            return View(categories);
        }

        [HttpPost]
        public ActionResult Edit (Categories categories)
        {
            var logic = new CategoriesLogic();
            logic.Update(categories);
            return RedirectToAction("index");
        }
        public ActionResult Delete(int id)
        {
            var logic = new CategoriesLogic();
            logic.Delete(id);
            return RedirectToAction("index");
        }


    }
}