using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _105_Final.Areas.Customer.Service
{
    public class CodeService
    {

      public List<SelectListItem> GetContactTitle()
        {
            DAO.CodeDAO dao = new DAO.CodeDAO();
            return dao.GetVal();
        }



        /// <summary>
        /// 整合聯絡人職稱
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
      public List<SelectListItem> MapCustomerData(DataTable code) {
            List<SelectListItem> result = new List<SelectListItem>();
            result.Add(new SelectListItem() {
                Text="",
                Value=""

            });
            foreach (DataRow row in code.Rows) {
                result.Add(new SelectListItem()
                {
                    Text = row["CodeVal"].ToString(),
                    Value = row["CodeId"].ToString()
                });

            }
            return result; 


        }
    }
}