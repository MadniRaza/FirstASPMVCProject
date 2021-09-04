using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OctaneApp
{
    public class OctaneRazorViewEngine : RazorViewEngine
    {
        public OctaneRazorViewEngine()
        {
            ViewLocationFormats = new[] {

         "~/App/Man/Views/{1}/{0}.cshtml", 
         "~/App/Bld/Views/{1}/{0}.cshtml", 
         "~/App/TRM/Views/{1}/{0}.cshtml", 
         "~/App/Adm/Views/{1}/{0}.cshtml", 
         "~/App/Rtr/Views/{1}/{0}.cshtml", 
        };

            PartialViewLocationFormats = new string[]
        {
            "~/App/Shared/Views/{0}.cshtml"
        };
        }

    }
}