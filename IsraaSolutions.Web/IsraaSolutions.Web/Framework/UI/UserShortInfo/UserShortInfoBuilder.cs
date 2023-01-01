using System.Web.Mvc;
using IsraaApp.Core.Entities;
using IsraaApp.Core.Infrastructure;
using IsraaApp.Service;

namespace IsraaApp.WebMVC.Framework.UI
{
    public class UserShortInfoBuilder : ViewComponentBuilderBase<UserShortInfo, UserShortInfoBuilder>
    {
        private readonly ApplicationUserService userService;

        public UserShortInfoBuilder(HtmlHelper htmlHelper, UserShortInfo model)
            : base(htmlHelper, model)
        {
            userService = Engine.Resolve<ApplicationUserService>();
        }

        public override string ToHtmlString()
        {

            return base.ToHtmlString();
        }

        public UserShortInfoBuilder User(ApplicationUser user)
        {
            this.Component.User = user;
            return this;
        }

        public UserShortInfoBuilder User(string userName)
        {
            var user = userService.GetByUserName(userName);
            this.Component.User = user;
            return this;
        }
    }
}