using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.EnterpriseServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajax_Enabled_Forms.Models;
using System.Web.Mvc;
using System.Web;



namespace Ajax_Enabled_Forms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(StudentModel model)
        {
            StringBuilder sb = new StringBuilder("Form data:\n");
            sb.Append(model.Name + ", " + model.Address + "," + model.Class + "," + model.Email);
            return Content(sb.ToString());
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public ActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
