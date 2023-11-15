using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Dibrova1
{
    internal class Printer
    {
        // HW 10

        /// <summary>
        /// This method prints by default
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Print(char o)
        {
            
            if (o == 'f')
            {
                Console.WriteLine("The printer is turned off");
                return false;
            }
            else if (o != 'o')
            {
                Console.WriteLine("Printer is broken");
                return false;
            }
            else
            {
                Console.WriteLine("Printer is working");
                return true;
            }
        }

        /// <summary>
        /// This method prints the given string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Print(string str)
        {
            Console.WriteLine(str);
            return str;
            
        }

        /// <summary>
        /// This method prints the given number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int Print (int num)
        {
            Console.WriteLine($"Your number is {num}");
            return num;
        }

        /// <summary>
        /// This method prints the person's name and age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public string Print(string name, int age)
        {
            Console.WriteLine($"{name} is {age} years old");
            return name + age;
        }


        /// <summary>
        /// This method prints the number of floors of the building and the developer's company name
        /// </summary>
        /// <param name="floor"></param>
        /// <param name="companyName"></param>
        /// <returns></returns>
        public string Print(int floor, string companyName)
        {
            Console.WriteLine($"This {floor}-story building was built by {companyName}");
            return floor + companyName;
        }
    }
}
