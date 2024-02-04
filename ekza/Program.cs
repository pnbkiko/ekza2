using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekza
{
    class Program
    {
        static void Main(string[] args)
        {
            double moba(double mb)
            {
                double sum = 0;
                if (0 < mb && mb < 100)
                {
                    sum = 120;
                }
                else
                {
                    sum = mb * 2;

                }
                return sum;
            }
            double ras = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ответ:сумма оплаты за месяц {moba(ras)}");

        }
    }
}
