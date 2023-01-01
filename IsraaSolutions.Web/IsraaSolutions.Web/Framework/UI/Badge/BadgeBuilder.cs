using System.Web.Mvc;
using IsraaApp.WebMVC.Framework.Utilities;

namespace IsraaApp.WebMVC.Framework.UI
{
    public class BadgeBuilder : ViewComponentBuilderBase<Badge, BadgeBuilder>
    {
        public BadgeBuilder(HtmlHelper htmlHelper, Badge model) : base(htmlHelper, model)
        { 
        }

        public BadgeBuilder Text(string text)
        {
            this.Component.Text = text;
            return this;
        }

        public BadgeBuilder Color(BootstrapColor color)
        {
            this.Component.BSColor = color;
            return this;
        }

        public BadgeBuilder Pill()
        {
            this.Component.AppendCssClass(".badge-pill");
            return this;
        }
    }
}