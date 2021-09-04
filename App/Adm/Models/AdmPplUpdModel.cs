using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Text;


namespace OctaneApp.App.Adm.Models
{
    public class AdmPplUpdModel
    {
        public struct EmployeeList
        {
            [Required]
            public int EmpId { get; set; }

            public string TermOn { get; set; }

            public string EmpNameFirst { get; set; }

            public string EmpNameLast { get; set; }

            public int SiteIdPhy { get; set; }

            public string SiteName { get; set; }

            public string PayType { get; set; }

            public string ReportToEmpName { get; set; }

            public string IsActive { get; set; }

            public string WinLoginName { get; set; }

        }

        #region Data Fields
        public string actionInfo { get; set; }

        [Display(Name = "Physical")]
        [Required(ErrorMessage = "Site Phy")]
        public int SiteIdPhy { get; set; }

        public IList<SelectListItem> lstSitePhy { get; set; }

        [Display(Name = "Allocated")]
        [Required(ErrorMessage = "Allocated site is required")]
        public int SiteIdAlloc { get; set; }

        public IList<SelectListItem> lstSiteAlloc { get; set; }

        public string EmpId1 { get; set; }

        public bool AdAccount { get; set; }

        public bool IsActive { get; set; }

        [Display(Name = "Is Itar?")]
        public bool IsItar { get; set; }

        [Display(Name = "Payroll#")]
        [StringLength(50)]
        public string EmpNmbr { get; set; }

