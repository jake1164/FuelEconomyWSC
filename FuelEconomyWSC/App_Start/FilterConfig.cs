using System.Web;
using System.Web.Mvc;

namespace NotJustMaple.WebService.FuelEconomy.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}