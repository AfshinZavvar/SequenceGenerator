using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceGenerator.Classs
{
    public class GenerateFibonacci : ISequence
    {
        private readonly int _number;

        public GenerateFibonacci(int number)
        {
            _number = number;
        }
        public static IEnumerable<Int64> GetFibonacciSequence()
        {
            yield return 0;
            yield return 1;

            int previous = 0;
            int current = 1;

            while (true)
            {
                int next = previous + current;
                previous = current;
                current = next;
                yield return next;
            }
        }

        public List<string> Generate()
        {
            return GetFibonacciSequence().Take(_number).Select(i => (i).ToString()).ToList();
        }
    }
}