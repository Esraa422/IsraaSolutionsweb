using System.Web.Mvc;
using IsraaApp.WebMVC.Framework.UI;

namespace IsraaApp.WebMVC.Framework.UI
{
    public class GalleryBuilder : ViewComponentBuilderBase<Gallery, GalleryBuilder>
    {
        public GalleryBuilder(HtmlHelper htmlHelper, Gallery model) : base(htmlHelper, model)
        { 
        }
    }
}