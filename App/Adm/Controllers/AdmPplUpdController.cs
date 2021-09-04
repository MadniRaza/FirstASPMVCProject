using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OctaneApp.App.Adm.Models;

namespace OctaneApp.App.Adm.Controllers
{
    public class AdmPplUpdController : Controller
    {
        #region "List"
        public JsonResult GetEmployees(string filterStatus, string filterSiteID, string authEmpSiteIds)
        {
            AdmPplUpdModel oModel = new AdmPplUpdModel();
            Dictionary<string, object> response = new Dictionary<string, object>();
            oModel.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            oModel.filterSiteID = filterSiteID;
            oModel.filterStatus = filterStatus;
            oModel.authEmpSiteIds = authEmpSiteIds;
            
            string res = oModel.GetEmployees();
            if (res.Length == 0)
            {
                response["lstEmployee"] = oModel.lstEmployee;
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

        public JsonResult GetEmployeeSummary(string employeeID, Dictionary<string, string> SetThisProperties)
        {
            AdmPplUpdModel oModel = new AdmPplUpdModel();
            Dictionary<string, object> response = new Dictionary<string, object>();
            oModel.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            oModel.EmpId1 = employeeID;
            oModel.SetThisProperties = SetThisProperties;

            string res = oModel.GetEmployeeSummaryById();
            if (res.Length == 0)
            {
                
                
                
                response["EmployeeSummary"] = oModel.SetThisProperties;
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

        public JsonResult DeactivateEmployee(string EmpId1)
        {
            AdmPplUpdModel oModel = new AdmPplUpdModel();
            Dictionary<string, object> response = new Dictionary<string, object>();
            oModel.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            oModel.EmpId1 = EmpId1;

            string res = oModel.TerminateEmployee();
            if (res.Length == 0)
            {
                response["lstEmployee"] = oModel.lstEmployee;
                response["IsValid"] = true;
                response["Message"] = cCommon.MakeMessage("Employee Terminated Successfully!", cCommon.MessageType.Success);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                response["IsValid"] = false;
                response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult ReactivateEmployee(string EmpId1)
        {
            AdmPplUpdModel oModel = new AdmPplUpdModel();
            Dictionary<string, object> response = new Dictionary<string, object>();
            oModel.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            oModel.EmpId1 = EmpId1;

            string res = oModel.ReactivateEmployee();
            if (res.Length == 0)
            {
                response["lstEmployee"] = oModel.lstEmployee;
                response["IsValid"] = true;
                response["Message"] = cCommon.MakeMessage("Employee Reactivated Successfully!", cCommon.MessageType.Success);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                response["IsValid"] = false;
                response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
        }
        #endregion

        [HttpGet]
        public ActionResult PplUpdList()
        {
            AdmPplUpdModel oModel = new AdmPplUpdModel();
            oModel.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();
            string res = oModel.LoadModelForList();
            if (res.Length == 0)
                return View(oModel);
            else
                return View("~/Shared/Error.cshtml");
        }

        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PplUpdSave(string EmpID)
        {
            
            AdmPplUpdModel oModel = new AdmPplUpdModel();
            oModel.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            if (EmpID == null || EmpID == "")
            {
                string res = oModel.LoadModelForCreate();
                if (res.Length == 0)
                    return View(oModel);
                else
                    return View("~/Shared/Error.cshtml");
            }
            else
            {
                oModel.EmpId1 = EmpID;
                string res = oModel.LoadModelForUpdate();
                if (res.Length == 0)
                    return View(oModel);
                else
                    return View("~/Shared/Error.cshtml");
            }
        }

        [HttpPost]
        public JsonResult PplUpdSave(AdmPplUpdModel oModel)
        {
            Dictionary<string, object> response = new Dictionary<string, object>();
            string modelErrors = cCommon.ValidateModel(ModelState);
            if (modelErrors.Length > 0)
            {
                modelErrors = cCommon.GetPopupError(modelErrors);
                response["IsValid"] = false;
                response["Message"] = modelErrors;
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            if (oModel.EmpId1 == "" || oModel.EmpId1 == null)
            {
                return Json(response, JsonRequestBehavior.AllowGet);
                string res =  oModel.AddEmployeeinSystem();
                if (res.Length == 0)
                {
                    ModelState.Clear();
                    response["IsValid"] = true;
                    response["Message"] = cCommon.MakeMessage("Employee added successfully.", cCommon.MessageType.Success);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    response["IsValid"] = false;
                    response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                string res = oModel.EditEmployeeinSystem();
                if (res.Length == 0)
                {
                    ModelState.Clear();
                    response["IsValid"] = true;
                    response["Message"] = cCommon.MakeMessage("Employee added successfully.", cCommon.MessageType.Success);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    response["IsValid"] = false;
                    response["Message"] = cCommon.MakeMessage(res, cCommon.MessageType.Error);
                    return Json(response, JsonRequestBehavior.AllowGet);
                }

            }
        }

        public JsonResult GetTitleDetail(int titleID)
        {
            AdmPplUpdModel oModel = new AdmPplUpdModel();
            Dictionary<string, object> response = new Dictionary<string, object>();
            oModel.actionInfo = this.ControllerContext.RouteData.Values["action"].ToString() + " » " + this.ControllerContext.RouteData.Values["controller"].ToString();

            oModel.TitleID = titleID;
            string res = oModel.GetTitleDetail();

            if (res.Length == 0)
            {
                response["TRMPlanID"] = oModel.TRMPlanID;
                response["TRMPlanDesc"] = oModel.TRMPlanDesc;
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
    }
}