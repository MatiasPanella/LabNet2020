using Lab.Capas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Lab.Capas.Controllers
{
    public class CategoriesWebApiController : Controller
    {
        // GET: EmployeesWebApi
        public ActionResult Index()
        {
            IEnumerable<CategoriesView> categoryList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Categories").Result;
            categoryList = response.Content.ReadAsAsync<IEnumerable<CategoriesView>>().Result;
            return View(categoryList);
        }

        public ActionResult AddOrEdit(int id=0 )
        {
            if (id == 0)
                return View(new CategoriesView());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Categories/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<CategoriesView>().Result);
            }
           
        }

        [HttpPost]
        public ActionResult AddOrEdit(CategoriesView categories)
        {
            if(categories.CategoryId == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Categories", categories).Result;
                TempData["SuccessMessage"] = "Category created";
            } else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Categories/"+ categories.CategoryId, categories).Result;
                TempData["SuccessMessage"] = "Category edited";
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage reponse = GlobalVariables.WebApiClient.DeleteAsync("Categories/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted successfully";
            return RedirectToAction("Index");
        }
    }
}