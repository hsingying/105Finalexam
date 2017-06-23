using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _105_Final.Areas.Customer.DAO
{
    public class CustomerDAO
    {

        ///<summary>
        ///取得DB連線
        /// </summary>
        private string GetDBConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();
        }
        public List<Models.Customer> GetCustomerDataByCondition(Models.Customer customer)
        {
            DataTable dt = new DataTable();
            var sql = @"SELECT CustomerID,CompanyName,ContactName,CodeVal FROM Sales.Customers a join dbo.CodeTable b on a.ContactTitle = b.CodeId
                        WHERE CodeType = 'TITLE' and (CustomerID LIKE '%'+@CustomerID+'%' OR CustomerID = '')
                        AND (CompanyName LIKE '%'+@CompanyName+'%' OR CompanyName='') 
                        AND (ContactName LIKE '%'+@ContactName+'%' OR ContactName='')
                        AND (CodeVal LIKE '%' + @CodeVal+'%' OR CodeVal='')
                        AND ContactTitle = ''";
            using (SqlConnection conn = new SqlConnection(this.GetDBConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@CustomerID",customer.CustomerID == null ? string.Empty :customer.CustomerID ));
                cmd.Parameters.Add(new SqlParameter("@CompanyName", customer.CompanyName == null ? string.Empty : customer.CompanyName));
                cmd.Parameters.Add(new SqlParameter("@ContactName", customer.ContactName == null ? string.Empty : customer.ContactName));
                cmd.Parameters.Add(new SqlParameter("@CodeVal", customer.CodeVal == null ? string.Empty : customer.CodeVal));
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.Fill(dt);
                conn.Close();
            }
           Service.CustomerService cus = new Service.CustomerService();
           return cus.MapCustomerData(dt);
        }

       
    }
}