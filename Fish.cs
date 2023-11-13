using System;

namespace SWD_Dibrova1
{
    // HW 9 
    internal class Fish : Animal
    {
        public Fish()
        {

        }

        public int diveDepth = 0;

        public void DefaultDepth()
        {
            Console.WriteLine($"Default fish depth is {diveDepth}");

        }

        public void FindDepth(int diveDepth)
        {
            Console.WriteLine($"Current fish depth is {diveDepth}");

        }

    }
}
