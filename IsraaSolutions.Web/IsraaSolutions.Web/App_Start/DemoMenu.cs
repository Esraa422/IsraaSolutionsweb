using System.Web;
using System.Web.Mvc;
using IsraaApp.WebMVC.Framework.UI;

namespace IsraaApp.WebMVC
{
    public partial class DemoMenu
    {
        public static Nav GetDemoMenu()
        {
            var nav = new Nav();
            var url = new UrlHelper(HttpContext.Current.Request.RequestContext);

            var homes = new Dropdown("Home")
            {
                Dropdowns = {
                   new Dropdown("Home - Variation 1", url.Action("Index", "Home"))
                }
            };
            var pages = new Dropdown("Pages")
            {
                Dropdowns = {
                   new Dropdown("About") {
                       Dropdowns = {
                         new Dropdown("About Me", url.Action("AboutMe", "Page"))
                       }
                   },
                   new Dropdown("Contact") {
                       Dropdowns = {
                          new Dropdown("Contact Us 2", url.Action("ContactUs2", "Page")),
                          
                       }
                   },
                   new Dropdown("Services", url.Action("Services", "Page")),
                   new Dropdown("Team", url.Action("Team", "Page")),
                   new Dropdown("Jobs", url.Action("Jobs", "Page")),
                                                     
               
                }
            };
            var blog = new Dropdown("Blog")
            {
                Dropdowns = {
                   new Dropdown("Card") {
                       Dropdowns = {
                          new Dropdown("Left Sidebar", url.Action("CardLeftSidebar", "Blog")),
                          
                       }
                   },
                   new Dropdown("Grid") {
                       Dropdowns = {

                          
                          
                       }
                   },
                   new Dropdown("List") {
                       Dropdowns = {
                          
                         
                       }
                   },
                   new Dropdown("Single") {
                       Dropdowns = {
                      
                       }
                   }
                }
            };
            var portfolio = new Dropdown("Portfolio")
            {
                Dropdowns = {
                   new Dropdown("Agency", url.Action("Agency", "Portfolio")),
                   new Dropdown("Awesome Work", url.Action("AwesomeWork", "Portfolio")),
                   new Dropdown("Masonry", url.Action("Masonry", "Portfolio")),
                }
            };
            var features = new Dropdown("Features", url.Action("Index", "Features"))
            {
                Dropdowns = {
                    
                }
            };

            

            nav.Dropdowns.Add(homes);
            nav.Dropdowns.Add(pages);
            nav.Dropdowns.Add(blog);
            nav.Dropdowns.Add(portfolio); 
            nav.Dropdowns.Add(features);
           

            return nav;
        }
    }
}