using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationform.Models;

namespace WebApplicationform.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetDetails()
        {
            UserDataModel umodel = new UserDataModel();
            umodel.Name = HttpContext.Request.Form["txtName"].ToString();
            umodel.mobileno = Convert.ToInt32(HttpContext.Request.Form["txtmobileno"]);
            umodel.City = HttpContext.Request.Form["txtCity"].ToString();

            int result = umodel.SaveDetails();
            if (result > 0)
            {
                ViewBag.Result = "Data Saved Successfully";
            }
            else
            {
                ViewBag.Result = "Something Went Wrong";
            }
            return View("Profile");
        }
    }
}
