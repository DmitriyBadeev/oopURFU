using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class OOP2
    {
        public static int SolveTask2()
        {
            var primeList = new List<int>();

            const int COUNT_NUMBERS = 11;

            var number = 10;
            while (primeList.Count != COUNT_NUMBERS)
            {
                if (IsEndShortened(number) && IsStartShortened(number))
                    primeList.Add(number);

                number++;
            }

            return primeList.Sum();
        }

        static bool IsStartShortened(int number)
        {
            while (number != 0)
            {
                if (!IsPrime(number))
                    return false;

                number = number / 10 != 0 ? MinusFirstDigit(number) : 0;
            }
            return true;
        }

        static bool IsEndShortened(int number)
        {
            while (number != 0)
            {
                if (!IsPrime(number))
                    return false;

                number = number / 10 != 0 ? MinusLastDigit(number) : 0;
            }
            return true;
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

        static int MinusFirstDigit(int number)
        {
            return int.Parse(number.ToString().Substring(1));
        }

        static int MinusLastDigit(int number)
        {
            var numStr = number.ToString();
            return int.Parse(numStr.Substring(0, numStr.Length - 1));
        }
    }
}
