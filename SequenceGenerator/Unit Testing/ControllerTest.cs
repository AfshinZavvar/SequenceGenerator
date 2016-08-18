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
            var form = new FormCollection {{"num", "4"}};
            var result = (ViewResult) controller.SequenceGenerator(form);
            var sv = (SequenceViewModel) result.Model;
            var expected = new List<string> {"1", "2", "3", "4"};
            CollectionAssert.AreEqual(expected, sv.AllNumbers);
        }

        [Test]
        public void Fibonacii_Number_List_after_Post_Method()
        {
            var controller = new DefaultController();
            var form = new FormCollection {{"num", "4"}};
            var result = (ViewResult) controller.SequenceGenerator(form);
            var sv = (SequenceViewModel) result.Model;
            var expected = new List<string> {"1", "1", "2", "3", "5"};
            CollectionAssert.AreEqual(expected, sv.FibonacciNumber);
        }

        [Test]
        public void Generate_Method_In_Controller_Should_Return_all_numbers()
        {
            var controller = new DefaultController();
            var form = new FormCollection {{"num", "4"}};
            var real = controller.Generate(new GenerateAllNumbers(4));
            var expected = new List<string> {"1", "2", "3", "4"};
            CollectionAssert.AreEqual(expected, real);
        }


        [Test]
        public void Generate_Method_In_Controller_Should_Return_even_numbers()
        {
            var controller = new DefaultController();
            var form = new FormCollection {{"num", "4"}};
            var real = controller.Generate(new GenerateEvenNumbers(4));
            var expected = new List<string> {"2", "4"};
            CollectionAssert.AreEqual(expected, real);
        }

        [Test]
        public void Get_SequenceGenerator_View_Name_Is_Index()
        {
            var obj = new DefaultController();
            var actResult = obj.SequenceGenerator() as ViewResult;
            Assert.That(actResult.ViewName, Is.EqualTo("Index"));
        }

        [Test]
        public void If_Input_Is_in_Wrong_Format_Should_Return_To_homePage()
        {
            var controller = new DefaultController();
            var form = new FormCollection {{"num", "a"}};

            var result = (ViewResult) controller.SequenceGenerator(form);
            Assert.That(result.ViewName, Is.EqualTo("Index"));
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
            var form = new FormCollection {{"num", "3"}};

            var result = (ViewResult) controller.SequenceGenerator(form);
            Assert.IsInstanceOf(typeof (SequenceViewModel), result.Model);
        }
    }
}