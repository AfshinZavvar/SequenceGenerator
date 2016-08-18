using System.Collections.Generic;
using System.Web.Mvc;
using NUnit.Framework;
using SequenceGenerator.Classs;
using SequenceGenerator.Controllers;
using SequenceGenerator.ViewModel;

namespace SequenceGenerator.Unit_Testing
{
    [TestFixture]
    public class ControllerTest
    {
        [Test]
        public void All_Number_List_after_Post_Method()
        {
            var controller = new DefaultController();
            var result = (ViewResult) controller.SequenceGenerator(new FormCollection { { "num", "4" }, {"which","1"} });
            var sv = (SequenceViewModel) result.Model;
            var expected = new List<string> {"1", "2", "3", "4"};
            CollectionAssert.AreEqual(expected, sv.NumbersList);
        }

        [Test]
        public void Fibonacii_Number_List_after_Post_Method()
        {
            var controller = new DefaultController();
            var result = (ViewResult) controller.SequenceGenerator(new FormCollection {{"num", "4"}, {"which", "5"}});
            var sv = (SequenceViewModel) result.Model;
            var expected = new List<string> {"0", "1", "1", "2"};
            CollectionAssert.AreEqual(expected, sv.NumbersList);
        }

        [Test]
        public void Get_SequenceGenerator_View_Name_Is_Index()
        {
            var obj = new DefaultController();
            var actResult = obj.SequenceGenerator() as ViewResult;
            Assert.That(actResult.ViewName, Is.EqualTo("Index"));
        }

        [Test]
        public void If_Input_Is_in_Big_Should_Return_To_Error()
        {
            var controller = new DefaultController();
            var result = (ViewResult)controller.SequenceGenerator(new FormCollection { { "num", "251" }, { "which", "1" } });

            Assert.That(result.ViewName, Is.EqualTo("Error"));
        }

        [Test]
        public void If_Input_Is_in_Wrong_Format_Should_Show_Error()
        {
            var controller = new DefaultController();
            var result = (ViewResult)controller.SequenceGenerator(new FormCollection { { "num", "b" }, { "which", "c" } });

            Assert.That(result.ViewName, Is.EqualTo("Error"));
        }

        [Test]
        public void Index_View_Is_Not_Null()
        {
            var obj = new DefaultController();
            var actResult = obj.Index() as ViewResult;
            Assert.That(actResult, Is.Not.Null);
        }

        [Test]
        public void Index_View_Name_Is_Index()
        {
            var obj = new DefaultController();
            var actResult = obj.Index() as ViewResult;
            Assert.That(actResult.ViewName, Is.EqualTo("Index"));
        }

        [Test]
        public void SequenceGenerator_Model_Type_SequenceViewModel()
        {
            var controller = new DefaultController();
            var result = (ViewResult)controller.SequenceGenerator(new FormCollection { { "num", "4" }, { "which", "1" } });
            Assert.IsInstanceOf(typeof (SequenceViewModel), result.Model);
        }
    }
}