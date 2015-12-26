using System.Web.Optimization;

namespace Ticket.UI.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // css styles. 

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/plugins/bootstrap/css/bootstrap.css",
                      "~/assets/css/style.css",
                      "~/assets/css/headers/header-default.css",
                      "~/assets/css/footers/footer-v3.css",
                      "~/assets/plugins/animate.css",
                      "~/assets/plugins/line-icons/line-icons.css",
                      "~/assets/plugins/font-awesome/css/font-awesome.css",
                      "~/assets/plugins/image-hover/css/img-hover.css",
                      "~/assets/css/pages/page_job.css",
                      "~/assets/css/custom.css"
                      ));



            // jquery 

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle("~/bundles/app").IncludeDirectory("~/app", "*.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                "~/assets/plugins/bootstrap/js/bootstrap.min.js",
                "~/assets/plugins/back-to-top.js",
                "~/assets/plugins/smoothScroll.js",
                "~/assets/plugins/jquery.parallax.js",
                "~/assets/plugins/image-hover/js/touch.js",
                "~/assets/plugins/image-hover/js/modernizr.js",
                "~/assets/js/app.js"
                    ));
        }
    }
}
