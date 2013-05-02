using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace MvcSimple
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());            
        }
    }
}