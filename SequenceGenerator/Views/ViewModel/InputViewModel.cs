using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SequenceGenerator.ViewModel
{
    public class InputViewModel
    {
        [Required]
        [Range(1, 100)]
        public int Number { get; set; } = 1;

        [Required]
        public int SelectedSequenceId { get; set; }

        public Dictionary<int, string> SequenceList { get; set; }

        public InputViewModel()
        {
            SelectedSequenceId = 0;
            SequenceList = new Dictionary<int, string>()
            {
                {1, "All Numbers"},
                {2, "Even Numbers"},
                {3, "Odd Numbers"},
                {4, "Multiple Numbers"},
                {5, "Fibonacii Numbers"},
            };
        }
    }
}