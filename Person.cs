using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SWD_Dibrova1
{
    
    public class Person
    {

        public string name = "Tania";
        public string surname = "Dibrova";
        public int age = 32;
        
        public void Print()
        {
            Console.WriteLine($"I am {age} years old, my name is {name} {surname}");
            //Console.ReadLine();
        }

    }

}
        


