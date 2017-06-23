using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _105_Final.Areas.Customer.Models
{
    public class Customer
    {
        /// <summary>
        ///顧客編號 
        /// </summary>
        public string CustomerID { get; set; }
        /// <summary>
        /// 顧客名稱
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 聯絡人姓名
        /// </summary>
        public string ContactName { get; set; }
        /// <summary>
        /// 聯絡人職稱
        /// </summary>
        public string ContactTitle { get; set; }
        /// <summary>
        /// 建立日期
        /// </summary>
        public string CreationDate { get; set; }
        /// <summary>
        /// 國家
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 區域
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 郵遞區號
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 電話
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 傳真
        /// </summary>
        public string Fax { get; set; }

        ///<summary>
        ///聯絡人職位
        /// </summary>
        public string CodeVal { get; set; }
    }
}