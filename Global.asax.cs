using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SmitWinkel.CustomRoutes;

namespace SmitWinkel
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
            const string defautlRouteUrl = "{controller}/{action}/{id}";

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            RouteValueDictionary defaultRouteValueDictionary = new RouteValueDictionary(new { controller = "Home", action = "Index", id = UrlParameter.Optional });            
            Route defaultRoute = new Route(defautlRouteUrl, defaultRouteValueDictionary, new MvcRouteHandler());

            routes.Add("DefaultGlobalised", new GlobalisedRoute(defaultRoute.Url, defaultRoute.Defaults));

            routes.Add("Default", new Route(defautlRouteUrl, defaultRouteValueDictionary, new MvcRouteHandler()));
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //// Use LocalDB for Entity Framework by default
            //Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //if (Request.UserLanguages.Length == 0)
            //    return;
            //string language = Request.UserLanguages[0];
            //if (language.Substring(0, 2).ToLower() == "af")
            //    Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("af");
            //else
            //    Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
        }
    }
}