using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dadadaddddddddd
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double x=0;
            if (a > b)
            {
                x = a * b -1;
                Console.WriteLine($"Ответ:x = {x} ");
            }
            else if (a == b)
            {
                x = 255;
                Console.WriteLine($"Ответ:x = {x} ");
            }
            else 
            {
                if (b != 0)
                {
                    x = (a - 5) / b;
                    Console.WriteLine($"Ответ:x = {x} ");
                }
                else
                {
                    Console.WriteLine("Нельзя делить на ноль");
                }

            }
        }
    }
}
