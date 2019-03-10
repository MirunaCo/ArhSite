using System.Web;
using System.Web.Optimization;

namespace ArhSite
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
                     "~/Scripts/modernizr-*"));

         bundles.Add(new ScriptBundle("~/bundles/mainbootstrap").Include(
                   "~/Scripts/bootstrap.js",
                    "~/Scripts//Plugins/easing.1.3.js",
                    "~/Scripts/detectmobilebrowser.js",
                    "~/Scripts/FormAlert.js",

                     "~/Scripts/Plugins/jquery.vegas.min.js",
                     "~/Scripts/Plugins/wow.min.js",
                     "~/Scripts/Plugins/owl.carousel.min.js",
                     "~/Scripts/jquery.fitvids.js",
                     "~/Scripts/functions.js",
                     "~/Scripts/initialise-functions.js"));

         bundles.Add(new StyleBundle("~/Content/css").Include(
                   "~/Content/bootstrap.css",
                   "~/Content/styles.css",
                     "~/Content/bootstrap-theme.min.css",
                   "~/Content/Plugins/animate.css",
                   "~/Content/Plugins/lightbox.css",
                   "~/Content/Plugins/owl.carousel.css",
                   "~/Content/Plugins/owl.theme.css",
                   "~/Content/Plugins/jquery.vegas.min.css"));
      }
   }
}
