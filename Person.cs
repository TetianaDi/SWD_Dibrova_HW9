using System;

namespace SWD_Dibrova1
{

    public class Person
    {
        public Person()
        {

        }

        public void Print(int age, string name, string surname)
        {

            if (age >= 120 || age <= 0 || name.Length <= 2 || surname.Length == 2) //як перевірити на наявність спецсимволів?
            {
                Console.WriteLine("Check your age, name or surname");
            }
            else
            {
                Console.WriteLine($"I am {age} years old. my name is {name} {surname}");
            }

        }

    }
}



