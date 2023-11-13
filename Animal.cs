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

        public virtual void BaseAnimal(int lenght, string name, string color)
        {
            this.Lenght = lenght;
            this.Name = name;
            this.Color = color;
        }

            public int Lenght {  get; set; }

            public string Name { get; set; }

            public string Color { get; set; }                  

        public void MakeSound(string sound)
        {
            
            Console.WriteLine($"This animal says {sound}");
        }
        
    }
}



