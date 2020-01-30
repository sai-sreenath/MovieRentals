using System.Web;
using System.Web.Mvc;

namespace VideoRentals
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
            filters.Add(new RequireHttpsAttribute());//with this,my application endpoints will not support http channel
        }
    }
}
