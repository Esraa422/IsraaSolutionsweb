using System;
using System.Web.Mvc;
using System.Web.WebPages; 

namespace IsraaApp.WebMVC.Framework.UI
{
    public class WidgetBuilder : ViewComponentBuilderBase<ViewComponentBase, WidgetBuilder>
    {
        public WidgetBuilder(HtmlHelper htmlHelper, ViewComponentBase model) : base(htmlHelper, model)
        { 
        }

        //public WidgetBuilder<TModel> Parameter(string paramName, object paramValue)
        //{
        //    Model.Parameters.Add(paramName, paramValue);
        //    return this;
        //}
    }
}