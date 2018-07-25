using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MyBreathingspace.Web.Controllers
{
    public class HomeController : Controller
    {
       
        public HomeController()
        {
          
        }


        public ActionResult Index()
        {
            //Post p = new Post() { Category = new Category() { Description = "WW" } };

            //List<Post> result = new List<Post>();
            //result.Add(p);
            //var result = _repository.Posts().OrderByDescending(x => x.PostedOn).Take(3).ToList();
            //return View(result);

            IndexViewModel vm = new IndexViewModel() { FootnoteDate = new DateTime(2017, 11, 5) };

            return View(vm);
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

        [Route("mbsr/week1")]
        public ActionResult WeekOne()
        {
            ViewBag.Message = "Week One";

            return View();
        }

        [Route("mbsr/week2")]
        public ActionResult WeekTwo()
        {
            ViewBag.Message = "Week Two";

            return View();
        }

        [Route("mbsr/week3")]
        public ActionResult WeekThree()
        {
            ViewBag.Message = "Week Three";

            return View();
        }

        [Route("mbsr/week4")]
        public ActionResult WeekFour()
        {
            ViewBag.Message = "Week Four";

            return View();
        }

        [Route("mbsr/week5")]
        public ActionResult WeekFive()
        {
            ViewBag.Message = "Week Five";

            return View();
        }

        [Route("mbsr/week6")]
        public ActionResult WeekSix()
        {
            ViewBag.Message = "Week Six";

            return View();
        }

        [Route("mbsr/week7")]
        public ActionResult WeekSeven()
        {
            ViewBag.Message = "Week Seven";

            //IndexViewModel vm = new IndexViewModel() { FootnoteDate = new DateTime(2017, 11, 5) };
            //return RedirectToAction("Index", vm);
           return View();
        }
    }
}