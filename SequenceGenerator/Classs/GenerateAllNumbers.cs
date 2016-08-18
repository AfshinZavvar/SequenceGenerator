using System.Collections.Generic;
using System.Linq;

namespace SequenceGenerator.Classs
{
    public class GenerateAllNumbers : ISequence
    {
        private readonly int _number;
        public GenerateAllNumbers(int number)
        {
            _number = number;
        }
        public virtual List<string> Generate()
        {
            return Enumerable.Range(1, _number).Select(x=>x.ToString()).ToList();
        }

    }
}