using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            if (Session["User"] != null)
            {
                List<BaseEquipment> plstData = BaseEquipment.ListEquipmentData();
                ViewBag.plstData = plstData;
                ViewBag.txtName = "";

                List<Employee> employees = Employee.GetEmployee();
                ViewBag.employees = employees;
                ViewBag.txtEmployee = "";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
            
        }

        [HttpPost]
        public ActionResult Dashboard(FormCollection frm, string btnSubmit, string btnSbmitEmp)
        {
            List<BaseEquipment> plstData = BaseEquipment.ListEquipmentData();
            ViewBag.plstData = plstData;
            ViewBag.txtName = "";
            if (btnSubmit == "Search")
            {
                ViewBag.txtName = frm["txtName"].ToString();
            }
            

            List<Employee> employees = Employee.GetEmployee();
            ViewBag.employees = employees;
            ViewBag.txtEmployee = "";
            if (btnSbmitEmp=="Search")
            {
                ViewBag.txtEmployee = frm["txtEmployee"].ToString();
            }
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}