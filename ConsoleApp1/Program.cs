using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            var answer1 = OOP1.SolveTask1();
            Console.WriteLine(answer1);

            var answer2 = OOP2.SolveTask2();
            Console.WriteLine(answer2);

            var answer3 = OOP3.SolveTask3();
            Console.WriteLine(answer3);

            var answer4 = OOP4.SolveTask4();
            Console.WriteLine(answer4);

            var answer5 = OOP5.SolveTask5();
            Console.WriteLine(answer5);
        }
    }
}