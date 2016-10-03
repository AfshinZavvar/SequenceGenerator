using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            NumbersList = new List<string>();
        }

        [Required]
        public int Number { get; set; }

        public List<string> NumbersList { get; set; }

        [Required]
        public String SequenceName { get; set; }

    }
}