using System;

namespace SWD_Dibrova1
{
    // HW 9
    internal class Bird : Animal
    {
        public Bird() 
        {

        }
      
        public bool fly {  get; set; }
        public int tailLenght { get; set; }      

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

