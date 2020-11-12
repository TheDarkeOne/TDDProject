using System;
using System.Collections.Generic;
using System.Text;

namespace TDDProjectEuler
{
    public class EulerProblem1
    {
        public string GenerateFizzBuzz(int number) 
        {
            if (number % 3 == 0 && number % 5 == 0) 
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }

        public void PrintNumbers(int number) 
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(GenerateFizzBuzz(i));
            }
        }

        public void PrintSum(int number)
        {
            Console.WriteLine("The sum of all multiples of 3 and 5 below "+ number + " are: " + GenerateSum(number));
        }

        public int GenerateSum(int number) 
        {
            int sum = 0;
            for (int i = 0; i < number; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    sum += i;
                } else if (i % 3 == 0) 
                {
                    sum += i;
                } else if (i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
