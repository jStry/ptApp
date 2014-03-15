using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PtApp
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/common/js")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/knockout-{version}.js")
                .Include("~/Scripts/raphael.js"));

            bundles.Add(new StyleBundle("~/bundles/common/css")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/site.css"));
        }
    }
}