using System.Collections.Generic;

namespace SequenceGenerator.Classs
{
    public interface ISequence
    {
        List<string> Generate();
    }
}