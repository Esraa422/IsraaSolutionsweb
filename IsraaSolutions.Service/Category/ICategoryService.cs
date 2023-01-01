using IsraaApp.Core.Entities;
using System.Collections.Generic;

namespace IsraaApp.Service
{
    public interface ICategoryService
    {
        Category GetById(int Id);
        IEnumerable<Category> GetActives();
        IEnumerable<Category> GetCategories();
        bool Insert(Category category);
        bool Update(Category category);
        bool Delete(Category category);
    }
}