using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Dibrova1
{
    internal class Seasons
    {
        // HW 6.1
        public void PrintSeasons(int month) 
        {            
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    {
                        Console.WriteLine($"Now is winter");
                    }
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Now is spring");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Now is summer");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Now is autumn");
                    break;

                default:
                    Console.WriteLine("I don't know this month");
                    break;
            }
        }

    }
}
