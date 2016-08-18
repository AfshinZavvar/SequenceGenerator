using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SequenceGenerator.Classs
{
    public class GenerateMultiple:GenerateAllNumbers
    {
        public GenerateMultiple(int number):base(number)
        {
           
        }
        public override List<string> Generate()
        {
            var result = base.Generate();
            return result.Select(
                n =>
                    (Convert.ToInt32(n) % 15 == 0)
                        ? "Z"
                        : (Convert.ToInt32(n) % 3 == 0)
                            ? "C"
                            : (Convert.ToInt32(n) % 5 == 0)
                                ? "E"
                                : n.ToString())
                .ToList();

        }
    }
}