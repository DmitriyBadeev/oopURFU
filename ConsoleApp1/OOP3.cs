using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OOP3
    {
        public static int SolveTask3()
        {
            var abundantNumbers = new List<int>();
            var resultSum = 0;
            for (var num = 1; num <= 28123; num++)
            {
                if (IsAbundant(num))
                    abundantNumbers.Add(num);

                if (!abundantNumbers.HasSumTwoAbundantNumbersEqual(num))
                    resultSum += num;
            }

            return resultSum;
        }

        static bool IsAbundant(int number)
        {
            var sum = 0;

            for (var i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            return sum > number;
        }
    }

    static class ListExtension
    {
        public static bool HasSumTwoAbundantNumbersEqual(this List<int> abundantNumbers, int number)
        {
            foreach (var abNum in abundantNumbers)
            {
                if (abundantNumbers.Contains(number - abNum))
                    return true;
            }

            return false;
        }
    }
}
