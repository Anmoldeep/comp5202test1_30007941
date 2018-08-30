using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(">>>>>This program tell you your number is even or odd<<<<<<");

            Console.WriteLine("_______________________________________________________________");
            int a;
            Console.WriteLine("enter a whole number between 1 and 1000:");
            a = int.Parse(Console.ReadLine());
            
            if(a % 2 ==0)
            {
                Console.WriteLine("That number is even");

            }
            else
            {
                Console.WriteLine("That number is odd");
            }
            Console.WriteLine("Press enter to quit");

            Console.ReadLine();
        }
    }
}
