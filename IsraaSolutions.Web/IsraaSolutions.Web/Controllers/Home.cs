using System.Web.Mvc;
using IsraaApp.Core.Cache;
using IsraaApp.Service;
using IsraaApp.WebMVC.Framework.Controllers;

namespace IsraaApp.WebMVC.Controllers
{
    public class HomeController : BaseController
    {
        #region Fields

        private readonly ICategoryService categoryService;
        private readonly IPostService postService;
        private readonly IUrlService urlService;
        private readonly IPostTagService tagService;
        private readonly ICacheManager cacheManager;
        private readonly ISettingService settingService;

        #endregion Fields

        #region Ctor

        public HomeController(ICategoryService _categoryService,
            IPostService _postService,
            IUrlService _urlService,
            IPostTagService _tagService,
            ICacheManager _cacheManager,
            ISettingService _settingService)
        {
            categoryService = _categoryService;
            postService = _postService;
            urlService = _urlService;
            tagService = _tagService;
            cacheManager = _cacheManager;
            settingService = _settingService;
        }

        #endregion Ctor

        #region Methods

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }

        public ActionResult Index4()
        {
            return View();
        }

        public ActionResult Index5()
        {
            return View();
        }
        public ActionResult Index6()
        {
            return View();
        }
        public ActionResult Index7()
        {
            return View();
        }
        public ActionResult Index8()
        {
            return View();
        }
        public ActionResult Index9()
        {
            return View();
        }
        public ActionResult Index10()
        {
            return View();
        }
        public ActionResult Index11()
        {
            return View();
        }
        public ActionResult Index12()
        {
            return View();
        }
        public ActionResult Index13()
        {
            return View();
        }
        #endregion Methods
    }
}