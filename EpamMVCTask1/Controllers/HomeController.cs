using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using EpamMVCTask1.DLL.Models;
using EpamMVCTask1.Extensions;

namespace EpamMVCTask1.Controllers
{
    public class HomeController : Controller
    {
        //Initializer initializer = new Initializer();
        private BlogContext initializer = new BlogContext();

        // GET: Home
        public ActionResult Index()
        {
            var article = initializer.Articles.Include(v => v.Tags).ToList();

            foreach (var f in article)
            {
                string result = "";

                if (f.Text.Length > 200)
                {
                    foreach (var d in f.Text.Take(200))
                    {
                        result += d;
                    }

                    f.Text = result + "...";
                }
            }

            return View(article); 
        }

            public ActionResult OpenHoleArticle(int? Id)
        {
            if (Id == null)
            {
                return HttpNotFound();
            }

            Article article = initializer.Articles.Find(Id);

            if (article == null)
            {
                return HttpNotFound();
            }

            return View(article);
        }

        public ActionResult Guest()
        {
            return View(initializer.Feedbacks);
        }

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
        
        public ActionResult Profile(FormCollection form) 
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