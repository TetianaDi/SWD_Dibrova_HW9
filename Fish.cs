using System;

namespace SWD_Dibrova1
{
    // HW 9 
    internal class Fish : Animal
    {
        public Fish(int lenght, string name, string color) : base(lenght, name, color)
        {
        }

        public int diveDepth;



        public void DefaultDepth()
        {
            Console.WriteLine($"Default fish depth is {diveDepth}");

        }

       

        public void FindDepth()
        {
            Console.WriteLine($"Current fish depth is {diveDepth}");

        }

    }
}
