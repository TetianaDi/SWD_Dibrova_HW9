using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Dibrova1
{
    // HW 9
    internal class Animal
    {

        public Animal(int lenght, string name, string color)
        {
            Lenght = lenght;
            Name = name;
            Color = color;

        }

        public int Lenght { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public string sound = "silent";

        public virtual string MakeSound( )
        {
            
            Console.WriteLine($"This animal says {sound}");
            return sound;
        }
        
    }
}



