using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>This program will expand a basic quadratic equation<<<<<<<<");
            Console.WriteLine("__________________________<x+n> <x+m>___________________________");
            Console.WriteLine("LOOKING AT THE ABOVE BRACKETS....");


            Console.WriteLine("enter a +ve or -ve value for n:");
            decimal n=decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter a +ve or -ve value for m:");
            decimal m= decimal.Parse(Console.ReadLine());
            decimal b = n + m;
            decimal c = n * m;
            Console.WriteLine("that standard form is:x^2 {0} x{1} ", b, c);

            Console.WriteLine("Press enter to quit");


            Console.ReadLine();
        }
    }
}
