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
            NumbersList=new List<string>();
        }
        public  int Number { get; set; }
        public List<string> NumbersList { get; set; }
    }
}