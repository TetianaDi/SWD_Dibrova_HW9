using System;
using System.Xml.Linq;

namespace SWD_Dibrova1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 20;
            int y = 30;
            SumMyNumbers(x, y);
            
            var person = new Person();
            person.Print();

           


        }
        static void SumMyNumbers(int x, int y)
        {

            int result = x + y;

            Console.WriteLine($"My sum is {result}");
        }
    }
}

