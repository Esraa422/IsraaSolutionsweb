using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IsraaApp.WebMVC.Framework.Utilities;

namespace IsraaApp.WebMVC.Framework.UI
{
    public class Breadcrumb : ViewComponentBase
    {
        public override void GenerateHtmlAtributes()
        { 
        }
    }

    public enum BreadcrumbAlign
    {
        Left,
        Center,
        Right
    }
}