using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceGenerator.Classs
{
    public class GenerateOddNumbers : GenerateAllNumbers
    {
        public GenerateOddNumbers(int number):base(number)
        {
        }
        public override List<string> Generate()
        {
            var result = base.Generate();
            return result.Where(x => Convert.ToInt32(x) % 2 !=0).ToList();
        }
    }
}