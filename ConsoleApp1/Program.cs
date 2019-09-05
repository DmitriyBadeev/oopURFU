using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashset = new HashSet<long>(); 

            for (var i = 2; i <= 100; i++)
                for (var j = 2; j <= 100; j++)
                {
                    var number = (long)Math.Pow(i, j);
                    hashset.Add(number);
                }

            var en = hashset.OrderBy(x => x);

            foreach(var el in en)
                Console.Write(el + " ");
        }
    }
}
