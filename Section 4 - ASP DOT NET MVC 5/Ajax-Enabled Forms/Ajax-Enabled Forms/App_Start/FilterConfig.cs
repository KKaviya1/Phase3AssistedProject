﻿using System.Web;
using System.Web.Mvc;

namespace Ajax_Enabled_Forms
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
