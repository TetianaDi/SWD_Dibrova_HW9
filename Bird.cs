using System;

namespace SWD_Dibrova1
{
    // HW 9
    internal class Bird : Animal
    {
        public Bird(int lenght, string name, string color, int tailLenght) : base(lenght, name, color)
        {
            this.TailLenght = tailLenght;
        }

        public new string sound = "cra";
        public override string MakeSound()
        {
            Console.WriteLine($"This animal says {sound}");
            return sound;
        }

        public int TailLenght { get; set; }

        public bool Fly { get; set; }

        public void BirdCanFly(bool fly)
        {
            if (fly == true)
            {
                Console.WriteLine("Bird can fly");
            }
            else
            {
                Console.WriteLine("This is not a bird or maybe this is penguin");
            };
        }
    }
    

}

