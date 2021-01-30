using System.Web;
using System.Web.Mvc;

namespace Phamthitrmy_1721050372
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
