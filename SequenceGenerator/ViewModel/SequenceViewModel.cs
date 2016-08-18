using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SequenceGenerator.Classs;

namespace SequenceGenerator.ViewModel
{
    public class SequenceViewModel
    {
        public SequenceViewModel()
        {
            Number = 1;
            AllNumbers=new List<string>();
            EvenNumbers=new List<string>();
            OddNumbers=new List<string>();
            FibonacciNumber=new List<string>();
            MultipleNumber=new List<string>();
        }
        public  int Number { get; set; }
        public List<string> AllNumbers { get; set; }
        public List<string> EvenNumbers { get; set; }
        public List<string> OddNumbers { get; set; }
        public List<string> FibonacciNumber { get; set; }
        public List<string> MultipleNumber { get; set; }
    }
}