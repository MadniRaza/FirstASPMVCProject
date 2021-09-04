using System.Web;
using System.Web.Optimization;

namespace OctaneApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts").Include(
                        //"~/Scripts/bootstrap.bundle.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/jquery-3.3.1.js",
                        "~/Scripts/CommonFunction.js",
                        "~/Scripts/jquery.dataTables.js",
                        "~/Scripts/jquery.dataTables.min.js",
                        "~/Scripts/dataTables.select.min.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/bootstrap-grid.css",
                      "~/Content/css/bootstrap-reboot.css",
                      "~/Content/css/fontawesome.css",
                      "~/Content/css/fontawesome-all.css",
                      "~/Content/css/palette-gradient.css",
                      "~/Content/css/layout.css",
                      "~/Content/css/jquery.dataTables.min.css"
                      ));
        }
    }
}
