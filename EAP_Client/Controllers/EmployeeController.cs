using EAP_Client.EAP_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAP_Client.Controllers
{
    public class EmployeeController : Controller
    {
   
        static EAP_Client.Service1Client service1Client = new EAP_Client.Service1Client();
        public ActionResult Index()
        {
            var listEmployee = service1Client.GetList();
            return View(listEmployee);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            service1Client.Save(employee);
            return RedirectToAction("Index");
        }

    }
}