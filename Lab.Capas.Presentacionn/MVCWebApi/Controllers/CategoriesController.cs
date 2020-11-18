using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Lab.Demo.Entities;
using Lab.Demo.Logic;

namespace MVCWebApi.Controllers
{
    public class CategoriesController : ApiController
    {

        // GET: api/Categories
        public List<Categories> GetAllCategories()
        {   
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            return categoriesLogic.GetAll();
        }

        public void Delete (int id)
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            categoriesLogic.Delete(id);
        }

        //GET: api/Categories/5
        public Categories GetOneCategory(int id)
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            var category = categoriesLogic.GetOne(id);
            return (category);
        }




        // PUT: api/Categories/5
        public IHttpActionResult PutCategories(int id, Categories categories)
       {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != categories.CategoryID)
                return BadRequest();

            CategoriesLogic categoriesLogic = new CategoriesLogic();
            categoriesLogic.Update(categories);
            return Ok();
            //return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Categories
        [ResponseType(typeof(Categories))]
        public IHttpActionResult PostCategories(Categories categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            categoriesLogic.Insert(categories);
            

            return CreatedAtRoute("DefaultApi", new { id = categories.CategoryID }, categories);
        }

        // DELETE: api/Categories/5
        //[ResponseType(typeof(Categories))]
        //public IHttpActionResult DeleteCategories(int id)
        //{
        //    Categories categories = db.Categories.Find(id);
        //    if (categories == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Categories.Remove(categories);
        //    db.SaveChanges();

        //    return Ok(categories);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool CategoriesExists(int id)
        //{
        //    return db.Categories.Count(e => e.CategoryID == id) > 0;
        //}
    }
}