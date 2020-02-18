//using EpamMVCTask1.DLL.Models;
using EpamMVCTask1.DLL.Models;
using EpamMVCTask1.Extensions;
using EpamMVCTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpamMVCTask1.Controllers
{
    public class HomeController : Controller
    {
        //Initializer initializer = new Initializer();
        BlogContext initializer = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(initializer.Articles); //initializer.articles
        }
        public ActionResult Guest()
        {
            return View(initializer.Feedbacks);/*Initializer.feedbacks*/
        }/**/
        //[HttpPost]
        //public RedirectResult Guest(Feedback feedback)
        //{
        //    initializer.feedbacks.Add(feedback);
        //    return Redirect("~/Home/Guest");
        //}
        public ActionResult AddFeedback()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFeedback(DLL.Models.Feedback feedback)
        {
            AddData.AddFeedback(feedback, initializer);
            return Redirect("~/Home/Guest");
        }
        
        public ActionResult Profile(FormCollection form) // string name, string login, string email, string password,nstring date, string Gender, bool? checkbox1, string marital, string children
        {
            string check = "";

            if (form["checkbox1"] == null)
                check = "false";
            else
            {
                check = $"{form["checkbox1"]}";
            }
             
            if (Request.HttpMethod == "POST")
            {
                TempData["Name"] = form["name"];
                TempData["Login"] = form["login"];
                TempData["Email"] = form["email"];
                TempData["Password"] = form["password"];
                TempData["Date"] = form["date"];
                TempData["Gender"] = form["Gender"];
                TempData["Checkbox1"] = check;
                TempData["Marital"] = form["marital"];
                TempData["Children"] = form["children"];
                return Redirect("~/Home/Result");
            }

            return View();
            
        }
        //[HttpPost]
        //public ActionResult Profile(string name, string login, string email, string password, 
        //    string date, string Gender, string checkbox1, string checkbox2)
        //{
        //    TempData["Name"] = name;
        //    TempData["Login"] = login;
        //    TempData["Email"] = email;
        //    TempData["Password"] = password;
        //    TempData["Date"] = date;
        //    TempData["Gender"] = Gender;
        //    TempData["Checkbox1"] = checkbox1;
        //    TempData["Checkbox2"] = checkbox2;
        //    return Redirect("~/Home/Result");
        //}

        public ActionResult Result()
        {
            ViewBag.Name = TempData["Name"];
            ViewBag.Login = TempData["Login"];
            ViewBag.Email = TempData["Email"];
            ViewBag.Passsword = TempData["Password"];
            ViewBag.Date = TempData["Date"];
            ViewBag.Gender = TempData["Gender"];
            ViewBag.CheckBox1 = TempData["Checkbox1"];
            ViewBag.Marital = TempData["Marital"];
            ViewBag.Children = TempData["Children"];
            return View();
        }
    }
}