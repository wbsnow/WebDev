using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BJI2012
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Who We Are", // Route name
                "Who-We-Are", // URL with parameters
                new { controller = "WhoWeAre", action = "WhoWeAre" } // Parameter defaults
            );

            routes.MapRoute(
                "Overview", // Route name
                "Overview", // URL with parameters
                new { controller = "Overview", action = "Overview" } // Parameter defaults
            );

            routes.MapRoute(
                "CoreCompetencies", // Route name
                "Core-Competencies", // URL with parameters
                new { controller = "CoreCompetencies", action = "CoreCompetencies" } // Parameter defaults
            );

            routes.MapRoute(
                "Management", // Route name
                "Management", // URL with parameters
                new { controller = "Management", action = "Management" } // Parameter defaults
            );

            routes.MapRoute(
                "Companies", // Route name
                "Companies", // URL with parameters
                new { controller = "Companies", action = "Companies" } // Parameter defaults
            );

            routes.MapRoute(
                "Brown Jordan", // Route name
                "Brown-Jordan", // URL with parameters
                new { controller = "Companies", action = "BrownJordan" } // Parameter defaults
            );

            routes.MapRoute(
                "Casual Living Worldwide", // Route name
                "Casual-Living-Worldwide", // URL with parameters
                new { controller = "Companies", action = "CasualLivingWorldwide" } // Parameter defaults
            );

            routes.MapRoute(
                "Charter Furniture", // Route name
                "Charter-Furniture", // URL with parameters
                new { controller = "Companies", action = "CharterFurniture" } // Parameter defaults
            );

            routes.MapRoute(
                "Tropitone Commerical", // Route name
                "Tropitone-Commerical", // URL with parameters
                new { controller = "Companies", action = "TropitoneCommerical" } // Parameter defaults
            );

            routes.MapRoute(
                "Tropitone Residential", // Route name
                "Tropitone-Residential", // URL with parameters
                new { controller = "Companies", action = "TropitoneResidential" } // Parameter defaults
            );

            routes.MapRoute(
                "Wabash Valley", // Route name
                "Wabash-Valley", // URL with parameters
                new { controller = "Companies", action = "WabashValley" } // Parameter defaults
            );

            routes.MapRoute(
                "Winston Furniture", // Route name
                "Winston-Furniture", // URL with parameters
                new { controller = "Companies", action = "WinstonFurniture" } // Parameter defaults
            );

            routes.MapRoute(
                "Winston Contract", // Route name
                "Winston-Contract", // URL with parameters
                new { controller = "Companies", action = "WinstonContract" } // Parameter defaults
            );


            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}