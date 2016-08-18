using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SequenceGenerator.Classs;
using SequenceGenerator.ViewModel;

namespace SequenceGenerator.Controllers
{
    public class DefaultController : Controller
    {
       public ActionResult Index()
        {
            return View("Index");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SequenceGenerator(FormCollection form)
        {
            int number = 1;
            int which = 1;

            if (!Int32.TryParse(form["num"], out number) || (!Int32.TryParse(form["which"], out which)) ||
                (number > 250) || (number < 1))
            {
                ViewBag.Error = "Number is not between 1 and 250";
                return View("Error");
            }

            try
            {
                SequenceViewModel sv = new SequenceViewModel
                {
                    Number = number,
                    NumbersList = Factory.GetInstance((SeqType) which, number).Generate()
                };

                return View(sv);
            }
            catch
            {
                ViewBag.Error = "Error in proccessing your request";
                return View("Error");
            }
        }

        public ActionResult SequenceGenerator()
        {
            return View("Index");
        }
    }
}