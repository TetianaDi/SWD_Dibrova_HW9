using System;

namespace SWD_Dibrova1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HW1
            /*
                int x = 20;
                int y = 30;
                PrintSumNumb(x, y);
            */

            //HW 2.1
            var person = new Person("Name", "Surname", 99);
            person.PrintPerson();
            

            //HW 2.2
            //признаюсь чесно, що рішення нагуглила =) =( 
            
            int a = 1;
            int b = 2;
            (a, b) = (b, a);


            Console.WriteLine($"First a: {a} First b: {b}");
            Console.WriteLine($"Second a: {a} Second b: {b}");

            Console.ReadLine();
        }

            // HW1

            /*
            static void PrintSumNumb(int x, int y)
            {

                int result = x + y;

                Console.WriteLine($"My sum is {result}");
            }
            */
    }
}

