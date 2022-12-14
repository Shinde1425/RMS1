using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS.Models;

namespace RMS.Controllers
{
    public class HomeController : Controller
    {
        db dbop = new db();
        public IActionResult Index()
        {
            //return View();
            return View();
        }
        [HttpPost]
        public IActionResult Index([Bind] Ad_login ad)
        {
            string res = dbop.LoginCheck(ad);
            TempData["msg"] = res;

            //if (res=="")
            //{
            //    TempData["msg"] = "You are welcome to Admin Section";
            //}
            //else
            //{
            //    TempData["msg"] = "Admin id or Password is wrong.!";
            //}
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            //test
            //test22
        }
    }
}
