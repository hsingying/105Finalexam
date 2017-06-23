using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _105_Final.Areas.Customer.Service
{
    public class CustomerService
    {
        /// <summary>
        /// 查詢 取得顧客資料
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public List<Models.Customer> GetCustomerData(Models.Customer customer)
        {
            DAO.CustomerDAO dao = new DAO.CustomerDAO();
            List<Models.Customer> result = dao.GetCustomerDataByCondition(customer);
            return result;
        }
        /// <summary>
        /// 整合顧客資料
        /// </summary>
        /// <param name="customerData"></param>
        /// <returns></returns>
        public List<Models.Customer> MapCustomerData(DataTable customerData)
        {
            List<Models.Customer> customer = new List<Models.Customer>();
            foreach (DataRow row in customerData.Rows) { 
                customer.Add(new Models.Customer() {
                    CustomerID = row["CustomerID"].ToString(),
                    CompanyName = row["CompanyName"].ToString(),
                    ContactName = row["ContactName"].ToString(),
                    ContactTitle = row["ContactTitle"].ToString(),
                    CreationDate = row["CreationDate"].ToString(),
                    Address = row["Address"].ToString(),
                    Country = row["Country"].ToString(),
                    City = row["City"].ToString(),
                    Region = row["Region"].ToString(),
                    PostalCode = row["PostalCode"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Fax = row["Fax"].ToString(),
            });
            }
            return customer;
        }
    }
}