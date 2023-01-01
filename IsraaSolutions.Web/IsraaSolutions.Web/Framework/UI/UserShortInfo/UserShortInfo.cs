using IsraaApp.Core.Entities;

namespace IsraaApp.WebMVC.Framework.UI
{
    public class UserShortInfo : ViewComponentBase
    {
        public UserShortInfo()
        {

        }

        public ApplicationUser User { get; set; }

        public override void GenerateHtmlAtributes()
        { 
        }
    }
}