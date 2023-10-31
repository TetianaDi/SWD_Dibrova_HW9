using System;

namespace SWD_Dibrova1
{

    public class Person
    {
        public Person()
        {

        }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    

        public string name;
        public string surname ;
        public int age;

        
        public void PrintPerson()
        {
            Console.WriteLine($"I am {age} years old, my name is {name} {surname}");           
        }
        

    }

}
        


