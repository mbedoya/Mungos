﻿using System.Web;
using System.Web.Mvc;

namespace Mungos.WebSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Plenum.WebSite.App_Start.Filters.FilterActions());
        }
    }
}