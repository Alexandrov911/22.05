using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.86
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            int st = 0;
            int sl = 1;
            for (int i=1; i<=n; i++)
            {
                st = st + sl;
                sl = sl + 2;
            }
            Console.WriteLine(st);
            Console.ReadKey();



        }
    }
}
