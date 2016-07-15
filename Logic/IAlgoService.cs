using System.Collections.Generic;

namespace Logic
{
    public interface IAlgoService
    {
        int MethodsCalledCount { get; }

        int DoubleSum(IEnumerable<int> arg);

        int MinValue(IEnumerable<int> arg);


        double GetAverage(IEnumerable<int> data);
        double Sqr(int data);
    }
}