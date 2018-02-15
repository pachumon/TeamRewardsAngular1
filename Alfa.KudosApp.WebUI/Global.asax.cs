using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Alfa.KudosApp.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {

        private const string CsFileExtension = "cshtml";

        protected void Application_Start()
        {

            ViewEngines.Engines.Clear();
            var razorEngine = new RazorViewEngine { FileExtensions = new[] { CsFileExtension } };
            ViewEngines.Engines.Add(razorEngine);

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}