using System.Web.Optimization;

namespace Easycomtec
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/Angular").Include(
                       "~/Scripts/angular.js",
                       "~/Scripts/angular.min.js",
                       "~/Scripts/ngMask.js"
                        ));


            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
                        "~/Scripts/Chart.js",
                        "~/Scripts/Chart.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/chartJS").Include(
                        "~/Scripts/ChartJS.js"));

            bundles.Add(new ScriptBundle("~/bundles/AngularJs").Include(
                        "~/Scripts/appt.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
