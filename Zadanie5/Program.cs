using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dlug = 80;
            int dziennyZarobekKarola = 40;
            int dziennyZarobekJanka = 50;
            int splata = 0;
            int dzien = 0;

            do
            {
                dzien++;
                splata += (int)(0.2 * dziennyZarobekJanka + 0.2 * dziennyZarobekKarola);
                Console.WriteLine("dzień nr: {0}, spłata łączna do tego dnia: {1}", dzien, splata);

            } while (splata < dlug);

            Console.ReadKey();

        }
    }
}
