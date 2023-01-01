using System.Linq;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using IsraaApp.Core;
using IsraaApp.Core.Entities;
using IsraaApp.Core.Extensions;
using IsraaApp.Service;
using IsraaApp.WebMVC.Framework.Attributes;
using IsraaApp.WebMVC.Framework.Controllers;
using IsraaApp.WebMVC.Areas.Manage.Models;

namespace IsraaApp.WebMVC.Areas.Manage.Controllers
{
    [Authorize]
    public partial class JobCategoryController : BaseController
    {
        #region Fields

        private readonly IJobCategoryService jobCategoryService;
        private readonly IJobService jobService;
        private readonly IUrlService urlService;

        #endregion Fields

        #region Ctor

        public JobCategoryController(
            IJobService _jobService,
            IJobCategoryService _jobCategoryService,
            IUrlService _urlService)
        {
            jobService = _jobService;
            jobCategoryService = _jobCategoryService;
            urlService = _urlService;
        }

        #endregion Ctor

        public ActionResult List()
        {
            var model = jobCategoryService.GetCategories().Select(x => new JobCategoryModel
            {
                Id = x.Id,
                Name = x.Name,
                IsActive = x.IsActive,
                JobCount = jobService.GetCount(x.Id)
            }).ToList();

            return View(new GridModel<JobCategoryModel>
            {
                Data = model,
                Total = model.Count()
            });
        }

        public ActionResult Create()
        {
            var model = new JobCategoryModel();
            model.IsActive = true;
            return View(model);
        }

        /// <summary>
        /// Create a jobCategory
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [DemoAuthorize(SystemRoles.Member)]
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        [MultipleButtonAction(Name = "action", Argument = "Create")]
        public ActionResult Create(JobCategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var jobCategory = new JobCategory
                {
                    Name = model.Name,
                    IsActive = model.IsActive
                };

                var result = jobCategoryService.Insert(jobCategory);
                if (result)
                    this.NotifySuccess("Successfully saved.");
                else
                    this.NotifyError("Item can not saved!"); 

                return RedirectToAction("Edit", new { Id = jobCategory.Id });
            }

            return View(model);
        }

        /// <summary>
        /// JobCategory Edit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("List");

            var jobCategory = jobCategoryService.GetById(id.Value);
            if (jobCategory == null)
            {
                this.NotifyError("Item not found.");
                return RedirectToAction("List");
            }

            var model = new JobCategoryModel
            {
                Id = jobCategory.Id,
                Name = jobCategory.Name,
                IsActive = jobCategory.IsActive,
                JobCount = jobService.GetCount(jobCategory.Id)
            };

            return View(model);
        }

        /// <summary>
        /// Edit a jobCategory
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [DemoAuthorize(SystemRoles.Member)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MultipleButtonAction(Name = "action", Argument = "Edit")]
        public ActionResult Edit(JobCategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var jobCategory = jobCategoryService.GetById(model.Id);
                if (jobCategory == null)
                {
                    this.NotifyError("Item not found.");
                    return RedirectToAction("List");
                }
                else
                {
                    jobCategory.Name = model.Name;
                    jobCategory.IsActive = model.IsActive;

                    var result = jobCategoryService.Update(jobCategory);
                    if (result)
                        this.NotifySuccess("Successfully saved.");
                    else
                        this.NotifyError("Item can not saved!"); 
                }

                return RedirectToAction("Edit", new { id = model.Id });
            }

            return View(model);
        }

        /// <summary>
        /// Delete a jobCategory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [DemoAuthorize(SystemRoles.Member)]
        [HttpPost]
        [MultipleButtonAction(Name = "action", Argument = "Delete")]
        public ActionResult Delete(int id)
        {
            var jobCategory = jobCategoryService.GetById(id);
            if (jobCategory == null)
            {
                this.NotifyError("Item not found.");
                return RedirectToAction("List");
            }
            else
            {
                var deleted = jobCategoryService.Delete(jobCategory);
                if (deleted)
                    this.NotifySuccess("Successfully deleted.");
                else
                    this.NotifyError("Item can not deleted!");
            }

            return RedirectToAction("List");
        }

    }
}