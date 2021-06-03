using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.36

            int n = 0;
            int a = 100;
            while(n<=10)
            {
                if(a % 10 == 7 && a % 9 == 0)
                {
                    n++;
                    Console.WriteLine(a);

                }
                a++;
            }
            Console.ReadKey();
           

        }
    }
}
