using System;

namespace SWD_Dibrova1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 25;
            int y = 16;
                     
            СountSquareRoot(x, y);

            // please see SquareRoot class 
            //var squareRoot = new сountSquareRoot(9, 15);





            // HW 3.1
            /*
                int x = 20;
                int y = 30;
                PrintSumNumb(x, y);
            */

            // HW 3.2
            /*
            static void PrintSumNumb(int x, int y)
            {

                int result = x + y;

                Console.WriteLine($"My sum is {result}");
            }
            */

            // HW 4.1
            /*
             var person = new Person("Name", "Surname", 99);
             person.PrintPerson
            */

            // HW 4.2
            // признаюсь чесно, що рішення нагуглила =) =(             
            /*
            int a = 1;
            int b = 2;
            (a, b) = (b, a);

            Console.WriteLine($"First a: {a} First b: {b}");
            Console.WriteLine($"Second a: {a} Second b: {b}");
            */




            Console.ReadLine();
        }

        // HW 5
        static void СountSquareRoot(int x, int y)
        {

            if (x < y)

            {

                Console.WriteLine(Math.Sqrt(y));
            }
            else
            {

                Console.WriteLine(Math.Sqrt(x));
            }
        }



    }
}