        [Display(Name = "First Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "First Name")]
        public string EmpNameFirst { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(50)]
        public string EmpNameMiddle { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Last Name")]
        public string EmpNameLast { get; set; }


        public string EmpNameFull { get; set; }

        [StringLength(101)]
        public string ERPUserName { get; set; }

        [StringLength(50)]
        public string ERPUserID { get; set; }

        [StringLength(50)]
        public string EmpPic { get; set; }
        public HttpPostedFileBase EmpPicFile { get; set; }
        public char EmpLoginType { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title")]
        public int TitleID { get; set; }

        public IList<SelectListItem> lstTitles { get; set; }

        public short TRMPlanID { get; set; }

        [Display(Name = "Train. Plan")]
        public string TRMPlanDesc { get; set; }

        public int SideIDIP { get; set; }

        public int SideIDApp { get; set; }


        [Display(Name = "Leader")]
        [Required(ErrorMessage = "Leader")]
        public int ReportToEmpID { get; set; }

        public IList<SelectListItem> LstRptToEmp { get; set; }

        [Display(Name = "Shift")]
        [Required(ErrorMessage = "Shift")]
        public short Shift { get; set; }

        [Display(Name = "Direct")]
        [StringLength(50)]
        public string PhoneWork { get; set; }
        [RegularExpression(@"^\d*\s\(\d{2,3}\)\s\d{3}[-|\d{1}]\d{4}$", ErrorMessage = "Phone Work Match")]


        [Display(Name = "Cell")]
        [StringLength(50)]
        public string PhoneCell { get; set; }
        [RegularExpression(@"^\d*\s\(\d{2,3}\)\s\d{3}[-|\d{1}]\d{4}$", ErrorMessage = "Phone Cell Match")]



        [Display(Name = "Email")]
        [StringLength(500)]
        public string EmailAddress { get; set; }

        [Display(Name = "@")]
        public string EmailDomain { get; set; }

        public IList<SelectListItem> lstEmailDomain { get; set; }


        [Display(Name = "Account")]
        [StringLength(50)]
        public string WinLoginName { get; set; }

        [Display(Name = "Cont. On")]
        public DateTime? ContractOn { get; set; }

        [Display(Name = "Hire On")]
        public DateTime? HireOn { get; set; }

        public DateTime TermOn { get; set; }

        [Display(Name = "Language")]
        [StringLength(50)]
        public string Lingo { get; set; }

        [Display(Name = "Type")]
        [StringLength(10)]
        [Required(ErrorMessage = "Pay Type")]
        public string PayType { get; set; }


        [Display(Name = "Work As")]
        [StringLength(20)]
        public string WorkAs { get; set; }

        public int BadgeCount { get; set; }


        [StringLength(25)]
        public string BadgeCode { get; set; }

        [StringLength(200)]
        public string BadgePin { get; set; }

        public string TmpBadge { get; set; }

        public DateTime TmpBadgeExpOn { get; set; }

        public bool ChgPin { get; set; }

        public DateTime ChgPinLastOn { get; set; }

        public bool TmpPin { get; set; }

        public DateTime TmpPinValidOn { get; set; }


        [Display(Name = "Is Leader?")]
        public bool IsLeader { get; set; }

        public bool IsPerson { get; set; }


        [Display(Name = "In Guest Log?")]
        public bool InGuestLog { get; set; }


        [Display(Name = "In Phone Book?")]
        public bool InPhoneBook { get; set; }

        public DateTime LoginLastOn { get; set; }


        [StringLength(50)]
        public string LoginPCNameLast { get; set; }

        public DateTime LastSyncOn { get; set; }

        public DateTime LastESDOn { get; set; }

        public bool ESDRqd { get; set; }

        [Display(Name = "ESD")]
        [StringLength(25)]
        public string ESDType { get; set; }


        [StringLength(10)]
        public string DateFormat { get; set; }

        public bool IsDev { get; set; }

        public bool LingoSelect { get; set; }

        public bool IdDisabled { get; set; }

        public DateTime IdDisabledOn { get; set; }

        [StringLength(50)]
        public string IdDisabledReason { get; set; }

        public List<EmpAxsList> lstEmpAxs { get; set; }
        public List<EmpRoleList> lstEmpRole { get; set; }
        public List<EmpSiteList> lstEmpSite { get; set; }
        public List<EmployeeList> lstEmployee { get; set; }


        public int oldSiteIdPhy { get; set; }
        public int oldTitleID { get; set; }
        public int oldTRMPlanID { get; set; }
        public string authEmpSiteIds { get; set; }

        public Dictionary<string, string> SetThisProperties { get; set; }

        #endregion Data Fields


        #region MainFilter
        [Display(Name = "Site")]
        [Required(ErrorMessage = "Site Phy")]
        public string filterSiteID { get; set; }
        public IList<SelectListItem> lstFilterSite { get; set; }

        [Display(Name = "Status")]
        public string filterStatus { get; set; }
        #endregion

        #region METHODS
        public string LoadModelForCreate()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = string.Empty;
                int AuthEmpID = Convert.ToInt32(HttpContext.Current.Session["EmpID"]);
                DataTable dtTemp;

                #region "DropDown"
                //BINDING DROPDOWN LIST(S)
                //SITES
                //PHYSICAL SITE
                query = "SELECT * FROM oEmpSiteX X ";
                query += "INNER JOIN CoSiteLst S ON X.SiteId = S.SiteId ";
                query += "WHERE EmpId =  " + AuthEmpID + " ORDER BY S.SiteId ";
                lstSitePhy = cCommon.BindDropDownList(query, "SiteName", "SiteID");

                //ALLOCATED SITE
                query = "SELECT SiteId, SiteName FROM CoSiteLst WHERE IsActive = 1 ";
                lstSiteAlloc = cCommon.BindDropDownList(query, "SiteName", "SiteID");

                //TITLES
                query = "SELECT TitleId, TitleDesc FROM oEmpTitles ORDER BY TitleDesc ";
                lstTitles = cCommon.BindDropDownList(query, "TitleDesc", "TitleId");

                //LEADERS
                query = "SELECT EmpId, (EmpNameFirst + ' ' + EmpNameLast) AS EmpName ";
                query += "FROM oEmpMst ";
                query += "WHERE IsLeader = 1 AND IsActive = 1 ";
                query += "ORDER BY EmpNameFirst, EmpNameLast";
                LstRptToEmp = cCommon.BindDropDownList(query, "EmpName", "EmpId");

                //EMAIL DOMAINS
                query = "SELECT LkupId, LkupDesc FROM CoLkupLst WHERE LkupType = 'EMAIL_DOMAIN' ";
                lstEmailDomain = cCommon.BindDropDownList(query, "LkupDesc", "LkupId");
                #endregion

                //GET SITES
                query = "SELECT SiteId, SiteCode, SiteName FROM CoSiteLst WHERE IsActive = 1 ";
                query += "ORDER BY SiteName ";
                dtTemp = oDAL.GetRecord(query, false);
                lstEmpSite = dtTemp.AsEnumerable().Select(dr => new EmpSiteList
                {
                    SiteId = Convert.ToInt32(dr["SiteId"]),
                    SiteCode = dr["SiteCode"].ToString(),
                    SiteName = dr["SiteName"].ToString(),
                    IsChecked = false,
                    AuthEmpId = AuthEmpID,
                    DMLType = "N"
                }).ToList<EmpSiteList>();

                //GET AXS
                query = "SELECT AxsId, AxsCode, AxsNameFull FROM CoAxsLst WHERE IsActive = 1 ";
                query += "AND RoleCode IS NULL AND (GrpCode = 'REPORT' OR GrpCode = 'TASK') AND HasAuth = 1 ";
                dtTemp = oDAL.GetRecord(query, false);
                lstEmpAxs = dtTemp.AsEnumerable().Select(dr => new EmpAxsList
                {
                    AxsId = Convert.ToInt32(dr["AxsId"]),
                    AxsCode = dr["AxsCode"].ToString(),
                    AxsNameFull = dr["AxsNameFull"].ToString(),
                    IsChecked = false,
                    AuthEmpId = AuthEmpID,
                    DMLType = "N"
                }).ToList<EmpAxsList>();

                //GET ROLES
                query = "SELECT RoleId, RoleCode, RoleDesc FROM CoEmpRoles WHERE IsActive = 1 ";
                dtTemp = oDAL.GetRecord(query, false);
                lstEmpRole = dtTemp.AsEnumerable().Select(dr => new EmpRoleList
                {
                    RoleId = Convert.ToInt32(dr["RoleId"]),
                    RoleCode = dr["RoleCode"].ToString(),
                    RoleDesc = dr["RoleDesc"].ToString(),
                    IsChecked = false,
                    AuthEmpId = AuthEmpID,
                    DMLType = "N"
                }).ToList<EmpRoleList>();

            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        public string AddEmployeeinSystem()
        {
            cDAL oDAL = new cDAL(true);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                Dictionary<string, object> matrix = new Dictionary<string, object>();
                bool isAvailable = false;
                int employeeID = 0;
                int badgeID = 0;
                string badgeCode = string.Empty;
                DataTable dtTemp;
                string query = string.Empty;

                string AuthEmpName = HttpContext.Current.Session["EmpFullName"].ToString();
                int AuthEmpID = Convert.ToInt32(HttpContext.Current.Session["EmpID"]);
                int AuthEmpSiteID = Convert.ToInt32(HttpContext.Current.Session["EmpPhySiteID"]);

                while (isAvailable == false)
                {
                    dtTemp = oDAL.GetRecord("SELECT TOP 1 BadgeId, BadgeCode FROM oBadgeLst WHERE BadgeId > 999 AND Used = 0 ", true);
                    badgeID = Convert.ToInt32(dtTemp.Rows[0]["BadgeId"]);
                    badgeCode = dtTemp.Rows[0]["BadgeCode"].ToString();

                    //OCCUPYING oBadgeLst
                    matrix = new Dictionary<string, object>();
                    matrix["Used"] = true;
                    oDAL.ExecuteQuery(cDAL.QueryType.UPDATE, "oBadgeLst", matrix, "BadgeCode = '" + badgeCode + "'", true);

                    //CHECKING EMPLOYEE EXISTANCE
                    employeeID = Convert.ToInt32(oDAL.GetObject("SELECT COUNT(EmpId) FROM oEmpMst WHERE EmpId = " + badgeID + "", true));
                    if (employeeID == 0)
                        isAvailable = true;
                }
                EmpId1 = badgeID.ToString();
                BadgePin = cCommon.EncryptPin(EmpNameFirst + EmpId1);

                //INSERTING IN oEmpMst
                matrix = new Dictionary<string, object>();
                matrix["EmpId"] = EmpId1;
                matrix["BadgeCode"] = badgeCode;
                matrix["IsActive"] = true;
                matrix["EmpNmbr"] = EmpNmbr;
                matrix["EmpNameFirst"] = EmpNameFirst;
                matrix["EmpNameMiddle"] = EmpNameMiddle;
                matrix["EmpNameLast"] = EmpNameLast;
                matrix["PhoneWork"] = PhoneWork;
                matrix["PhoneCell"] = PhoneCell;
                matrix["EmailAddress"] = EmailAddress + "@" + EmailDomain;
                matrix["WinloginName"] = WinLoginName;
                matrix["IsLeader"] = IsLeader;
                matrix["BadgePin"] = BadgePin;
                matrix["ChgPinLastOn"] = DateTime.Now.AddHours(72).ToString();
                matrix["SiteIdPhy"] = SiteIdPhy;
                matrix["SiteIdAlloc"] = SiteIdAlloc;
                matrix["SiteIdApp"] = SiteIdAlloc;
                matrix["SiteIdIP"] = SiteIdAlloc;
                matrix["TitleId"] = TitleID;
                matrix["TrmPlanId"] = TRMPlanID;
                matrix["ReportToEmpId"] = ReportToEmpID;
                matrix["Lingo"] = Lingo;
                matrix["Shift"] = Shift;
                matrix["PayType"] = PayType;
                matrix["WorkAs"] = WorkAs;
                matrix["EsdType"] = ESDType;
                matrix["InGuestLog"] = InGuestLog;
                matrix["IsItar"] = IsItar;
                matrix["InPhoneBook"] = InPhoneBook;

                if (WorkAs == "Employee")
                {
                    matrix["HireOn"] = HireOn;
                    matrix["ContractOn"] = DBNull.Value;
                }
                else
                {
                    matrix["ContractOn"] = ContractOn;
                    matrix["HireOn"] = DBNull.Value;
                }
                matrix["EmpPic"] = EmpPic; //WORK FOR EMP
                oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oEmpMst", matrix, null, true);

                //AUDIT EFFECTS FOR oEmpMst
                query = "INSERT INTO OctaneAudit.DBO.oEmpMstAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'ADDED', * FROM oEmpMst WHERE EmpID = " + EmpId1 + " ";
                oDAL.ExecuteQuery(query, true);


                //TRM Reflections

                //1) ACCROSS COMPANY
                oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'Company'", true);
                query = "INSERT INTO oTrmEmpPlan ";
                query += "SELECT " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " , " + TRMPlanID + ", 'Across Company', '" + AuthEmpName + "', ";
                query += "GETDATE(), 'Company', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                query += "INNER JOIN oTrmCourseCompanyX X ON X.CourseCode = TC.CourseCode";
                oDAL.ExecuteQuery(query, true);

                //2) ACROSS SITE
                oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'Site'", true);
                query = "INSERT INTO oTrmEmpPlan ";
                query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Site', '" + AuthEmpName + "', ";
                query += "GETDATE(), 'Site', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                query += "INNER JOIN oTrmCourseSiteX X ON X.CourseCode = TC.CourseCode  ";
                query += "WHERE SiteId = " + SiteIdPhy + " ";
                oDAL.ExecuteQuery(query, true);

                //3) ACROSS COMPANY BY TITLE
                oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'CompanyTitle'", true);
                query = "INSERT INTO oTrmEmpPlan ";
                query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Company By Title', '" + AuthEmpName + "', ";
                query += "GETDATE(), 'CompanyTitle', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                query += "INNER JOIN oTrmCoursePlanAllX X ON X.CourseCode = TC.CourseCode AND TrmplanId = " + TRMPlanID + " ";
                oDAL.ExecuteQuery(query, true);

                //4) ACROSS SITE BY TITLE
                oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'SiteTitle'", true);
                query = "INSERT INTO oTrmEmpPlan ";
                query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Site By Title', '" + AuthEmpName + "', ";
                query += "GETDATE(), 'SiteTitle', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                query += "INNER JOIN oTrmCoursePlanX X ON X.CourseCode = TC.CourseCode  ";
                query += "WHERE SiteId = " + SiteIdPhy + " AND TrmplanId = " + TRMPlanID + " ";
                oDAL.ExecuteQuery(query, true);

                //SITE RIGHT(S)
                foreach (var row in lstEmpSite)
                {
                    if (row.IsChecked == false)
                        continue;
                    matrix = new Dictionary<string, object>();
                    matrix["EmpId"] = EmpId1;
                    matrix["SiteId"] = row.SiteId;
                    matrix["SiteCode"] = row.SiteCode;
                    matrix["InsertOn"] = DateTime.Now;
                    matrix["AuthEmpId"] = AuthEmpID;
                    oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oEmpSiteX", matrix, null, true);

                    query = "INSERT INTO OctaneAudit.DBO.oEmpSiteXAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'ADDED', * FROM oEmpSiteX WHERE EmpID = " + EmpId1 + " AND SiteID = " + row.SiteId + " ";
                    oDAL.ExecuteQuery(query, true);

                    //AUDIT EFFECTS
                }
                //ROLE RIGHT(S)
                foreach (var row in lstEmpRole)
                {
                    if (row.IsChecked == false)
                        continue;
                    matrix = new Dictionary<string, object>();
                    matrix["EmpId"] = EmpId1;
                    matrix["RoleId"] = row.RoleId;
                    matrix["RoleCode"] = row.RoleCode;
                    matrix["AuthOn"] = DateTime.Now;
                    matrix["AuthEmpId"] = AuthEmpID;
                    oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oEmpRoleX", matrix, null, true);
                    //AUDIT EFFECTS
                    query = "INSERT INTO OctaneAudit.DBO.oEmpRoleXAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'ADDED', * FROM oEmpRoleX WHERE EmpID = " + EmpId1 + " AND RoleID = " + row.RoleId + " ";
                    oDAL.ExecuteQuery(query, true);
                }
                //AXS RIGHT(S)
                foreach (var row in lstEmpAxs)
                {
                    if (row.IsChecked == false)
                        continue;
                    matrix = new Dictionary<string, object>();
                    matrix["EmpId"] = EmpId1;
                    matrix["AxsId"] = row.AxsId;
                    matrix["AxsCode"] = row.AxsCode;
                    matrix["AuthOn"] = DateTime.Now;
                    matrix["AuthEmpId"] = AuthEmpID;
                    oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oEmpAxsX", matrix, null, true);
                    //AUDIT EFFECTS
                    query = "INSERT INTO OctaneAudit.DBO.oEmpAxsXAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'ADDED', * FROM oEmpAxsX WHERE EmpID = " + EmpId1 + " AND AxsID = " + row.AxsId + " ";
                    oDAL.ExecuteQuery(query, true);
                }


                //MAINTAIN LOGS
                matrix = new Dictionary<string, object>();
                matrix["LogBeginOn"] = DateTime.Now;
                matrix["LogBeginEmpId"] = AuthEmpID;
                matrix["LogEndOn"] = DateTime.Now;
                matrix["LogEndEmpId"] = AuthEmpID;
                matrix["LogAxsCode"] = "EMP_ACCESS_UPDATE";
                matrix["LogAxsName"] = "People Update";
                matrix["LogAxsCodeDtl"] = "Employee Create";
                matrix["LogAxsNameDtl"] = "New Hire";
                matrix["LogDesc"] = "Employee ID: " + EmpId1;
                matrix["LogSiteId"] = AuthEmpSiteID;
                matrix["LogAffects"] = "People Update";
                oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oLogAll", matrix, null, true);


                oDAL.Commit();
            }
            catch (Exception ex)
            {
                //RECORD EXCEPTIONS HERE
                oDAL.DisposeTransaction();
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();

        }

        public string LoadModelForUpdate()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = string.Empty;
                int AuthEmpID = Convert.ToInt32(HttpContext.Current.Session["EmpID"]);
                DataTable dtTemp;

                #region "DropDown"
                //BINDING DROPDOWN LIST(S)
                //SITES
                //PHYSICAL SITE
                query = "SELECT * FROM oEmpSiteX X ";
                query += "INNER JOIN CoSiteLst S ON X.SiteId = S.SiteId ";
                query += "WHERE EmpId =  " + AuthEmpID + " ORDER BY S.SiteId ";
                lstSitePhy = cCommon.BindDropDownList(query, "SiteName", "SiteID");

                //ALLOCATED SITE
                query = "SELECT SiteId, SiteName FROM CoSiteLst WHERE IsActive = 1 ";
                lstSiteAlloc = cCommon.BindDropDownList(query, "SiteName", "SiteID");

                //TITLES
                query = "SELECT TitleId, TitleDesc FROM oEmpTitles ORDER BY TitleDesc ";
                lstTitles = cCommon.BindDropDownList(query, "TitleDesc", "TitleId");

                //LEADERS
                query = "SELECT EmpId, (EmpNameFirst + ' ' + EmpNameLast) AS EmpName ";
                query += "FROM oEmpMst ";
                query += "WHERE IsLeader = 1 AND IsActive = 1 ";
                query += "ORDER BY EmpNameFirst, EmpNameLast";
                LstRptToEmp = cCommon.BindDropDownList(query, "EmpName", "EmpId");

                //EMAIL DOMAINS
                query = "SELECT LkupId, LkupDesc FROM CoLkupLst WHERE LkupType = 'EMAIL_DOMAIN' ";
                lstEmailDomain = cCommon.BindDropDownList(query, "LkupDesc", "LkupId");
                #endregion

                //GET EMPLOYEE INFO
                query = "SELECT * FROM oEmpMst WHERE EmpId = " + EmpId1 + "";
                dtTemp = oDAL.GetRecord(query, false);
                EmpNameFirst = dtTemp.Rows[0]["EmpNameFirst"].ToString();
                EmpNameMiddle = dtTemp.Rows[0]["EmpNameMiddle"].ToString();
                EmpNameLast = dtTemp.Rows[0]["EmpNameLast"].ToString();
                if (dtTemp.Rows[0]["EmailAddress"].ToString() != null)
                {
                    EmailAddress = dtTemp.Rows[0]["EmailAddress"].ToString().Split('@').GetValue(0).ToString();
                    EmailDomain = dtTemp.Rows[0]["EmailAddress"].ToString().Split('@').GetValue(1).ToString();
                }

                Lingo = dtTemp.Rows[0]["Lingo"].ToString();
                WinLoginName = dtTemp.Rows[0]["WinLoginName"].ToString();
                SiteIdAlloc = Convert.ToInt32(dtTemp.Rows[0]["SiteIdAlloc"]);
                SiteIdPhy = Convert.ToInt32(dtTemp.Rows[0]["SiteIdPhy"]);
                PhoneWork = dtTemp.Rows[0]["PhoneWork"].ToString();
                PhoneCell = dtTemp.Rows[0]["PhoneCell"].ToString();
                EmpNmbr = dtTemp.Rows[0]["EmpNmbr"].ToString();
                Shift = Convert.ToInt16(dtTemp.Rows[0]["Shift"]);
                PayType = dtTemp.Rows[0]["PayType"].ToString();
                WorkAs = dtTemp.Rows[0]["WorkAs"].ToString();
                if (WorkAs == "Employee")
                {
                    HireOn = Convert.ToDateTime(dtTemp.Rows[0]["HireOn"]);
                    ContractOn = null;
                }
                else
                {
                    ContractOn = Convert.ToDateTime(dtTemp.Rows[0]["ContractOn"]);
                    HireOn = null;
                }

                ReportToEmpID = Convert.ToInt32(dtTemp.Rows[0]["ReportToEmpID"]);
                TitleID = Convert.ToInt32(dtTemp.Rows[0]["TitleID"]);
                TRMPlanID = Convert.ToInt16(dtTemp.Rows[0]["TRMPlanID"]);


                ESDType = dtTemp.Rows[0]["ESDType"].ToString();
                InPhoneBook = Convert.ToBoolean(dtTemp.Rows[0]["InPhoneBook"]);
                IsItar = Convert.ToBoolean(dtTemp.Rows[0]["IsItar"]);
                IsLeader = Convert.ToBoolean(dtTemp.Rows[0]["IsLeader"]);
                InGuestLog = Convert.ToBoolean(dtTemp.Rows[0]["InGuestLog"]);


                //RETAIN OLD VALUES
                oldTitleID = TitleID;
                oldTRMPlanID = TRMPlanID;
                oldSiteIdPhy = SiteIdPhy;

                //GET TITLE DESCRIPTION
                query = "SELECT P.TrmplanDesc FROM oTrmPlans P ";
                query += "INNER JOIN oTrmPlanTitleX T ON T.TrmplanId = P.TrmplanId ";
                query += "WHERE TitleId = " + TitleID + "";
                dtTemp = oDAL.GetRecord(query, false);
                TRMPlanDesc = dtTemp.Rows[0]["TrmPlanDesc"].ToString();

                EmpSiteList oEmpSiteList;
                EmpAxsList oEmpAxsList;
                EmpRoleList oEmpRoleList;
                //GET EMPLOYEE ASSOCIATED SITES
                query = "SELECT S.SiteId, S.SiteCode, SiteName, X.AuthEmpId FROM CoSiteLst S ";
                query += " LEFT OUTER JOIN oEmpSiteX  X ON X.SiteId = S.SiteId AND S.IsActive = 1 and EmpId = " + EmpId1 + " ";
                query += "ORDER BY SiteName ";
                dtTemp = oDAL.GetRecord(query, false);
                lstEmpSite = new List<EmpSiteList>();
                foreach (DataRow dr in dtTemp.Rows)
                {
                    oEmpSiteList = new EmpSiteList();

                    oEmpSiteList.SiteId = Convert.ToInt32(dr["SiteId"]);
                    oEmpSiteList.SiteCode = dr["SiteCode"].ToString();
                    oEmpSiteList.SiteName = dr["SiteName"].ToString();
                    if (dr["AuthEmpID"] == DBNull.Value)
                    {
                        oEmpSiteList.IsChecked = false;
                        oEmpSiteList.DMLType = "N";
                        oEmpSiteList.AuthEmpId = AuthEmpID;
                    }
                    else
                    {
                        oEmpSiteList.AuthEmpId = Convert.ToInt32(dr["AuthEmpID"].ToString());
                        oEmpSiteList.IsChecked = true;
                        oEmpSiteList.DMLType = "U";
                    }

                    lstEmpSite.Add(oEmpSiteList);
                }

                //GET EMPLOYEE AXS
                query = "SELECT A.AxsId, A.AxsCode, AxsNameFull, X.AuthEmpId FROM CoAxsLst A ";
                query += "LEFT OUTER JOIN oEmpAxsX X ON X.AxsId = A.AxsId AND EmpId = " + EmpId1 + " ";
                query += "WHERE A.IsActive = 1 AND A.RoleCode IS NULL AND (A.GrpCode = 'REPORT' OR A.GrpCode = 'TASK') AND A.HasAuth = 1 ";
                dtTemp = oDAL.GetRecord(query, false);

                lstEmpAxs = new List<EmpAxsList>();
                foreach (DataRow dr in dtTemp.Rows)
                {
                    oEmpAxsList = new EmpAxsList();

                    oEmpAxsList.AxsId = Convert.ToInt32(dr["AxsId"]);
                    oEmpAxsList.AxsCode = dr["AxsCode"].ToString();
                    oEmpAxsList.AxsNameFull = dr["AxsNameFull"].ToString();
                    if (dr["AuthEmpID"] == DBNull.Value)
                    {
                        oEmpAxsList.IsChecked = false;
                        oEmpAxsList.DMLType = "N";
                        oEmpAxsList.AuthEmpId = AuthEmpID;
                    }
                    else
                    {
                        oEmpAxsList.AuthEmpId = Convert.ToInt32(dr["AuthEmpID"].ToString());
                        oEmpAxsList.IsChecked = true;
                        oEmpAxsList.DMLType = "U";
                    }
                    lstEmpAxs.Add(oEmpAxsList);
                }


                //GET ROLES
                query = "SELECT R.RoleId, R.RoleCode, RoleDesc, X.AuthEmpId FROM CoEmpRoles R ";
                query += "LEFT OUTER JOIN oEmpRoleX  X ON X.RoleId = R.RoleId AND R.IsActive = 1 and EmpId = " + EmpId1 + " ";
                dtTemp = oDAL.GetRecord(query, false);
                lstEmpRole = new List<EmpRoleList>();
                foreach (DataRow dr in dtTemp.Rows)
                {
                    oEmpRoleList = new EmpRoleList();

                    oEmpRoleList.RoleId = Convert.ToInt32(dr["RoleId"]);
                    oEmpRoleList.RoleCode = dr["RoleCode"].ToString();
                    oEmpRoleList.RoleDesc = dr["RoleDesc"].ToString();

                    if (dr["AuthEmpID"] == DBNull.Value)
                    {
                        oEmpRoleList.IsChecked = false;
                        oEmpRoleList.DMLType = "N";
                        oEmpRoleList.AuthEmpId = AuthEmpID;
                    }
                    else
                    {
                        oEmpRoleList.AuthEmpId = Convert.ToInt32(dr["AuthEmpID"].ToString());
                        oEmpRoleList.IsChecked = true;
                        oEmpRoleList.DMLType = "U";
                    }

                    lstEmpRole.Add(oEmpRoleList);
                }

            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        public string EditEmployeeinSystem()
        {
            cDAL oDAL = new cDAL(true);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                Dictionary<string, object> matrix = new Dictionary<string, object>();
                DataTable dtTemp;
                string query = string.Empty;
                string whereClause = string.Empty;

                string AuthEmpName = HttpContext.Current.Session["EmpFullName"].ToString();
                int AuthEmpID = Convert.ToInt32(HttpContext.Current.Session["EmpID"]);
                int AuthEmpSiteID = Convert.ToInt32(HttpContext.Current.Session["EmpPhySiteID"]);
                //INSERTING IN oEmpMst
                matrix = new Dictionary<string, object>();
                matrix["EmpId"] = EmpId1;
                matrix["IsActive"] = true;
                matrix["EmpNmbr"] = EmpNmbr;
                matrix["EmpNameFirst"] = EmpNameFirst;
                matrix["EmpNameMiddle"] = EmpNameMiddle;
                matrix["EmpNameLast"] = EmpNameLast;
                matrix["PhoneWork"] = PhoneWork;
                matrix["PhoneCell"] = PhoneCell;
                matrix["EmailAddress"] = EmailAddress + "@" + EmailDomain;
                matrix["WinloginName"] = WinLoginName;
                matrix["IsLeader"] = IsLeader;
                matrix["BadgePin"] = BadgePin;
                matrix["ChgPinLastOn"] = DateTime.Now.AddHours(72).ToString();
                matrix["SiteIdPhy"] = SiteIdPhy;
                matrix["SiteIdAlloc"] = SiteIdAlloc;
                matrix["SiteIdApp"] = SiteIdAlloc;
                matrix["SiteIdIP"] = SiteIdAlloc;
                matrix["TitleId"] = TitleID;
                matrix["TrmPlanId"] = TRMPlanID;
                matrix["ReportToEmpId"] = ReportToEmpID;
                matrix["Lingo"] = Lingo;
                matrix["Shift"] = Shift;
                matrix["PayType"] = PayType;
                matrix["WorkAs"] = WorkAs;
                matrix["EsdType"] = ESDType;
                matrix["InGuestLog"] = InGuestLog;
                matrix["IsItar"] = IsItar;
                matrix["InPhoneBook"] = InPhoneBook;

                if (WorkAs == "Employee")
                {
                    matrix["HireOn"] = HireOn;
                    matrix["ContractOn"] = DBNull.Value;
                }
                else
                {
                    matrix["ContractOn"] = ContractOn;
                    matrix["HireOn"] = DBNull.Value;
                }
                matrix["EmpPic"] = EmpPic; //WORK FOR EMP
                whereClause = "EmpID = " + EmpId1 + "";
                oDAL.ExecuteQuery(cDAL.QueryType.UPDATE, "oEmpMst", matrix, whereClause, true);

                //AUDIT EFFECTS FOR oEmpMst
                query = "INSERT INTO OctaneAudit.DBO.oEmpMstAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'MODIFIED', * FROM oEmpMst WHERE EmpID = " + EmpId1 + " ";
                oDAL.ExecuteQuery(query, true);




                //TRM Reflections

                if ((SiteIdPhy != oldSiteIdPhy) && (TRMPlanID != oldTRMPlanID))
                {
                    //1) ACROSS COMPANY BY TITLE
                    oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'CompanyTitle'", true);
                    query = "INSERT INTO oTrmEmpPlan ";
                    query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Company By Title', '" + AuthEmpName + "', ";
                    query += "GETDATE(), 'CompanyTitle', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                    query += "INNER JOIN oTrmCoursePlanAllX X ON X.CourseCode = TC.CourseCode AND TrmplanId = " + TRMPlanID + " ";
                    oDAL.ExecuteQuery(query, true);

                    //2) ACROSS SITE
                    oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'Site'", true);
                    query = "INSERT INTO oTrmEmpPlan ";
                    query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Site', '" + AuthEmpName + "', ";
                    query += "GETDATE(), 'Site', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                    query += "INNER JOIN oTrmCourseSiteX X ON X.CourseCode = TC.CourseCode  ";
                    query += "WHERE SiteId = " + SiteIdPhy + " ";
                    oDAL.ExecuteQuery(query, true);

                    //3) ACROSS SITE BY TITLE
                    oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'SiteTitle'", true);
                    query = "INSERT INTO oTrmEmpPlan ";
                    query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Site By Title', '" + AuthEmpName + "', ";
                    query += "GETDATE(), 'SiteTitle', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                    query += "INNER JOIN oTrmCoursePlanX X ON X.CourseCode = TC.CourseCode  ";
                    query += "WHERE SiteId = " + SiteIdPhy + " AND TrmplanId = " + TRMPlanID + " ";
                    oDAL.ExecuteQuery(query, true);


                }
                else if ((SiteIdPhy != oldSiteIdPhy))
                {
                    //1) ACROSS SITE
                    oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'Site'", true);
                    query = "INSERT INTO oTrmEmpPlan ";
                    query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Site', '" + AuthEmpName + "', ";
                    query += "GETDATE(), 'Site', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                    query += "INNER JOIN oTrmCourseSiteX X ON X.CourseCode = TC.CourseCode  ";
                    query += "WHERE SiteId = " + SiteIdPhy + " ";
                    oDAL.ExecuteQuery(query, true);

                    //2) ACROSS SITE BY TITLE
                    oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'SiteTitle'", true);
                    query = "INSERT INTO oTrmEmpPlan ";
                    query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Site By Title', '" + AuthEmpName + "', ";
                    query += "GETDATE(), 'SiteTitle', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                    query += "INNER JOIN oTrmCoursePlanX X ON X.CourseCode = TC.CourseCode  ";
                    query += "WHERE SiteId = " + SiteIdPhy + " AND TrmplanId = " + TRMPlanID + " ";
                    oDAL.ExecuteQuery(query, true);
                }
                else if ((TRMPlanID != oldTRMPlanID))
                {
                    //1) ACROSS COMPANY BY TITLE
                    oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'CompanyTitle'", true);
                    query = "INSERT INTO oTrmEmpPlan ";
                    query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Company By Title', '" + AuthEmpName + "', ";
                    query += "GETDATE(), 'CompanyTitle', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                    query += "INNER JOIN oTrmCoursePlanAllX X ON X.CourseCode = TC.CourseCode AND TrmplanId = " + TRMPlanID + " ";
                    oDAL.ExecuteQuery(query, true);

                    //2) ACROSS SITE BY TITLE
                    oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oTrmEmpPlan", null, "EmpId = " + EmpId1 + " AND CourseOriginCode = 'SiteTitle'", true);
                    query = "INSERT INTO oTrmEmpPlan ";
                    query += "SELECT  " + SiteIdPhy + ", TC.CourseCode, TC.CourseType, " + EmpId1 + " ," + TRMPlanID + ", 'Across Site By Title', '" + AuthEmpName + "', ";
                    query += "GETDATE(), 'SiteTitle', TC.ExpiresAfter, NULL,  NULL, NULL,1,0 FROM oTrmCourses  TC ";
                    query += "INNER JOIN oTrmCoursePlanX X ON X.CourseCode = TC.CourseCode  ";
                    query += "WHERE SiteId = " + SiteIdPhy + " AND TrmplanId = " + TRMPlanID + " ";
                    oDAL.ExecuteQuery(query, true);
                }


                //SITE RIGHT(S)
                foreach (var row in lstEmpSite)
                {
                    if (row.DMLType == "U" && row.IsChecked == true) //IF OLD RECORD IS ALREADY CHECKED
                        continue;
                    if (row.DMLType == "U" && row.IsChecked == false) //IF OLD RECORD and Unchecked by user
                    {
                        oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oEmpSiteX", null, "EmpID = " + EmpId1 + " AND SiteID = " + row.SiteId + "", true);
                        //AUDIT 
                        query = "INSERT INTO OctaneAudit.DBO.oEmpSiteXAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'REMOVED', * FROM oEmpSiteX WHERE EmpID = " + EmpId1 + " AND SiteID = " + row.SiteId + " ";
                        oDAL.ExecuteQuery(query, true);
                    }
                    if (row.DMLType == "N" && row.IsChecked == false) //DO NOTHING
                        continue;
                    if (row.DMLType == "N" && row.IsChecked == true) //INSERT NEW RECORD
                    {
                        matrix = new Dictionary<string, object>();
                        matrix["EmpId"] = EmpId1;
                        matrix["SiteId"] = row.SiteId;
                        matrix["SiteCode"] = row.SiteCode;
                        matrix["InsertOn"] = DateTime.Now;
                        matrix["AuthEmpId"] = AuthEmpID;
                        oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oEmpSiteX", matrix, null, true);
                        //AUDIT 
                        query = "INSERT INTO OctaneAudit.DBO.oEmpSiteXAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'ADDED', * FROM oEmpSiteX WHERE EmpID = " + EmpId1 + " AND SiteID = " + row.SiteId + " ";
                        oDAL.ExecuteQuery(query, true);
                    }

                    //AUDIT EFFECTS
                }
                //ROLE RIGHT(S)
                foreach (var row in lstEmpRole)
                {
                    if (row.DMLType == "U" && row.IsChecked == true) //IF OLD RECORD IS ALREADY CHECKED
                        continue;
                    if (row.DMLType == "U" && row.IsChecked == false) //IF OLD RECORD and Unchecked by user
                    {
                        oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oEmpRoleX", null, "EmpID = " + EmpId1 + " AND RoleID = " + row.RoleId + "", true);
                        //AUDIT 
                        query = "INSERT INTO OctaneAudit.DBO.oEmpRoleXAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'REMOVED', * FROM oEmpRoleX WHERE EmpID = " + EmpId1 + " AND RoleID = " + row.RoleId + " ";
                        oDAL.ExecuteQuery(query, true);
                    }

                    if (row.DMLType == "N" && row.IsChecked == false) //DO NOTHING
                        continue;
                    if (row.DMLType == "N" && row.IsChecked == true) //INSERT NEW RECORD
                    {
                        matrix = new Dictionary<string, object>();
                        matrix["EmpId"] = EmpId1;
                        matrix["RoleId"] = row.RoleId;
                        matrix["RoleCode"] = row.RoleCode;
                        matrix["AuthOn"] = DateTime.Now;
                        matrix["AuthEmpId"] = AuthEmpID;
                        oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oEmpRoleX", matrix, null, true);
                        //AUDIT 
                        query = "INSERT INTO OctaneAudit.DBO.oEmpRoleXAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'ADDED', * FROM oEmpRoleX WHERE EmpID = " + EmpId1 + " AND RoleID = " + row.RoleId + " ";
                        oDAL.ExecuteQuery(query, true);
                    }
                    //AUDIT EFFECTS
                }
                //AXS RIGHT(S)
                foreach (var row in lstEmpAxs)
                {
                    if (row.DMLType == "U" && row.IsChecked == true) //IF OLD RECORD IS ALREADY CHECKED
                        continue;
                    if (row.DMLType == "U" && row.IsChecked == false) //IF OLD RECORD and Unchecked by user
                    {
                        oDAL.ExecuteQuery(cDAL.QueryType.DELETE, "oEmpAxsX", null, "EmpID = " + EmpId1 + " AND AxsID = " + row.AxsId + "", true);
                        //AUDIT 
                        query = "INSERT INTO OctaneAudit.DBO.oEmpAxsXAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'REMOVED', * FROM oEmpAxsX WHERE EmpID = " + EmpId1 + " AND AxsID = " + row.AxsId + " ";
                        oDAL.ExecuteQuery(query, true);
                    }

                    if (row.DMLType == "N" && row.IsChecked == false) //DO NOTHING
                        continue;
                    if (row.DMLType == "N" && row.IsChecked == true) //INSERT NEW RECORD
                    {
                        matrix = new Dictionary<string, object>();
                        matrix["EmpId"] = EmpId1;
                        matrix["AxsId"] = row.AxsId;
                        matrix["AxsCode"] = row.AxsCode;
                        matrix["AuthOn"] = DateTime.Now;
                        matrix["AuthEmpId"] = AuthEmpID;
                        oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oEmpAxsX", matrix, null, true);
                        //AUDIT 
                        query = "INSERT INTO OctaneAudit.DBO.oEmpAxsXAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'ADDED', * FROM oEmpAxsX WHERE EmpID = " + EmpId1 + " AND AxsID = " + row.AxsId + " ";
                        oDAL.ExecuteQuery(query, true);
                    }
                    //AUDIT EFFECTS
                }


                //MAINTAIN LOGS
                matrix = new Dictionary<string, object>();
                matrix["LogBeginOn"] = DateTime.Now;
                matrix["LogBeginEmpId"] = AuthEmpID;
                matrix["LogEndOn"] = DateTime.Now;
                matrix["LogEndEmpId"] = AuthEmpID;
                matrix["LogAxsCode"] = "EMP_ACCESS_UPDATE";
                matrix["LogAxsName"] = "People Update";
                matrix["LogAxsCodeDtl"] = "Employee Create";
                matrix["LogAxsNameDtl"] = "New Hire";
                matrix["LogDesc"] = "Employee ID: " + EmpId1;
                matrix["LogSiteId"] = AuthEmpSiteID;
                matrix["LogAffects"] = "People Update";
                oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oLogAll", matrix, null, true);

                oDAL.Commit();
            }
            catch (Exception ex)
            {
                oDAL.DisposeTransaction();
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();

        }

        public string LoadModelForList()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = string.Empty;
                DataTable dtTemp;
                int AuthEmpID = Convert.ToInt32(HttpContext.Current.Session["EmpID"]);
                int AuthEmpSiteID = Convert.ToInt32(HttpContext.Current.Session["EmpPhySiteID"]);

                #region "DropDown"
                //BINDING DROPDOWN LIST(S)
                //SITE FOR FILTER
                query = "SELECT * FROM oEmpSiteX X ";
                query += "INNER JOIN CoSiteLst S ON X.SiteId = S.SiteId ";
                query += "WHERE EmpId =  " + AuthEmpID + " ORDER BY S.SiteId ";
                lstFilterSite = cCommon.BindDropDownList(query, "SiteName", "SiteID");

                bool firstSite = true;
                foreach (SelectListItem site in lstFilterSite)
                {
                    if (firstSite)
                    {
                        authEmpSiteIds += site.Value;
                        firstSite = false;
                    }
                    else authEmpSiteIds += "," + site.Value;
                }

                #endregion

                filterSiteID = AuthEmpSiteID.ToString();
                filterStatus = "Active";
                //GET EMPLOYEE ASSOCIATED SITES

                query = "SELECT EMP1.EmpId, EMP1.TermOn, EMP1.EmpNameFirst, EMP1.EmpNameLast, EMP1.SiteIdPhy, SiteName, EMP1.PayType,";
                query += "EMP2.EmpNameFull AS ReportToEmpName, EMP1.IsActive  ";
                query += "FROM oEmpMst EMP1 ";
                query += "INNER JOIN CoSiteLst S ON S.SiteId = EMP1.SiteIdPhy   ";
                query += "LEFT OUTER JOIN oEmpMst EMP2 ON EMP1.ReportToEmpId = EMP2.EmpId  ";
                query += "WHERE EMP1.SiteIdPhy = " + filterSiteID + " AND EMP1.IsActive = 1 ";
                query += "ORDER BY Emp1.EmpNameFull ";
                dtTemp = oDAL.GetRecord(query, false);
                PopulateEmployeeList(dtTemp);


            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        public string GetTitleDetail()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = "SELECT P.TrmplanId, P.TrmplanDesc FROM oTrmPlans P ";
                query += "INNER JOIN oTrmPlanTitleX T ON T.TrmplanId = P.TrmplanId ";
                query += "WHERE TitleId = " + TitleID + " AND IsActive = 1 ";
                DataTable dt = oDAL.GetRecord(query, false);

                if (dt.Rows.Count == 0)
                {
                    validationSummary.Append("No Record(s) Found");
                }

                if (dt.Rows.Count > 0)
                {
                    TRMPlanID = Convert.ToInt16(dt.Rows[0]["TRMPlanID"]);
                    TRMPlanDesc = dt.Rows[0]["TRMPlanDesc"].ToString();
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

        public string GetEmployees()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = "SELECT EMP1.EmpId, EMP1.TermOn, EMP1.EmpNameFirst, EMP1.EmpNameLast, EMP1.SiteIdPhy, SiteName, EMP1.PayType,";
                query += "EMP2.EmpNameFull AS ReportToEmpName, EMP1.IsActive  ";
                query += "FROM oEmpMst EMP1 ";
                query += "INNER JOIN CoSiteLst S ON S.SiteId = EMP1.SiteIdPhy   ";
                query += "LEFT OUTER JOIN oEmpMst EMP2 ON EMP1.ReportToEmpId = EMP2.EmpId  ";
                if (filterSiteID == "")
                    query += "WHERE EMP1.SiteIdPhy IN (" + authEmpSiteIds + ") ";
                else
                    query += "WHERE EMP1.SiteIdPhy IN (" + filterSiteID + ") ";
                if (filterStatus == "Active")
                    query += "AND EMP1.IsActive = 1 ";
                else if (filterStatus == "Inactive")
                    query += "AND EMP1.IsActive = 0 ";
                query += "ORDER BY Emp1.EmpNameFull ";
                DataTable dt = oDAL.GetRecord(query, false);

                if (dt.Rows.Count == 0)
                    validationSummary.Append("No Record(s) Found");

                PopulateEmployeeList(dt);
            }
            catch (Exception ex)
            {
                //RECORD EXCEPTIONS HERE
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();


        }

        public string GetEmployeeSummaryById()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = string.Empty;
                DataTable dtTemp;

                //GET EMPLOYEE INFO
                query = "SELECT EmpNameFirst, EmpNameMiddle, EmpNameLast, EmailAddress, PhoneWork, ";
                query +="PhoneCell, EmpNmbr, Shift, PayType, WorkAs, HireOn, ContractOn FROM oEmpMst WHERE EmpId = " + EmpId1 + "";
                dtTemp = oDAL.GetRecord(query, false);
                EmpNameFirst = dtTemp.Rows[0]["EmpNameFirst"].ToString();
                EmpNameMiddle = dtTemp.Rows[0]["EmpNameMiddle"].ToString();
                EmpNameLast = dtTemp.Rows[0]["EmpNameLast"].ToString();
                if (dtTemp.Rows[0]["EmailAddress"].ToString() != null)
                    EmailAddress = dtTemp.Rows[0]["EmailAddress"].ToString();
                
                PhoneWork = dtTemp.Rows[0]["PhoneWork"].ToString();
                PhoneCell = dtTemp.Rows[0]["PhoneCell"].ToString();
                EmpNmbr = dtTemp.Rows[0]["EmpNmbr"].ToString();
                Shift = Convert.ToInt16(dtTemp.Rows[0]["Shift"]);
                PayType = dtTemp.Rows[0]["PayType"].ToString();
                WorkAs = dtTemp.Rows[0]["WorkAs"].ToString();
                if (WorkAs == "Employee")
                {
                    HireOn = Convert.ToDateTime(dtTemp.Rows[0]["HireOn"]);
                    ContractOn = null;
                }
                else
                {
                    ContractOn = Convert.ToDateTime(dtTemp.Rows[0]["ContractOn"]);
                    HireOn = null;
                }

                
                var a = typeof(AdmPplUpdModel);

                Dictionary<string, string> values = new Dictionary<string, string>();
                foreach (string colName in SetThisProperties.Keys)
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
                SetThisProperties = values;

                
            }
            catch (Exception ex)
            {
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();
        }

        private void PopulateEmployeeList(DataTable dt)
        {
            lstEmployee = new List<EmployeeList>();
            AdmPplUpdModel.EmployeeList oEmployeeList;
            foreach (DataRow dr in dt.Rows)
            {
                oEmployeeList = new EmployeeList();

                oEmployeeList.EmpId = Convert.ToInt32(dr["EmpId"]);
                oEmployeeList.EmpNameFirst = dr["EmpNameFirst"].ToString();
                oEmployeeList.EmpNameLast = dr["EmpNameLast"].ToString();
                oEmployeeList.SiteIdPhy = Convert.ToInt32(dr["SiteIdPhy"].ToString());
                oEmployeeList.SiteName = dr["SiteName"].ToString();
                oEmployeeList.PayType = dr["PayType"].ToString();
                oEmployeeList.ReportToEmpName = dr["ReportToEmpName"].ToString();
                if (Convert.ToBoolean(dr["IsActive"]) == true)
                    oEmployeeList.IsActive = "Yes";
                else
                    oEmployeeList.IsActive = "No";
                if (dr["TermOn"] != DBNull.Value)
                    oEmployeeList.TermOn = dr["TermOn"].ToString();


                lstEmployee.Add(oEmployeeList);
            }
            
        }

        public string TerminateEmployee()
        {
            cDAL oDAL = new cDAL(true);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                Dictionary<string, object> matrix = new Dictionary<string, object>();
                DataTable dtTemp;
                string query = string.Empty;
                string whereClause = string.Empty;

                string AuthEmpName = HttpContext.Current.Session["EmpFullName"].ToString();
                int AuthEmpID = Convert.ToInt32(HttpContext.Current.Session["EmpID"]);
                int AuthEmpSiteID = Convert.ToInt32(HttpContext.Current.Session["EmpPhySiteID"]);
                //UPDATING oEmpMst
                matrix = new Dictionary<string, object>();
                matrix["TermOn"] = DateTime.Now;
                matrix["IsActive"] = false;
                whereClause = "EmpID = " + EmpId1 + "";
                oDAL.ExecuteQuery(cDAL.QueryType.UPDATE, "oEmpMst", matrix, whereClause, true);

                //AUDIT EFFECTS FOR oEmpMst
                query = "INSERT INTO OctaneAudit.DBO.oEmpMstAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'TERMINATED', * FROM oEmpMst WHERE EmpID = " + EmpId1 + " ";
                oDAL.ExecuteQuery(query, true);
                  //RESET ALL EMPLOYEES REPORTIN TO THIS PERSON
                matrix = new Dictionary<string, object>();
                matrix["ReportToEmpId"] =0;
                whereClause = "ReportToEmpId = " + EmpId1 + "";
                oDAL.ExecuteQuery(cDAL.QueryType.UPDATE, "oEmpMst", matrix, whereClause, true);

                //MAINTAIN LOGS
                matrix = new Dictionary<string, object>();
                matrix["LogBeginOn"] = DateTime.Now;
                matrix["LogBeginEmpId"] = AuthEmpID;
                matrix["LogEndOn"] = DateTime.Now;
                matrix["LogEndEmpId"] = AuthEmpID;
                matrix["LogAxsCode"] = "EMP_ACCESS_UPDATE";
                matrix["LogAxsName"] = "People Update";
                matrix["LogAxsCodeDtl"] = "TERMINATE";
                matrix["LogAxsNameDtl"] = "TERMINATE";
                matrix["LogDesc"] = "Employee ID: " + EmpId1;
                matrix["LogSiteId"] = AuthEmpSiteID;
                matrix["LogAffects"] = "People Update";
                oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oLogAll", matrix, null, true);

                oDAL.Commit();
            }
            catch (Exception ex)
            {
                oDAL.DisposeTransaction();
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();

        }

        public string ReactivateEmployee()
        {
            cDAL oDAL = new cDAL(true);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                Dictionary<string, object> matrix = new Dictionary<string, object>();
                DataTable dtTemp;
                string query = string.Empty;
                string whereClause = string.Empty;

                string AuthEmpName = HttpContext.Current.Session["EmpFullName"].ToString();
                int AuthEmpID = Convert.ToInt32(HttpContext.Current.Session["EmpID"]);
                int AuthEmpSiteID = Convert.ToInt32(HttpContext.Current.Session["EmpPhySiteID"]);
                //UPDATING oEmpMst
                matrix = new Dictionary<string, object>();
                matrix["TermOn"] = null;
                matrix["IsActive"] = true;
                whereClause = "EmpID = " + EmpId1 + "";
                oDAL.ExecuteQuery(cDAL.QueryType.UPDATE, "oEmpMst", matrix, whereClause, true);

                //AUDIT EFFECTS FOR oEmpMst
                query = "INSERT INTO OctaneAudit.DBO.oEmpMstAdt SELECT GETDATE(), " + AuthEmpID + ", '" + AuthEmpName + "', 'REACTIVATED', * FROM oEmpMst WHERE EmpID = " + EmpId1 + " ";
                oDAL.ExecuteQuery(query, true);

                //MAINTAIN LOGS
                matrix = new Dictionary<string, object>();
                matrix["LogBeginOn"] = DateTime.Now;
                matrix["LogBeginEmpId"] = AuthEmpID;
                matrix["LogEndOn"] = DateTime.Now;
                matrix["LogEndEmpId"] = AuthEmpID;
                matrix["LogAxsCode"] = "EMP_ACCESS_UPDATE";
                matrix["LogAxsName"] = "People Update";
                matrix["LogAxsCodeDtl"] = "REACTIVATE";
                matrix["LogAxsNameDtl"] = "REACTIVATE";
                matrix["LogDesc"] = "Employee ID: " + EmpId1;
                matrix["LogSiteId"] = AuthEmpSiteID;
                matrix["LogAffects"] = "People Update";
                oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oLogAll", matrix, null, true);

                oDAL.Commit();
            }
            catch (Exception ex)
            {
                oDAL.DisposeTransaction();
                cCommon.RecordError(ex, actionInfo, oDAL.ErrorQuery);
                validationSummary.AppendLine(ex.Message);
            }
            return validationSummary.ToString();

        }

        #endregion METHODS
    }
    //EMPLOYEE ACCESS(S)
    public class EmpAxsList
    {
        public int AxsId { get; set; }

        public string AxsCode { get; set; }

        public string AxsNameFull { get; set; }

        public int AuthEmpId { get; set; }

        public bool IsChecked { get; set; }

        public string DMLType { get; set; }
    }

    //EMPLOYEE ROLE(S)
    public class EmpRoleList
    {
        public int RoleId { get; set; }

        public string RoleCode { get; set; }

        public string RoleDesc { get; set; }

        public int AuthEmpId { get; set; }

        public bool IsChecked { get; set; }

        public string DMLType { get; set; }
    }

    //EMPLOYEE SITE(S)
    public class EmpSiteList
    {
        public int SiteId { get; set; }

        public string SiteCode { get; set; }

        public string SiteName { get; set; }

        public int AuthEmpId { get; set; }

        public bool IsChecked { get; set; }

        public string DMLType { get; set; }
    }
}