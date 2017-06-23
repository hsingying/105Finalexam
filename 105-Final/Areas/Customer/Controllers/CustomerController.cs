using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _105_Final.Areas.Customer.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/Customer
        public ActionResult Index()
        {
            return View();
        }
        //查詢
     
        public JsonResult getQueryData(Models.Customer customer)
        {

            try
            {
                Service.CustomerService customerservice= new Service.CustomerService();
                JsonResult json = this.Json(customerservice.GetCustomerData(customer),JsonRequestBehavior.AllowGet);
                return json;
            }
            catch (Exception)
            {
                return Json(false);
            }
        }
    }
}