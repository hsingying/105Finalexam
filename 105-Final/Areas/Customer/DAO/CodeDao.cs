using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _105_Final.Areas.Customer.DAO
{
    public class CodeDAO

    {

        ///<summary>
        ///取得DB連線
        /// </summary>
        private string GetDBConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();
        }
        /// <summary>
        /// 取得職稱資料
        /// </summary>
        /// <returns></returns>
        public List<SelectListItem> GetVal()
        {
            DataTable dt = new DataTable();
            string sql = @"select CodeVal,CodeId  from dbo.CodeTable where CodeType='TITLE'";
            using (SqlConnection conn = new SqlConnection(this.GetDBConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.Fill(dt);
                conn.Close();
            }
            Service.CodeService codeservice = new Service.CodeService();
            return codeservice.MapCustomerData(dt);
        }
    }
}