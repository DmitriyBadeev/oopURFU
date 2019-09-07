using System.Collections.Generic;
using System.Numerics;

namespace OOP
{
    class OOP1
    {
        public static int SolveTask1()
        {
            var hashset = new HashSet<BigInteger>();

            for (var i = 2; i <= 100; i++)
                for (var j = 2; j <= 100; j++)
                {
                    var number = BigInteger.Pow(i, j);
                    hashset.Add(number);
                }

            return hashset.Count;
        }
    }
}
