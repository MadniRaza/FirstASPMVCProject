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
    public class ManLgnController : Controller
    {
        //
        // GET: /Auth/
        public ActionResult Auth()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Authenticate(ManLgnModel oModel)
        {
            Dictionary<string, object> response = new Dictionary<string, object>();

            string modelErrors = cCommon.ValidateModel(ModelState);
            if (modelErrors.Length > 0)
            {
                modelErrors = cCommon.MakeMessage(modelErrors, cCommon.MessageType.Warning);
                response["IsValid"] = false;
                response["Message"] = modelErrors;
                return Json(response, JsonRequestBehavior.AllowGet);
            }

         

            //AUTHENTICATING USER
            oModel.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            Session["CSType"] = oModel.CSType;
            string res = oModel.AuthenticateUser();
            if (res.Length == 0)
            {
                ModelState.Clear();
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                response["IsValid"] = false;
                response["Message"] = cCommon.MakeMessage("Unable to Authenticate", cCommon.MessageType.Error);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult InitDashBoard()
        {
            //you can pass routevalues or set session Variables for the Scope here for specfic user or load data at heere
            return RedirectToAction("Home", "ManDshBrd");
        }
    }
}