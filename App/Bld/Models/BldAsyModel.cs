using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using System.Text;

namespace OctaneApp.App.Bld.Models
{
    public class BldAsyModel
    {

        public string AsyId { get; set; }

        [Display(Name = "Site")]
        [Required(ErrorMessage = "Please Select Site")]
        public string SiteId { get; set; }

        [StringLength(3)]
        public string SiteCode { get; set; }

        [Display(Name = "Customer")]
        [Required(ErrorMessage = "Please Select Customer")]
        [StringLength(8)]
        public string CustPrefix { get; set; }

        [Display(Name = "Enter Asy.Number")]
        [Required(ErrorMessage = "Please Enter Asy.Number")]
        [StringLength(50)]
        public string AsyNmbr { get; set; }

        [Display(Name = "Enter Asy.Rev")]
        [Required(ErrorMessage = "Please Enter Asy.Rev")]
        [StringLength(50)]
        public string AsyRev { get; set; }

        [Display(Name = "Enter Asy.Description")]
        [Required(ErrorMessage = "Please Enter Asy.Desc")]
        [StringLength(250)]
        public string AsyDesc { get; set; }

        [Display(Name = "Enter Asy.Number")]
        [Required(ErrorMessage = "Please Enter Cust.Asy Number")]
        [StringLength(50)]
        public string CustAsyNmbr { get; set; }

        [Display(Name = "Enter Asy.Rev")]
        [Required(ErrorMessage = "Please Enter Cust.Asy.Rev")]
        [StringLength(50)]
        public string CustAsyRev { get; set; }


        [Display(Name = "Enter Asy.Description")]
        [Required(ErrorMessage = "Please Enter Customer Asy.Desc")]
        [StringLength(250)]
        public string CustAsyDesc { get; set; }


        [Display(Name = "Enter PCB.Number")]
        [Required(ErrorMessage = "Please Enter PCB.Number")]
        [StringLength(50)]
        public string PcbaNmbr { get; set; }

        [Display(Name = "Enter PCB.Description")]
        [Required(ErrorMessage = "Please Enter PCB.Description")]
        [StringLength(250)]
        public string PcbaDesc { get; set; }

        [Display(Name = "Enter PCB.Rev")]
        [Required(ErrorMessage = "Please Enter PCB.Rev")]
        [StringLength(50)]
        public string PcbaRev { get; set; }

