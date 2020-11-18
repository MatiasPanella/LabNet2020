using Lab.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.ResourceAccess.Repositories
{
    public class CategoriesRepository
    {
        public List<Categories> GetAllCategories()
        {
            List<Categories> ListCategories = new List<Categories>();
            using(var context = new NorthwindContext())
            {
                ListCategories = context.Categories.Select(x => x).ToList();
            }
            return ListCategories;
        }

        public Categories GetOne(int id)
        {
            Categories categories = new Categories();
            using (var context = new NorthwindContext())
            { 
                try
                {
                    return context.Categories.Include("Products").Where(c => c.CategoryID.Equals(id)).FirstOrDefault();
                } 
                catch (Exception)
                {
                    throw new Exception("No se encontro el ID ingresado");
                }
              
            }
        }
        public void Insert (Categories entity)
        {
            Categories categories = new Categories();

            using(var context = new NorthwindContext())
            {
                context.Categories.Add(entity);
                context.SaveChanges();
            }
        }
        public void PutCategory(Categories categories)
        {
            Categories categoryToEdit = new Categories();
            using (var context = new NorthwindContext())
            {
                context.Categories.Attach(categoryToEdit);
                context.Categories.Add(categoryToEdit);
                context.SaveChanges();
            }
        }


        public void Delete(int id)
        {
            using(var context = new NorthwindContext())
            {
                Categories categoryToDelete = new Categories();
                try
                {
                    categoryToDelete = GetOne(id);
                    context.Categories.Attach(categoryToDelete);
                    context.Categories.Remove(categoryToDelete);
                    context.SaveChanges();
                }
                catch(Exception)
                {
                    throw new Exception("No se puede eliminar este elemento.");
                }
                
            }
        }
    }
}
