using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05
{
    class Program
    {
        static void Main(string[] args)
        {
            // for 5.6
            for (int i = 44; i <= 64; i = i + 2 )
            {
                Console.WriteLine(i * 1.0 / 10 + " ");
            }
            Console.WriteLine(" ");

            // while 5.6
            double i2 = 4.4;
            while (i2 <= 6.4)
            {
                Console.WriteLine(i2);
                i2 = i2 + 0.2;
            }
            Console.WriteLine(i2);
            Console.ReadKey();

        }
    }
}
