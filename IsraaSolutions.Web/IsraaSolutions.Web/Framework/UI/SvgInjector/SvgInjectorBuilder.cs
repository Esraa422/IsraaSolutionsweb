using System.Web.Mvc; 
using IsraaApp.WebMVC.Framework.UI;

namespace IsraaApp.WebMVC.Framework.UI
{
    public class SvgInjectorBuilder : ViewComponentBuilderBase<SvgInjector, SvgInjectorBuilder>
    {
        public SvgInjectorBuilder(HtmlHelper htmlHelper, SvgInjector model) : base(htmlHelper, model)
        { 
        }

        public SvgInjectorBuilder SvgSrc(string src)
        {
            this.Component.SvgSrc = src;
            return this;
        }

        /// <summary>
        /// New image source
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public SvgInjectorBuilder NewSrc(string src)
        {
            this.Component.NewSrc = src;
            return this;
        }
    }
}