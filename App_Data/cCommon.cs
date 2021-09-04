using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Configuration;
using System.Security.Cryptography;
namespace OctaneApp
{
    public class cCommon
    {
        #region "LOG ERRORS"
        public static void RecordError(Exception e, string action_info, string error_Query)
        {
            Dictionary<string, object> columns = new Dictionary<string, object>();
            try
            {
                cDAL oDAL = new cDAL(false);

                //columns["ErrMsg"] = e.Message;
                columns["ErrMsg"] = e.Message;
                columns["ErrStack"] = e.StackTrace;
                columns["ErrOn"] = DateTime.Now;
                columns["ErrFrom"] = "APP";
                string tst = HttpContext.Current.Session["EmpID"].ToString();
                string userInfo = "ID: " + HttpContext.Current.Session["EmpID"].ToString() + ", ";
                userInfo += "Name: " + HttpContext.Current.Session["EmpNameFull"].ToString() + ", ";
                userInfo += "Host: " + HttpContext.Current.Session["RemoteHost"].ToString() + ", ";
                userInfo += "Address: " + HttpContext.Current.Session["RemoteAddr"].ToString();
                columns["ErrBy"] = userInfo;

                string errQuery = "Info: " + action_info + ", ";
                errQuery += "Query: " + error_Query;
                columns["ErrQry"] = errQuery;

                oDAL.ExecuteQuery(cDAL.QueryType.INSERT, "oLogErrors", columns, null, false);

            }
            catch (Exception ex)
            {
                //RECORDING ERRORS IN A FILE
                if (System.IO.Directory.Exists(@"c:\Octane\ErrorLog") == false)
                    System.IO.Directory.CreateDirectory(@"c:\Octane\ErrorLog");


                StreamWriter sWriter = File.AppendText(@"c:\Octane\ErrorLog\App.txt");
                sWriter.WriteLine("{0,0}{1}", "Date     :", columns["ErrOn"]);
                sWriter.WriteLine("{0,0}{1}", "Error Message      :", columns["ErrMsg"]);
                sWriter.WriteLine("{0,0}{1}", "Error Stack      :", columns["ErrStack"]);
                sWriter.WriteLine("{0,0}{1}", "Error From      :", columns["ErrFrom"]);
                sWriter.WriteLine("{0,0}{1}", "Error By      :", columns["ErrBy"]);
                sWriter.WriteLine("{0,0}{1}", "Error Query      :", columns["ErrQry"]);

                sWriter.WriteLine(new String('*', 100));
                sWriter.Close();
            }

        }

        #endregion

        #region "Validation"
        public enum MessageType
        {
            Success,
            Warning,
            Error,
        }

        public static string MakeMessage(string message, MessageType messageType)
        {
            StringBuilder msg = new StringBuilder();
            if (messageType == MessageType.Success)
                msg.Append("<div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">");
            else if (messageType == MessageType.Warning)
                msg.Append("<div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">");
            else if (messageType == MessageType.Error)
                msg.Append("<div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">");
            msg.Append("<button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>");
            string[] arr = message.Split('\n');



            for (int i = 0; i < arr.Length; i++)
            {
                msg.Append(arr[i]);
                msg.Append("<br/>");
            }
            if (arr.Length > 0)
            {
                int l = msg.Length;
                msg.Remove(msg.Length - 5, 5);
            }
            msg.Append("</div>");

            return msg.ToString();
        }


        public static string GetPopupError(string message)
        {
            StringBuilder msg = new StringBuilder();
            

            string[] arr = message.Split('\n');



            for (int i = 0; i < arr.Length; i++)
            {
                msg.Append(arr[i]);
                msg.Append("<br/>");
            }
            if (arr.Length > 0)
            {
                int l = msg.Length;
                msg.Remove(msg.Length - 5, 5);
            }

            return msg.ToString();

        }

        public static string ValidateModel(ModelStateDictionary msd)
        {
            //MODEL VALIDATION
            StringBuilder validationSummary = new StringBuilder();
            if (msd.IsValid == false)
            {
                foreach (ModelState ms in msd.Values)
                {
                    foreach (ModelError error in ms.Errors)
                    {
                        validationSummary.AppendLine(error.ErrorMessage);
                    }
                }
                return validationSummary.ToString();
            }
            return string.Empty;
        }

        #endregion

       


        #region Authorization

        #endregion


        #region General Methods
        public static List<Dictionary<string, object>> ConvertDtToList(DataTable dt)
        {
            List<Dictionary<string, object>>
            lstRows = new List<Dictionary<string, object>>();
            Dictionary<string, object> dictRow = null;

            foreach (DataRow dr in dt.Rows)
            {
                dictRow = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    dictRow.Add(col.ColumnName, dr[col]);
                }
                lstRows.Add(dictRow);
            }
            return lstRows;
        }

        public static IList<SelectListItem> BindDropDownList(string query, string text, string value)
        {
            cDAL oDAL = new cDAL(false);



            IList<SelectListItem> lst;



            DataTable dt = oDAL.GetRecord(query, false);

            lst = dt.AsEnumerable().Select(dataRow => new SelectListItem
            {
                Text = dataRow[text].ToString(),
                Value = dataRow[value].ToString(),
            }).ToList<SelectListItem>();

            return lst;


        }


        public static string EncryptPin(string input)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            Byte[] data = Encoding.ASCII.GetBytes(input);
            Byte[] enc = sha1.ComputeHash(data);
            input = Convert.ToBase64String(enc);
            return input;
        }


        //    Public Shared Function SaveFile(ByVal filePath As String, ByVal fileName As String, ByVal binaryData As Byte(), Optional ByRef path As String = Nothing) As Boolean
        //    If (fileName.Contains("\") Or fileName.Contains("%") Or fileName.Contains("&") Or fileName.Contains("?")) Then
        //        Return "Filename is not allowed."
        //    End If
        //    If path <> "N" Then
        //        Dim srvrDateTime As DateTime = DateTime.Now
        //        Dim ciCurr As CultureInfo = CultureInfo.CurrentCulture
        //        Dim weekNum As String = ciCurr.Calendar.GetWeekOfYear(srvrDateTime, ciCurr.DateTimeFormat.CalendarWeekRule, DayOfWeek.Sunday).ToString().PadLeft(2, "0"c)
        //        filePath = filePath & srvrDateTime.Year & "_" & weekNum & "\\"
        //    End If
        //    path = filePath
        //    Using New cImpersonate()
        //        If Not Directory.Exists(filePath) Then
        //            Directory.CreateDirectory(filePath)
        //        End If

        //        If File.Exists(filePath + fileName) Then
        //            File.Delete(filePath + fileName)
        //        End If
        //        File.WriteAllBytes(filePath + fileName, binaryData)
        //        Return True
        //    End Using

        //    Return False
        //End Function

        #endregion

    }
}