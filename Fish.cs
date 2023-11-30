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


        public void FishDives()
        {
            Random randomDepth = new Random();
            int newDepth = randomDepth.Next(0, 30);

            //diveDepth = newDepth;
            Console.WriteLine($"Current fish depth is {newDepth}");
        }

    }
}
