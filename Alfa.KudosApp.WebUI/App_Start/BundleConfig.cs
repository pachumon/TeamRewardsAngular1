using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Alfa.KudosApp.WebUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;
            RegisterClientCommonScriptBundles(bundles);
            RegisterClientCommonStyleBundles(bundles);
            RegisterAppModuleAndServicesBundle(bundles);
            RegisterAngularToastrBundle(bundles);
            RegisterComponentBundle(bundles);
        }

        private static void RegisterClientCommonScriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js/angular").Include(
                "~/Client/libs/angular/1.6.5/angular.js",
                "~/Client/libs/angular/1.6.5/angular-route.js",
                "~/Client/libs/angular/1.6.5/angular-animate.js",
                "~/Client/libs/angular/1.6.5/angular-sanitize.js"));

            bundles.Add(new ScriptBundle("~/bundles/js/ui-bootstrap").Include(
                "~/Client/libs/ui-bootstrap/2.5.0/ui-bootstrap-tpls.js"));
        }

        private static void RegisterClientCommonStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Client/libs/bootstrap/3.3.7/css/bundle").Include(
                "~/Client/libs/bootstrap/3.3.7/css/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Client/libs/font-awesome/4.7.0/css/bundle").Include(
               "~/Client/libs/font-awesome/4.7.0/css/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Client/app/styles/bundle").Include(
               "~/Client/app/styles/Site.css"));
        }

        private static void RegisterAngularToastrBundle(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css/angular-toastr").Include(
                "~/Client/libs/angular-toastr/2.1.1/css/angular-toastr.css"));

            bundles.Add(new ScriptBundle("~/bundles/js/angular-toastr").Include(
                "~/Client/libs/angular-toastr/2.1.1/js/angular-toastr.tpls.js"));
        }

        private static void RegisterAppModuleAndServicesBundle(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/moduleAndservices").Include(
               "~/Client/app/Application/app.mainmodule.js",
               "~/Client/app/Application/shared/toastr-service/toastr-service.js",
               "~/Client/app/Application/shared/app_data_service/home-data-service.js"));
        }

        private static void RegisterComponentBundle(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/components").Include(
               "~/Client/app/Application/home/home.component.js"));
        }

    }
}