using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OOP4
    {
        public static int SolveTask4()
        {
            var number = 1;
            var countPrime = 0;

            while (countPrime != 10001)
            {
                number++;
                if (IsPrime(number))
                    countPrime++;
            }

            return number; 
        }

        static bool IsPrime(int number)
        {
            if (number == 1) return false;

            for (var i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
