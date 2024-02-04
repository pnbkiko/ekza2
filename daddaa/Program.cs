using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daddaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = 0;
            double a = 3;
            double b = 3;
            
            for (int i = 1; i <= n; i++)
            {
                x += a / (b * (b + i));
                a += 3;
                b += 4;

            }
            Console.WriteLine($"Ответ:{x:f6}");
        }
    }
}