        [Display(Name = "Lead Free")]
        [Required(ErrorMessage = "Please Select Lead")]
        public bool Leadfree { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Please Select Status")]
        public bool Status { get; set; }

        public bool AllowExtraItem { get; set; }

        public bool StrictMrg { get; set; }

        [Display(Name = "Clean Type")]
        [Required(ErrorMessage = "Please Select Clean Type")]
        [StringLength(20)]
        public string CleanType { get; set; }


        [Display(Name = "Unit Type")]
        [Required(ErrorMessage = "Please Select Unit Type")]
        [StringLength(20)]
        public string UnitType { get; set; }

        [Display(Name = "Build Type")]
        [Required(ErrorMessage = "Please Select Build Type")]
        [StringLength(20)]
        public string BuildType { get; set; }

        public bool? SubAsyRqd { get; set; }

        public bool IsItar { get; set; }

        public bool IsFda { get; set; }

        public bool IsAte { get; set; }

        public bool IsPnlUnit { get; set; }

        [Display(Name = "1")]
        public int UnitPrPnl { get; set; }

        public bool AutoShip { get; set; }

        public int? ShipDocId { get; set; }

        [StringLength(200)]
        public string DocName { get; set; }

        [Display(Name = "Shipping Instruction")]
        [StringLength(1000)]
        public string ShipInstruction { get; set; }

        public bool PackCoc { get; set; }

        [Display(Name = "0.00")]
        public int? CompTop { get; set; }

        [Display(Name = "0.00")]
        public int? CompBot { get; set; }

        [Display(Name = "0.00")]
        public int? SldrTop { get; set; }

        [Display(Name = "0.00")]
        public int? SldrBot { get; set; }

        [Display(Name = "0.00")]
        public int? ThComp { get; set; }

        [Display(Name = "0.00")]
        public int? ThPins { get; set; }

        [Display(Name = "0.00")]
        public decimal? SldrHeightTopUpper { get; set; }

        [Display(Name = "0.00")]
        public decimal? SldrHeightBotUpper { get; set; }

        [Display(Name = "0.00")]
        public decimal? SldrHeightTopLower { get; set; }

        [Display(Name = "0.00")]
        public decimal? SldrHeightBotLower { get; set; }

        [Display(Name = "Comments")]
        [StringLength(1000)]
        public string AsyCmnts { get; set; }

        public DateTime InsertOn { get; set; }

        public DateTime UpdateOn { get; set; }

        public int InsertByEmpId { get; set; }

        public int UpdateByEmpId { get; set; }

        [StringLength(101)]
        public string InsertByEmpName { get; set; }

        [StringLength(101)]
        public string UpdateByEmpName { get; set; }

        // FOR LOGS //
        public string actionInfo { get; set; }

        // FOR SOLDER //

        [Display(Name = "Solder List")]
        [StringLength(50)]
        public string SldrPin { get; set; }

        public List<AsyList> lstAsy { get; set; }
        public IList<SelectListItem> site;
        public IList<SelectListItem> customers;
        public IList<SelectListItem> rev;
        public IList<SelectListItem> buildType;

        public IList<SelectListItem> cleanType;

        public IList<SelectListItem> unitType;

        public List<SPList> lstSP { get; set; }

        public Dictionary<string, string> SetAsyProperties { get; set; }

        //--- FOR GENEALOGY----//

        public int LineNmbr { get; set; }

        [Display(Name = "Sub Asy:")]
        public string SubAsy { get; set; }

        [StringLength(500)]
        [Display(Name = "Sub Rev:")]
        public string SubRevRqd { get; set; }

        [StringLength(250)]
        public string SubDesc { get; set; }

        [Display(Name = "Required:")]
        public bool? IsRqd { get; set; }

        [StringLength(1)]
        [Display(Name = "Unique:")]
        public string IsUnique { get; set; }

        public bool? IsInternal { get; set; }

        [StringLength(15)]
        [Display(Name = "Merge Type")]
        public string MrgType { get; set; }

        //LIST----//

        public IList<SelectListItem> mergeType;

        public IList<SelectListItem> subAsy;

        public List<GenealogyList> GenLst { get; set; }

        public List<AsyRevList> SubRevLst { get; set; }

        public List<AsyRoutList> lstRoute { get; set; }



        #region ASSEMBLY METHODS

        public string GetAsyList()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = "SELECT S.SiteName, S.SiteId, C.CustName, C.CustPrefix, CASE WHEN MST.Status = 1 THEN 'Active' ELSE 'Inactive'  END AS Status, ";
                query += "MST.AsyId, MST.AsyNmbr, MST.AsyRev, MST.AsyDesc, CASE WHEN MST.Leadfree = 1 THEN 'Yes' ELSE 'No' END AS Leadfree FROM oAsyMst MST ";
                query += "INNER JOIN CoSiteLst S ON S.SiteId = MST.SiteId ";
                query += "INNER JOIN oCustMst C ON C.CustPrefix = MST.CustPrefix ";
                DataTable dt = oDAL.GetRecord(query, false);
                lstAsy = new List<AsyList>();
                AsyList oAsyList;

                foreach (DataRow dataRow in dt.Rows)
                {
                    oAsyList = new AsyList();

                    oAsyList.AsyId = int.Parse(dataRow["AsyId"].ToString());
                    //oAsyList.SiteId = dataRow["SiteId"].ToString();
                    oAsyList.SiteName = dataRow["SiteName"].ToString();
                    oAsyList.CustName = dataRow["CustName"].ToString();
                    oAsyList.CustStatus = dataRow["Status"].ToString();
                    //  oAsyList.CustPrefix = dataRow["CustPrefix"].ToString();
                    oAsyList.AsyNmbr = dataRow["AsyNmbr"].ToString();
                    oAsyList.AsyRev = dataRow["AsyRev"].ToString();
                    oAsyList.AsyDesc = dataRow["AsyDesc"].ToString();
                    //oAsyList.LeadFree = dataRow["LeadFree"].ToString();

                    lstAsy.Add(oAsyList);
                }
            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }


        public string GetRoutList()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = string.Empty;
                query = "SELECT StepNmbr, AxsNameFull, IsPassFail,  PassToStep, SkipToStep FROM oAsyRte WHERE AsyId=" + AsyId;
                DataTable dt = oDAL.GetRecord(query, false);
                lstRoute = new List<AsyRoutList>();

