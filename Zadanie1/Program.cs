using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int s = 0;

            while (i<10)
            {
                s = s + i;
                Console.Write("{0} + ", i);
                i = i + 1;
                
            }

            s = s + i;
            Console.Write("{0} = ", i);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
