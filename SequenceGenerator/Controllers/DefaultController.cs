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
            InputViewModel input=new InputViewModel();
            return View(input);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SequenceGenerator(InputViewModel form)

        {
            if (!ModelState.IsValid)
            {
                InputViewModel input = new InputViewModel();
                return View("Index",input);
            }
            SequenceViewModel sv = new SequenceViewModel
            {
                Number = form.Number,
                SequenceName = form.SequenceList[form.SelectedSequenceId],
                NumbersList = Factory.GetInstance((SeqType) form.SelectedSequenceId, form.Number).Generate()

            };

            return View(sv);
        }

        public ActionResult SequenceGenerator()
        {
            return View("Index");
        }

        public JsonResult Test()
        {
            List<string> temp = new List<string>() {"afshin", "afsoon", "habib"};
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

    }
}