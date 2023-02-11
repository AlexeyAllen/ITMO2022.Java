using System.Web;
using System.Web.Mvc;

namespace ITMO2022.ASP.Net.MVC.Lab06.Ex01toEx02.MvcCreditApp1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
