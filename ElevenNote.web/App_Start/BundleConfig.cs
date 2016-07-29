using System.Web;
using System.Web.Optimization;

namespace ElevenNote.web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/creative.bootstrap.css",
                "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/creative.bootstrap.js",
                      "~/Scripts/respond.js"));
        }
    }
}
