using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OctaneApp.App.Man.Models;
using System.Configuration;
using System.Data;
namespace OctaneApp.App.Man.Controllers
{
    public class ManDshBrdController : Controller
    {
        // GET: /Dashboard/
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Home()
        {
            return View();
        }
    }
}