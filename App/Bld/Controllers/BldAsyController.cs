using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OctaneApp.App.Bld.Models;
namespace OctaneApp.App.Bld.Controllers
{
    public class BldAsyController : Controller
    {
        #region ASSEMBLY PARAMETER

        public ActionResult AsyList()
        {
            BldAsyModel oAsy = new BldAsyModel();
            oAsy.LoadAsyParamDD();
            string res = oAsy.GetAsyList();
            if (res.Length == 0)
                return View(oAsy);
            else
                return View();
        }

        public JsonResult GetAsySummary(string asyId, Dictionary<string, string> SetAsyProperties)
        {
            BldAsyModel oAsy = new BldAsyModel();
            Dictionary<string, object> response = new Dictionary<string, object>();
            oAsy.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            oAsy.AsyId = asyId;
            oAsy.SetAsyProperties = SetAsyProperties;

            string res = oAsy.GetAsySummaryById();
            if (res.Length == 0)
            {

                response["AsySummary"] = oAsy.SetAsyProperties;
                response["AsyRoute"] = oAsy.lstRoute;
                response["IsValid"] = true;
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                response["IsValid"] = false;
                response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult AsySave(string asyId)
        {
            BldAsyModel oAsy = new BldAsyModel();
            oAsy.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();
            oAsy.LoadAsyParamDD();
            oAsy.LoadGenealogyDD();
            if (asyId == null || asyId == "")
            {
                string res = oAsy.LoadAsyParamDD();
               
                if (res.Length == 0)
                    return View(oAsy);
                else
                    return View("~/Shared/Error.cshtml");
            }
            else
            {
                string res = oAsy.LoadAsy(asyId);
                if (res.Length == 0)
                    return View(oAsy);
                else
                    return View("~/Shared/Error.cshtml");

            }
        }

        [HttpPost]
        public JsonResult AsySave(BldAsyModel oModel)
        {
            Dictionary<string, object> response = new Dictionary<string, object>();
            oModel.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();
            string modelErrors = cCommon.ValidateModel(ModelState);
            if (modelErrors.Length > 0)
            {
                modelErrors = cCommon.GetPopupError(modelErrors);
                response["isValid"] = false;
                response["Message"] = modelErrors;
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            if (oModel.AsyId == "" || oModel.AsyId == null)
            {
                string res = oModel.SaveAsy();
                if (res.Length == 0)
                {
                    ModelState.Clear();
                    response["isValid"] = true;
                    response["Message"] = cCommon.MakeMessage("Record Saved Successfully!", cCommon.MessageType.Success);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    response["isValid"] = false;
                    response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                string res = oModel.UpdateAsy();
                if (res.Length == 0)
                {
                    ModelState.Clear();
                    response["isValid"] = true;
                    response["Message"] = cCommon.MakeMessage("Record Saved Successfully!", cCommon.MessageType.Success);
                    ModelState.Clear();
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    response["isValid"] = false;
                    response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
            }
        }

        public JsonResult GetCustomers(string siteId, string siteCode)
        {
            BldAsyModel oAsy = new BldAsyModel();
            return Json(oAsy.LoadCustomers(siteId, siteCode), JsonRequestBehavior.AllowGet);
        }

        public JsonResult CheckAsy(string asyId, string asyNmbr, string siteId)
        {
            BldAsyModel oAsy = new BldAsyModel();
            Dictionary<string, object> response = new Dictionary<string, object>();
            oAsy.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            string res = oAsy.CheckAsy(asyNmbr, siteId);

            if (res.Length == 0)
            {
                if (asyId == "" || asyId == null)
                {
                    response["isValid"] = true;
                    response["Rev"] = oAsy.LoadRev(asyNmbr, siteId);
                    response["Message"] = cCommon.MakeMessage("Asy Nmbr Allready Exist!", cCommon.MessageType.Warning);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    response["isValid"] = false;
                    response["Rev"] = oAsy.LoadRev(asyNmbr, siteId);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                response["isValid"] = false;
                response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult CheckAsyRev(string asyNmbr, string asyRev, string siteId)
        {
            Dictionary<string, object> response = new Dictionary<string, object>();
            BldAsyModel oAsy = new BldAsyModel();

            string res = oAsy.CheckAsyRev(asyNmbr, asyRev, siteId);

            if (res.Length == 0)
            {
                response["isValid"] = true;
                response["Message"] = cCommon.MakeMessage("Asy Rev Allready Exist!", cCommon.MessageType.Warning);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                response["isValid"] = false;
                response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
        }
        #endregion

        #region ASY GENEALOGY

        public JsonResult GetGenList(string asyId)
        {
            BldAsyModel oAsy = new BldAsyModel();
            Dictionary<string, object> response = new Dictionary<string, object>();
            oAsy.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            string res = oAsy.LoadGenealogy(asyId);

            if (res.Length == 0)
            {
                response["isValid"] = true;
                response["GenList"] = oAsy.GenLst;
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                response["isValid"] = false;
                response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                return Json(response, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult GetAsySubRevs(string asyId, string asyNmbr)
             {

            BldAsyModel oAsy = new BldAsyModel();
            Dictionary<string, object> response = new Dictionary<string, object>();
            oAsy.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            string res = oAsy.GetAsyRev(asyId, asyNmbr);
            if (res.Length == 0)
            {
                response["isValid"] = true;
                response["RevLst"] = oAsy.SubRevLst;
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                response["isValid"] = false;
                response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                return Json(response, JsonRequestBehavior.AllowGet);
            }

        }
        #endregion
    }
}
