using System.Web;
using System.Web.Mvc;

namespace Data_Validation_Using_MetaData
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
