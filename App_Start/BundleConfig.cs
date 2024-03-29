﻿using System.Web;
using System.Web.Optimization;

namespace Evncpc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/custom.js",
                        "~/Scripts/jquery.js",
                        "~/ Scripts /smoothscroll.js",
                        "~/ Scripts /owl/.carousel.min.js",
                         "~/Scripts/bootstrap.min.js",
                         "~/Scripts/search.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/sb-admin-2.min.css",
                        "~/Content/vendor/datatables/dataTables.bootstrap4.min.css",
                        "~/Content/bootstrap.min.css",
                        "~/Content/font-awesome.min.css",
                        "~/Content/owl.carousel.css",
                        "~/Content/owl.theme.default.min.css",
                        "~/Content/templatemo-style.css",
                        "~/Content/layout-masterpage.css",
                        "~/Content/loginmain.css",
                        "~/Content/registermain.css",
                         "~/Content/searchresult.css"
                      )) ;
            bundles.Add(new ScriptBundle("~/bundles/jscustom").Include(
                        "~/Scripts/search.js"
                ));
        }
    }
}
