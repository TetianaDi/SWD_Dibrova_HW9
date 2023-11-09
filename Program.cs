using SWD_Dibrova1.Ext;
using System;
using System.Linq;

namespace SWD_Dibrova1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrays forArrays = new Arrays();


            var array1 = new int[10];
            array1[0] = 80;
            array1[1] = 81;
            array1[2] = 82;
            array1[3] = 15;
            array1[4] = 41;
            array1[5] = 51;
            array1[6] = 71;
            array1[7] = 16;
            array1[8] = 78;
            array1[9] = 98;

            // HW 8.1
            forArrays.ShowMaxOfArray(array1);

            // HW 8.2
            forArrays.SumEvenNumbers(array1);

            // HW 8.3
            int result = forArrays.MinValueOddIndex(array1);
            Console.WriteLine($"The minimum value of an element with an odd index " + result);

            Console.WriteLine("______");

            // HW 8.4
            string myString = "Friday!!!";           
            StringExtention.StringToSymbol(myString);
            Console.WriteLine(myString); //не знаю як прибрати нижню строку у звичайному написанні =(



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

            // HW 6.1
            /*
            var seasons = new Seasons();         
            seasons.PrintSeasons(12);
            */


            // HW 6.2
            /*
            var person1 = new Person(125, "Nick", "Name");
            */



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


            Console.ReadLine();
        }

    }
}

