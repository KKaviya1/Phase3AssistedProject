using System.Web;
using System.Web.Mvc;

namespace Using_Generic_Classes_To_Perform_CRUD_Op
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
