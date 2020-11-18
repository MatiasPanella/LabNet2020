using Lab.Demo.Entities;
using Lab.Demo.ResourceAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    public class CategoriesLogic : BaseLogic, ILogic<Categories>
    {
        public void Delete(int id)
        {
            CategoriesRepository categoriesRepository = new CategoriesRepository();
            categoriesRepository.Delete(id);
        }


        public List<Categories> GetAll()
        {
            
            CategoriesRepository categoriesRepository = new CategoriesRepository();
            return categoriesRepository.GetAllCategories();
        }
        public Categories GetOne(int id)
        {
            CategoriesLogic categories = new CategoriesLogic();
            return categories.GetOne(id);
        }

        public Categories Insert(Categories entity)
        {
            int lastId = (from cat in context.Categories
                          orderby cat.CategoryID descending
                          select cat.CategoryID).FirstOrDefault();
            lastId += 1;

            Categories newCategory = context.Categories.Add(entity);
            context.SaveChanges();
            return newCategory;
        }

        public void Update(Categories entity)
        {
            CategoriesRepository categoriesRepository = new CategoriesRepository();
            categoriesRepository.PutCategory(entity);
            //Categories categoryToEdit = GetOne(entity.CategoryID);
            //categoryToEdit.CategoryName = entity.CategoryName;
            //categoryToEdit.Description = entity.Description;
            //context.SaveChanges();
        }
    }
}
