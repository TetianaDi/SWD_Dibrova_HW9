using System;

namespace SWD_Dibrova1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HW 6.1
            /*
            var seasons = new Seasons();         
            seasons.PrintSeasons(12);
            */

            
            // HW 6.2
            var person1 = new Person(125, "Nick", "Name");
            //person1.Person;
            

            //HW 6.3
            /*
            for (int i = 1; i <= 100; i++)

            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else
                {
                    Console.WriteLine(i);
                }                        
            }
            */

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
             var person = new Person2("Name", "Surname", 99);
             person.PrintPerson;
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

            // HW 5
            /*
            var squareRoot = new SquareRoot();
            squareRoot.СountSquareRoot(9, -9);
            */
            

            Console.ReadLine();
        }

    }
}

