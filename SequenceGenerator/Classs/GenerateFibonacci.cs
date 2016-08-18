using System;
using System.Collections.Generic;

namespace SequenceGenerator.Classs
{
    public class GenerateFibonacci : ISequence
    {
        private readonly int _number;

        public GenerateFibonacci(int number)
        {
            _number = number;
        }
        public List<string> Generate()
        {
            var result = new List<string>();
            Func<int, int> fib = null;

            fib = n => (n < 2) ? 1 : fib(n - 1) + fib(n - 2);

            for (var i = 0; i <= _number; i++)
                result.Add(fib(i).ToString());

            return result;
        }
    }
}