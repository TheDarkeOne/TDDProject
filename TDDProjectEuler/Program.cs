using System;

namespace TDDProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            EulerProblem1 euler = new EulerProblem1();
            euler.PrintNumbers(25);
            euler.PrintSum(1000);
        }
    }
}
