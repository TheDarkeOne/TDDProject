using System;
using System.Collections.Generic;
using System.Text;

namespace TDDProjectEuler
{
    public class EulerProblem1
    {
        public string GenerateFizzBuzz(int number) 
        {
            if (number % 3 == 0) 
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}
