using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
         int a, b, c, d, e, f, g, h, i, j, total;  
            Console.WriteLine(">>>This program will tell you average of your number<<<");

            Console.WriteLine("__________________________________________________________");
            
            

                Console.WriteLine($"Enter number{1}");
                a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter number{2}");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter number{3}");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter number{4}");
            e = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter number{5}");
            f = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter number{6}");
            g = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter number{7}");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter number{8}");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter number{9}");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter number{10}");
            c = int.Parse(Console.ReadLine());
            total = a + b + c + d + e + f + g + h + i + j;



            Console.WriteLine($"total of that {(total)/(10)} ");


            Console.WriteLine("Press enter to quit");



            Console.ReadLine();
        }
    }
}
