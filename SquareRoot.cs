using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SWD_Dibrova1
{
    public class SquareRoot
    {
        public void СountSquareRoot(int x, int y)
        {

            if (x <=0 || y <=0)
            {
                Console.WriteLine("One of the numbers is zero or negative");
            }         
            else if (x > y)
            {
                Console.WriteLine(Math.Sqrt(x));
            }
            else if (x == y)
            {
                Console.WriteLine("Numbers are equal");
            }
            else if (x < y)
            {

                Console.WriteLine(Math.Sqrt(y));
            }
            else
            {

                Console.WriteLine("Check your numbers");
            }
        }
    }
}
