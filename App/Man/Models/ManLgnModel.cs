using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;


namespace OctaneApp.App.Man.Models
{
    public class ManLgnModel
    {
        [Display(Name = "Enter User ID")]
        [Required(ErrorMessage = "Employee ID is required")]
        [StringLength(10, MinimumLength = 1)]
        public string EmpID { get; set; }

        [Display(Name = "Enter User Password")]
        [StringLength(10, MinimumLength = 5)]
        public string BadgePin { get; set; }

        public string CSType { get; set; }


        //FOR MAINTAINING LOGS
        public string actionInfo { get; set; }

        public string AuthenticateUser()
        {
            cDAL oDAL = new cDAL(false);
            StringBuilder validationSummary = new StringBuilder();
            try
            {
                string query = "SELECT * FROM oEmpMst WHERE EmpID = " + EmpID + "  ";
                DataTable dt = oDAL.GetRecord(query, false);

                if (dt.Rows.Count == 0)
                {
                    validationSummary.Append("Invalid Employee ID");
                }

                if (dt.Rows.Count > 0)
                {
                    HttpContext.Current.Session["EmpID"] = dt.Rows[0]["EmpId"];
                    HttpContext.Current.Session["EmpPhySiteID"] = dt.Rows[0]["SiteIdPhy"];
                    HttpContext.Current.Session["EmpFullName"] = dt.Rows[0]["EmpNameFull"];
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

    }
}