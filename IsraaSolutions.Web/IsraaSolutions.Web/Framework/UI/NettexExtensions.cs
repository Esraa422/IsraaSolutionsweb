using System;
using System.Web.Mvc;

namespace IsraaApp.WebMVC.Framework.UI
{
    public static class NettexExtensions
    {
        public static NettexHelper IsraaApp(this HtmlHelper htmlHelper)
        {
            var IsraaApp = new NettexHelper(htmlHelper);
            return IsraaApp;
        }

        public static NettexHelper<TModel> IsraaApp<TModel>(this HtmlHelper<TModel> htmlHelper)
        {
            var IsraaApp = new NettexHelper<TModel>(htmlHelper);
            return IsraaApp;
        }
    }

    public class NettexHelper
    {
        public NettexHelper(HtmlHelper htmlHelper)
        {
            HtmlHelper = htmlHelper;
        }

        public HtmlHelper HtmlHelper { get; set; }
    }

    public class NettexHelper<TModel> : NettexHelper
    {
        public NettexHelper(HtmlHelper<TModel> htmlHelper)
            : base(htmlHelper)
        {
            HtmlHelper = htmlHelper;
        }

        public new HtmlHelper<TModel> HtmlHelper { get; set; }
    }
}