                AsyRoutList oRoutList;
                foreach(DataRow dr in dt.Rows)
                {
                    oRoutList = new AsyRoutList();

                    oRoutList.StepNmbr = Convert.ToInt32(dr["StepNmbr"].ToString());
                    oRoutList.AxsNameFull = dr["AxsNameFull"].ToString();
                    oRoutList.IsPassFail =dr["IsPassFail"].ToString();
                    oRoutList.PassToStep = dr["PassToStep"].ToString();
                    oRoutList.SkipToStep = dr["SkipToStep"].ToString();
                    lstRoute.Add(oRoutList);

                }


            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);

            }
            return validationSummary.ToString();
        }


        public string LoadAsyParamDD()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                // LOADING SITES //

                string query;
                query = "SELECT S.SiteName, CONCAT( S.SiteId,  '@', S.SiteCode)Site FROM oEmpSiteX X ";
                query += "INNER JOIN CoSiteLst S ON X.SiteId = S.SiteId ";
                query += "WHERE EmpId = " + System.Web.HttpContext.Current.Session["EmpID"].ToString() + "";
                query += "ORDER BY S.SiteName  ";
                site = cCommon.BindDropDownList(query, "SiteName", "Site");

                //LOADING CUSTOMERS
                string query1;
                query1 = "SELECT A.CustName, A.CustPrefix FROM oCustMst AS A ";
                query1 += "INNER JOIN oCustSiteX AS B ON A.CustId = B.CustId AND B.Active = 1 ";
                query1 += "WHERE B.SiteId = 2 ORDER BY CustName ";
                customers = cCommon.BindDropDownList(query1, "CustName", "CustPrefix");


                //LOADING TYPES
                string query2 = "SELECT LkupDesc, LkupId FROM CoLkupLst WHERE IsActive  = 1 AND LkupType= 'Build_TYPE' ";
                buildType = cCommon.BindDropDownList(query2, "LkupDesc", "LkupId");

                string query3 = "SELECT LkupDesc, LkupId FROM CoLkupLst WHERE IsActive  = 1 AND LkupType= 'CLEAN_TYPE' ";
                cleanType = cCommon.BindDropDownList(query3, "LkupDesc", "LkupId");

                string query4 = "SELECT LkupDesc, LkupId FROM CoLkupLst WHERE IsActive  = 1 AND LkupType= 'UNIT_TYPE' ";
                unitType = cCommon.BindDropDownList(query4, "LkupDesc", "LkupId");

            }
            catch (Exception ex)
            {
                //RECORD EXCEPTIONS HERE
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }


        //LOADING REV  //
        public IList<SelectListItem> LoadRev(string asyNmbr, string siteId)
        {
            if (asyNmbr != "" || siteId != "")
            {
                string query = "SELECT AsyRev ";
                query += "FROM oAsyMst Where AsyNmbr='" + asyNmbr + "' AND SiteId =" + siteId;

                return rev = cCommon.BindDropDownList(query, "AsyRev", "AsyRev");

            }
            else
            {

                return rev = null;
            }

        }

        //LOADING CUSTOMERS //
        public IList<SelectListItem> LoadCustomers(string siteId, string siteCode)
        {
            if (siteId != "" || siteCode != null)
            {
                //LOADING CUSTOMERS
                string query1;
                query1 = "SELECT A.CustName, A.CustPrefix FROM oCustMst AS A ";
                query1 += "INNER JOIN oCustSiteX AS B ON A.CustId = B.CustId AND B.Active = 1 ";
                query1 += "WHERE B.SiteId = " + siteId + " ORDER BY CustName ";
                return customers = cCommon.BindDropDownList(query1, "CustName", "CustPrefix");
            }
            else
            {
                return customers = null;

            }
        }

        public string LoadAsy(string asyId)
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = "SELECT * FROM oAsyMst AM WHERE AM.AsyId ='" + asyId + "'";
                DataTable dt = oDAL.GetRecord(query, false);
                SiteId = dt.Rows[0]["SiteId"].ToString() + "@" + dt.Rows[0]["SiteCode"].ToString();
                //LoadCustomers(dt.Rows[0]["SiteId"].ToString(), dt.Rows[0]["SiteCode"].ToString());
                CustPrefix = dt.Rows[0]["CustPrefix"].ToString();
                //SiteCode = dt.Rows[0]["SiteCode"].ToString();
                AsyNmbr = dt.Rows[0]["AsyNmbr"].ToString();
                AsyId = Convert.ToString(dt.Rows[0]["AsyId"].ToString());
                AsyRev = dt.Rows[0]["AsyRev"].ToString();
                AsyDesc = dt.Rows[0]["AsyDesc"].ToString();
                CustAsyNmbr = dt.Rows[0]["CustAsyNmbr"].ToString();
                CustAsyRev = dt.Rows[0]["CustAsyRev"].ToString();
                CustAsyDesc = dt.Rows[0]["CustAsyDesc"].ToString();
                PcbaNmbr = dt.Rows[0]["PcbaNmbr"].ToString();
                PcbaRev = dt.Rows[0]["PcbaRev"].ToString();
                PcbaDesc = dt.Rows[0]["PcbaDesc"].ToString();
                BuildType = dt.Rows[0]["BuildType"].ToString();
                CleanType = dt.Rows[0]["CleanType"].ToString();
                UnitType = dt.Rows[0]["UnitType"].ToString();
                Leadfree = Convert.ToBoolean(dt.Rows[0]["Leadfree"]);
                Status = Convert.ToBoolean(dt.Rows[0]["Status"]);
                CompTop = Convert.ToInt32(dt.Rows[0]["CompTop"].ToString());
                CompBot = Convert.ToInt32(dt.Rows[0]["CompBot"].ToString());
                SldrTop = Convert.ToInt32(dt.Rows[0]["SldrTop"].ToString());
                SldrBot = Convert.ToInt32(dt.Rows[0]["SldrBot"].ToString());
                ThComp = Convert.ToInt32(dt.Rows[0]["ThComp"].ToString());
                ThPins = Convert.ToInt32(dt.Rows[0]["ThPins"].ToString());
                AsyCmnts = dt.Rows[0]["AsyCmnts"].ToString();
                SldrHeightBotUpper = Convert.ToDecimal(dt.Rows[0]["SldrHeightBotUpper"].ToString());
                SldrHeightBotLower = Convert.ToDecimal(dt.Rows[0]["SldrHeightBotLower"].ToString());
                SldrHeightTopUpper = Convert.ToDecimal(dt.Rows[0]["SldrHeightTopUpper"].ToString());
                SldrHeightTopLower = Convert.ToDecimal(dt.Rows[0]["SldrHeightTopLower"].ToString());
                IsPnlUnit = Convert.ToBoolean(dt.Rows[0]["IsPnlUnit"]);
                IsItar = Convert.ToBoolean(dt.Rows[0]["IsItar"]);
                IsAte = Convert.ToBoolean(dt.Rows[0]["IsAte"]);
                IsFda = Convert.ToBoolean(dt.Rows[0]["IsFda"]);
                AllowExtraItem = Convert.ToBoolean(dt.Rows[0]["AllowExtraItem"]);
                StrictMrg = Convert.ToBoolean(dt.Rows[0]["StrictMrg"]);
                PackCoc = Convert.ToBoolean(dt.Rows[0]["PackCoc"]);
                AutoShip = Convert.ToBoolean(dt.Rows[0]["AutoShip"]);
                ShipInstruction = dt.Rows[0]["ShipInstruction"].ToString();
                UnitPrPnl = Convert.ToInt32(dt.Rows[0]["UnitPrPnl"].ToString());


                //GET SOLDER PIN
                query = "SELECT SldrPin FROM oAsySldr where AsyNmbr = '" + AsyNmbr + "' and AsyRev = '" + AsyRev + "' and SiteId = " + dt.Rows[0]["SiteId"].ToString() + "";
                DataTable dtSP = oDAL.GetRecord(query, false);

                lstSP = new List<SPList>();
                SPList oSPList;
                foreach (DataRow dr in dtSP.Rows)
                {
                    oSPList = new SPList();

                    oSPList.sldrPin = dr["SldrPin"].ToString();
                    oSPList.DMLType = "U";
                    lstSP.Add(oSPList);
                }


            }
            catch (Exception ex)
            {
                //RECORD EXCEPTIONS HERE
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        public string SaveAsy()
        {
            cDAL oDAL = new cDAL(true);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                char[] delemeters = { '@' };
                string[] arr = SiteId.Split(delemeters);

                int siteId = int.Parse(arr[0]);
                string siteCode = arr[1];
                Dictionary<string, object> asyMatrix = new Dictionary<string, object>();
                asyMatrix["SiteId"] = siteId;
                asyMatrix["SiteCode"] = siteCode;
                asyMatrix["AsyNmbr"] = AsyNmbr;
                asyMatrix["AsyRev"] = AsyRev;
                asyMatrix["AsyDesc"] = AsyDesc;
                asyMatrix["CustPrefix"] = CustPrefix;
                asyMatrix["BuildType"] = BuildType;
                asyMatrix["CleanType"] = CleanType;
                asyMatrix["UnitType"] = UnitType;
                asyMatrix["LeadFree"] = Leadfree;
                asyMatrix["Status"] = Status;
                asyMatrix["CustAsyNmbr"] = CustAsyNmbr;
                asyMatrix["CustAsyRev"] = CustAsyRev;
                asyMatrix["CustAsyDesc"] = CustAsyDesc;
                asyMatrix["CompTop"] = CompTop;
                asyMatrix["CompBot"] = CompBot;
                asyMatrix["ThComp"] = ThComp;
                asyMatrix["SldrTop"] = SldrTop;
                asyMatrix["SldrBot"] = SldrBot;
                asyMatrix["ThPins"] = ThPins;
                asyMatrix["AsyCmnts"] = AsyCmnts;
                asyMatrix["PcbaNmbr"] = PcbaNmbr;
                asyMatrix["PcbaRev"] = PcbaRev;
                asyMatrix["PcbaDesc"] = PcbaDesc;
                asyMatrix["SldrHeightTopUpper"] = SldrHeightTopUpper;
                asyMatrix["SldrHeightTopLower"] = SldrHeightTopLower;
                asyMatrix["SldrHeightBotUpper"] = SldrHeightBotUpper;
                asyMatrix["SldrHeightBotLower"] = SldrHeightBotLower;
                asyMatrix["IsPnlUnit"] = IsPnlUnit;
                asyMatrix["IsItar"] = IsItar;
                asyMatrix["IsFda"] = IsFda;
                asyMatrix["IsAte"] = IsAte;
                asyMatrix["UnitPrPnl"] = UnitPrPnl;
                asyMatrix["AllowExtraItem"] = AllowExtraItem;
                asyMatrix["StrictMrg"] = StrictMrg;
                asyMatrix["PackCoc"] = PackCoc;
                asyMatrix["AutoShip"] = AutoShip;
                asyMatrix["ShipInstruction"] = ShipInstruction;
                asyMatrix["InsertByEmpId"] = System.Web.HttpContext.Current.Session["EmpID"].ToString();
                // asyMatrix["InsertOn"] = System.DateTime.Now;

                oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oAsyMst", asyMatrix, null, true);

                Dictionary<string, object> sldrMatrix = new Dictionary<string, object>();
                if (lstSP != null)
                {
                    foreach (var row in lstSP)
                    {
                        sldrMatrix["SiteId"] = siteId;
                        sldrMatrix["sldrPin"] = row.sldrPin;
                        sldrMatrix["AsyNmbr"] = AsyNmbr;
                        sldrMatrix["AsyRev"] = AsyRev;
                        sldrMatrix["CustPrefix"] = CustPrefix;
                        sldrMatrix["InsertByEmpId"] = System.Web.HttpContext.Current.Session["EmpID"].ToString();
                        sldrMatrix["InsertOn"] = System.DateTime.Now;

                        if (row.DMLType == "I")
                        {
                            oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oAsySldr", sldrMatrix, null, true);
                        }
                    }
                }

                oDAL.Commit();
            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        public string UpdateAsy()
        {
            cDAL oDAL = new cDAL(true);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string WhereClause = string.Empty;
                string sldrWhereClause = string.Empty;
                char[] delemeters = { '@' };
                string[] arr = SiteId.Split(delemeters);

                int siteId = int.Parse(arr[0]);
                string siteCode = arr[1];
                Dictionary<string, object> asyMatrix = new Dictionary<string, object>();
                // asyMatrix["SiteId"] = siteId;
                asyMatrix["SiteCode"] = siteCode;
                //asyMatrix["AsyNmbr"] = AsyNmbr;
                //asyMatrix["AsyRev"] = AsyRev;
                asyMatrix["AsyDesc"] = AsyDesc;
                asyMatrix["CustPrefix"] = CustPrefix;
                asyMatrix["BuildType"] = BuildType;
                asyMatrix["CleanType"] = CleanType;
                asyMatrix["UnitType"] = UnitType;
                asyMatrix["LeadFree"] = Leadfree;
                asyMatrix["Status"] = Status;
                asyMatrix["CustAsyNmbr"] = CustAsyNmbr;
                asyMatrix["CustAsyRev"] = CustAsyRev;
                asyMatrix["CustAsyDesc"] = CustAsyDesc;
                asyMatrix["CompTop"] = CompTop;
                asyMatrix["CompBot"] = CompBot;
                asyMatrix["ThComp"] = ThComp;
                asyMatrix["SldrTop"] = SldrTop;
                asyMatrix["SldrBot"] = SldrBot;
                asyMatrix["ThPins"] = ThPins;
                asyMatrix["AsyCmnts"] = AsyCmnts;
                asyMatrix["PcbaNmbr"] = PcbaNmbr;
                asyMatrix["PcbaRev"] = PcbaRev;
                asyMatrix["PcbaDesc"] = PcbaDesc;
                asyMatrix["SldrHeightTopUpper"] = SldrHeightTopUpper;
                asyMatrix["SldrHeightTopLower"] = SldrHeightTopLower;
                asyMatrix["SldrHeightBotUpper"] = SldrHeightBotUpper;
                asyMatrix["SldrHeightBotLower"] = SldrHeightBotLower;
                asyMatrix["IsPnlUnit"] = IsPnlUnit;
                asyMatrix["IsItar"] = IsItar;
                asyMatrix["IsFda"] = IsFda;
                asyMatrix["IsAte"] = IsAte;
                asyMatrix["UnitPrPnl"] = UnitPrPnl;
                asyMatrix["AllowExtraItem"] = AllowExtraItem;
                asyMatrix["StrictMrg"] = StrictMrg;
                asyMatrix["PackCoc"] = PackCoc;
                asyMatrix["AutoShip"] = AutoShip;
                asyMatrix["ShipInstruction"] = ShipInstruction;
                asyMatrix["UpdateByEmpId"] = System.Web.HttpContext.Current.Session["EmpID"].ToString();
                asyMatrix["UpdateOn"] = System.DateTime.Now;
                WhereClause = "AsyId=" + AsyId;

                oDAL.ExecuteQuery(cDAL.QueryType.UPDATE, "oAsyMst", asyMatrix, WhereClause, true);

                Dictionary<string, object> sldrMatrix = new Dictionary<string, object>();
                if (lstSP != null)
                {
                    foreach (var row in lstSP)
                    {
                        sldrMatrix["SiteId"] = siteId;
                        sldrMatrix["sldrPin"] = row.sldrPin;
                        sldrMatrix["AsyNmbr"] = AsyNmbr;
                        sldrMatrix["AsyRev"] = AsyRev;
                        sldrMatrix["CustPrefix"] = CustPrefix;
                        sldrMatrix["InsertByEmpId"] = System.Web.HttpContext.Current.Session["EmpID"].ToString();
                        sldrMatrix["InsertOn"] = System.DateTime.Now;
                        WhereClause = "AsyNmbr='" + AsyNmbr + "' AND AsyRev='" + AsyRev + "' AND CustPrefix='" + CustPrefix + "' AND SiteId=" + siteId + " AND SldrPin ='" + row.sldrPin + "' ";

                        if (row.DMLType == "I")
                        {
                            oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oAsySldr", sldrMatrix, null, true);
                        }

                        if (row.DMLType == "D")
                        {
                            oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oAsySldr", sldrMatrix, WhereClause, true);
                        }
                    }
                }
                oDAL.Commit();
            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        public string CheckAsy(string asyNmbr, string siteId)
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = "SELECT AsyNmbr, AsyRev, AsyDesc, CustAsyNmbr, CustAsyRev, CustAsyDesc, CustPrefix ";
                query += "FROM oAsyMst Where AsyNmbr='" + asyNmbr + "' AND SiteId =" + siteId;
                DataTable dt = oDAL.GetRecord(query, false);
                if (dt.Rows.Count == 0)
                {
                    validationSummary.Append("No Record Found");
                }
            }

            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        public string CheckAsyRev(string asyNmbr, string asyRev, string siteId)
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = "SELECT AsyNmbr, AsyRev, AsyDesc, CustAsyNmbr, CustAsyRev, CustAsyDesc, CustPrefix ";
                query += "FROM oAsyMst Where AsyNmbr ='" + asyNmbr + "' AND AsyRev='" + asyRev + "' AND SiteId =" + siteId;
                DataTable dt = oDAL.GetRecord(query, false);
                if (dt.Rows.Count == 0)
                {
                    validationSummary.Append("No Record Found");
                }
            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }

            return validationSummary.ToString();
        }

        public string GetAsySummaryById()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = string.Empty;
                DataTable dtTasy;

                //GET ASY INFO
                query = "SELECT AsyNmbr, AsyRev, AsyDesc, CustAsyNmbr, CustAsyRev, CustAsyDesc, ";
                query += "BuildType, CleanType, UnitType, Leadfree, Status FROM oAsyMst  WHERE AsyId=" + AsyId;
                dtTasy = oDAL.GetRecord(query, false);
                AsyNmbr = dtTasy.Rows[0]["AsyNmbr"].ToString();
                AsyRev = dtTasy.Rows[0]["AsyRev"].ToString();
                AsyDesc = dtTasy.Rows[0]["AsyDesc"].ToString();
                CustAsyNmbr = dtTasy.Rows[0]["CustAsyNmbr"].ToString();
                CustAsyRev = dtTasy.Rows[0]["CustAsyRev"].ToString();
                CustAsyDesc = dtTasy.Rows[0]["CustAsyDesc"].ToString();
                BuildType = dtTasy.Rows[0]["BuildType"].ToString();
                CleanType = dtTasy.Rows[0]["CleanType"].ToString();
                UnitType = dtTasy.Rows[0]["UnitType"].ToString();
                Leadfree = bool.Parse(dtTasy.Rows[0]["Leadfree"].ToString());
                Status = bool.Parse(dtTasy.Rows[0]["Status"].ToString());
                GetRoutList();

                Dictionary<string, string> values = new Dictionary<string, string>();
                foreach (string colName in SetAsyProperties.Keys)
                {
                    if (this.GetType().GetProperty(colName).GetValue(this, null) != null)
                    {
                        values[colName] = this.GetType().GetProperty(colName).GetValue(this, null).ToString();
                    }
                    else
                    {
                        values[colName] = null;
                    }
                }
                SetAsyProperties = values;
            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);

            }
            return validationSummary.ToString();
        }

        #endregion

        #region GENEOLOGY METHODS

        public string LoadGenealogyDD()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            { // LOADING MERGE TYPES
                string query;

                query = "SELECT AxsNameFull, AxsCode FROM CoAxsLst ";
                query += "WHERE InRte = 1 AND TaskGrp ='Merge' AND IsActive = 1 ";
                query += "ORDER BY AxsCode, AxsNameShort";
                mergeType = cCommon.BindDropDownList(query, "AxsNameFull", "AxsCode");

                // LOADING SUB ASY //
                string query1;

                query1 = "SELECT LkupDesc, LkupId FROM CoLkupLst ";
                query1 += "WHERE LkupType ='CTO' AND IsActive  = 1 ";
                query1 += "ORDER BY LkupDesc";
                subAsy = cCommon.BindDropDownList(query1, "LkupDesc", "LkupId");
            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        public string LoadGenealogy(string asyId)
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                // LOADING GENEALOGY //

                if (asyId != "")
                {
                    string query;
                    query = "SELECT AsyId, LineNmbr, AsyNmbr, AsyRev, CustPrefix, SubAsyRqd, SubRevRqd, SubDesc, IsRqd, IsUnique, IsInternal, ";
                    query += " MrgType, SiteId, SiteCode, InsertOn, InsertByEmpId, InsertByEmpName, UpdateOn, UpdateByEmpId, UpdateByEmpName, '' AS DML  ";
                    query += "FROM oAsyGnlgy WHERE AsyId= " + asyId;

                    DataTable dtGen = oDAL.GetRecord(query, false);
                    GenLst = new List<GenealogyList>();
                    GenealogyList oGenList;

                    foreach (DataRow dr in dtGen.Rows)
                    {
                        oGenList = new GenealogyList();

                        oGenList.AsyId = dr["AsyId"].ToString();
                        oGenList.AsyNmbr = dr["AsyNmbr"].ToString();
                        oGenList.AsyRev = dr["AsyRev"].ToString();
                        oGenList.SiteId = dr["SiteId"].ToString();
                        oGenList.SiteCode = dr["SiteCode"].ToString();
                        oGenList.CustPrefix = dr["CustPrefix"].ToString();
                        oGenList.LineNmbr = int.Parse(dr["LineNmbr"].ToString());
                        oGenList.SubAsyRqd = dr["SubAsyRqd"].ToString();
                        oGenList.SubRevRqd = dr["SubRevRqd"].ToString();
                        oGenList.SubDesc = dr["SubDesc"].ToString();
                        oGenList.IsRqd = bool.Parse(dr["IsRqd"].ToString());
                        oGenList.IsUnique = dr["IsUnique"].ToString();
                        oGenList.IsInternal = bool.Parse(dr["IsInternal"].ToString());
                        oGenList.MrgType = dr["MrgType"].ToString();

                        GenLst.Add(oGenList);
                    }

                }

            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }

            return validationSummary.ToString();
        }

        public string GetAsyRev(string asyId, string asyNmbr)
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query;
                query = "SELECT AsyNmbr, AsyDesc , AsyRev ";
                query += "FROM oAsyMst ";
                query += "WHERE Status = 1 AND AsyNmbr ='" + asyNmbr + "' AND AsyId = '" + asyId + "' ";
                query += "GROUP BY AsyRev, AsyNmbr, AsyDesc ";
                query += "ORDER BY AsyRev ";
                DataTable dtRev = oDAL.GetRecord(query, false);
                if (dtRev.Rows.Count == 0)
                {

                    validationSummary.Append(asyNmbr + " " + "does not exist");
                }
                else
                {
                    SubRevLst = new List<AsyRevList>();
                    AsyRevList oRevLst = new AsyRevList();

                    foreach (DataRow dr in dtRev.Rows)
                    {
                        oRevLst.AsyNmbr = dr["AsyNmbr"].ToString();
                        oRevLst.AsyDesc = dr["AsyDesc"].ToString();
                        oRevLst.AsyRev = dr["AsyRev"].ToString();
                        SubRevLst.Add(oRevLst);
                    }
                }
            }
            catch (Exception ex)
            {

                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        #endregion

    }

    #region ASSEMBLY PROPERTIES
    //ASY LIST
    public class AsyList
    {

        public int AsyId { get; set; }

        public string SiteName { get; set; }

        public string SiteId { get; set; }

        public string CustName { get; set; }

        public string CustPrefix { get; set; }

        public string CustStatus { get; set; }

        public string AsyNmbr { get; set; }

        public string AsyRev { get; set; }

        public string AsyDesc { get; set; }

        public string LeadFree { get; set; }

    }

    //SOLDER LIST
    public class SPList
    {
        public string sldrPin { get; set; }
        public string DMLType { get; set; }


    }

    #endregion

    #region GENEOLOGY PROPERTIES

    public class GenealogyList
    {
        public int LineNmbr { get; set; }
        public string SubAsyRqd { get; set; }

        public string SubRevRqd { get; set; }

        public string SubDesc { get; set; }

        public bool? IsRqd { get; set; }

        public string IsUnique { get; set; }

        public bool? IsInternal { get; set; }

        public string MrgType { get; set; }

        public string SiteId { get; set; }

        public string SiteCode { get; set; }

        public string CustPrefix { get; set; }

        public string AsyId { get; set; }

        public string AsyNmbr { get; set; }

        public string AsyRev { get; set; }

        public string DML { get; set; }
    }
    public class AsyRevList
    {
        public string AsyNmbr { get; set; }

        public string AsyRev { get; set; }

        public string AsyDesc { get; set; }
    }
    public class AsyRoutList
    {
        public int StepNmbr { get; set; }

        public string AxsNameFull { get; set; }

        public string IsPassFail { get; set; }

        public string  PassToStep { get; set; }

        public string SkipToStep { get; set; }
    }
    #endregion
}