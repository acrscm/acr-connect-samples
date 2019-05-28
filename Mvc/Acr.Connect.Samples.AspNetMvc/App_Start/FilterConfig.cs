using System.Web;
using System.Web.Mvc;

namespace Acr.Connect.Samples.AspNetMvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
