using System.Collections.Generic;

namespace Logic
{
    public interface IAlgoService
    {
        int MethodsCalledCount { get; }

        int DoubleSum(IEnumerable<int> arg);

        int MinValue(IEnumerable<int> arg);

        double Function(int a, double b, int c, double d);
    }
}