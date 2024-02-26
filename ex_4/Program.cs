using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite três números : ");
            int a, b, c, s;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if ( c < 5 )
            {
                s = (a + b) * c;
                Console.WriteLine(s);
            }
            else
            {
                s = (b-a) * c;
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
