using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Text;
using System.Web.Routing;

namespace OctaneApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ViewEngines.Engines.Add(new OctaneRazorViewEngine());
            AreaRegistration.RegisterAllAreas();

            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //string keyFileName = ConfigurationManager.AppSettings["Key"];

            try
            {
                //List<string> lines = File.ReadLines(keyFileName).ToList();

                Application["OctaneLive"] = ConfigurationManager.ConnectionStrings["OctaneLive"].ToString();
                Application["OctaneDemo"] = ConfigurationManager.ConnectionStrings["OctaneDemo"].ToString();
                Application["OctaneTrain"] = ConfigurationManager.ConnectionStrings["OctaneTrain"].ToString();
            }
            catch (Exception)
            {
                //RECORD ERRORS
            }
        }

     

        private void SetSessionVariables()
        {
            Session["EmpID"] = "";
            Session["EmpNameFull"] = "";

            // get machine name and store its ip
            string hostName = System.Net.Dns.GetHostName();
            Session["RemoteHost"] = hostName;
            System.Net.IPHostEntry hostEntry = System.Net.Dns.GetHostEntry(hostName);

            foreach (var item in hostEntry.AddressList)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    Session["RemoteAddr"] = item.ToString();
            }


            //CONNECTION STRING
            //Session["Is_Live"] = false;
            //Session["OctaneLive"] = Application["OctaneLive"];
            //Session["OctaneDemo"] = Application["OctaneDemo"];


            //COMMON ERROR MESSAGE
            
            string errMsg="Something went wrong! Contact ISR IT Dept for further assistance.";
            Session["ErrorMsg"] = cCommon.GetPopupError(errMsg);
        }

        private void Session_Start(object sender, EventArgs e)
        {
            //session timeout
            //update user last login
            //check authentication

            SetSessionVariables();
        }
    }
}