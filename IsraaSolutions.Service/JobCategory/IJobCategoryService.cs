using IsraaApp.Core.Entities;
using System.Collections.Generic;

namespace IsraaApp.Service
{
    public interface IJobCategoryService
    {
        JobCategory GetById(int Id);
        IEnumerable<JobCategory> GetActives();
        IEnumerable<JobCategory> GetCategories();
        bool Insert(JobCategory jobCategory);
        bool Update(JobCategory jobCategory);
        bool Delete(JobCategory jobCategory);
    }
}