using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace HitssMVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/css/shop-item.css"));
                 

               bundles.Add(new ScriptBundle("~/bundles/js")
                   .Include(
                   "~/Content/vendor/jquery/jquery.min.js",
                   "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js"));
            

        }
    }
}