using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Dibrova1
{
    internal class Person
    {
        static void Main(string[] args)
        {

            string name = "Tania";
            string surname = "Dibrova";
            int age = 32;
            Console.WriteLine($"I am {age} years old, my name is {name} {surname}");

            int x = 20;
            int y = 30;
            sumMyNumbers(x, y);

        }
        static void sumMyNumbers(int x, int y)
        {

            int result = x + y;

            Console.WriteLine($"My sum is {result}");
        }
    }
}

