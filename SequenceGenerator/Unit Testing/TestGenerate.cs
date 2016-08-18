using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SequenceGenerator.Classs;

namespace SequenceGenerator.Unit_Testing
{
    [TestFixture]
    public class TestGenerate
    {
        protected int Number { get; set; }
        protected ISequence Sequence;
        protected List<string> Result { get; set; }

        [SetUp]
        public void Setup()
        {
            Number = 5;
            Result = new List<string>();
        }

        [Test]
        public void AllNumber_List_Should_Not_be_Null()
        {
            List<string> Result = Factory.GetInstance((Classs.SeqType) SeqType.All, Number).Generate();
            Assert.That(Result, Is.All.Not.Null);
        }

        [Test]
        public void AllNumber_List_As_Expected()
        {
            List<string> Result = Factory.GetInstance((Classs.SeqType)SeqType.All, Number).Generate();
            List<string> expected = new List<string> {"1", "2", "3", "4", "5"};

            CollectionAssert.AreEqual(expected, Result);
        }

        [Test]
        public void EvenNumber_List_As_Expected()
        {
            List<string> Result = Factory.GetInstance((Classs.SeqType)SeqType.Even, Number).Generate();
            var expected = new List<string> {"2", "4",};

            CollectionAssert.AreEqual(expected, Result);
        }

        [Test]
        public void OddNumber_List_As_Expected()
        {
            List<string> Result = Factory.GetInstance((Classs.SeqType)SeqType.Odd, Number).Generate();
            var expected = new List<string> {"1", "3", "5"};

            CollectionAssert.AreEqual(expected, Result);
        }

        [Test]
        public void MultipeNumber_List_As_Expected()
        {
            List<string> Result = Factory.GetInstance(SeqType.Mutiple, Number).Generate();

            var expected = new List<string> {"1", "2", "C", "4", "E"};

            CollectionAssert.AreEqual(expected, Result);
        }

        [Test]
        public void Fibonacci_List_As_Expected()
        {
            List<string> Result = Factory.GetInstance((Classs.SeqType)SeqType.Fib, Number).Generate();

            var expected = new List<string> {"0","1", "1", "2", "3"};

            CollectionAssert.AreEqual(expected, Result);
        }
    }
}