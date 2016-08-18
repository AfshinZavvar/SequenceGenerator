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
        public List<string> Generate(ISequence sequence)
        {
            return sequence.Generate();
        }

        public ActionResult Index()
        {
           return View("Index");

        }

        [HttpPost]
        public ActionResult SequenceGenerator(FormCollection form)
        {
            int number = 1;
            

            if (!Int32.TryParse(form["num"], out number))
            {
                return View("Index");
            }

            SequenceViewModel svm = new SequenceViewModel
            {
                AllNumbers = Generate(new GenerateAllNumbers(number)),
                EvenNumbers = Generate(new GenerateEvenNumbers(number)),
                OddNumbers = Generate(new GenerateOddNumbers(number)),
                FibonacciNumber = Generate(new GenerateFibonacci(number)),
                MultipleNumber = Generate(new GenerateMultiple(number))
            };

            ViewBag.Number = number;
            return View(svm);

        }

        public ActionResult SequenceGenerator()
        {
            return View("Index");
        }


    }
}