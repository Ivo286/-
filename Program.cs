using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namirane_na_chetno_i_nechetno
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Четно");
            }
            else
            {
                Console.WriteLine("Нечетно");
            }
            Console.ReadKey();
        }
    }
}
