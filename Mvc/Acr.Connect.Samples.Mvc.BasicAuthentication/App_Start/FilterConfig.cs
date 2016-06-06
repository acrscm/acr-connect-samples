using System.Web;
using System.Web.Mvc;

namespace Acr.Connect.Samples.Mvc.BasicAuthentication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
