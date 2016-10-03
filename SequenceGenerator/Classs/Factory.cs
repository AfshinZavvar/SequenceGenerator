using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SequenceGenerator.Classs
{
    public enum SeqType
    {
        All = 1,
        Even,
        Odd,
        Mutiple,
        Fib
    }

    public class Factory
    {
        public static ISequence GetInstance(SeqType type, int number)
        {
            switch (type)
            {
                case SeqType.All:
                    return new GenerateAllNumbers(number);
                case SeqType.Even:
                    return new GenerateEvenNumbers(number);

                case SeqType.Odd:
                    return new GenerateOddNumbers(number);

                case SeqType.Mutiple:
                    return new GenerateMultiple(number);

                case SeqType.Fib:
                    return new GenerateFibonacci(number);
                default:
                    return new GenerateAllNumbers(number);
           }
        }

        public static string GetInstanceName(SeqType type)
        {
            switch (type)
            {
                case SeqType.All:
                    return "All numbers";
                case SeqType.Even:
                    return "Even Numbers";

                case SeqType.Odd:
                    return "Odd Numbers";

                case SeqType.Mutiple:
                    return "Multiple to 3 and 5 numbers";

                case SeqType.Fib:
                    return "Fibonacci";
                default:
                    return string.Empty;
            }
        }
    }
}