﻿using System.Web;
using System.Web.Mvc;

namespace Personel_Listeleme
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
