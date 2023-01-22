using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_petlje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetak = 1900;
            int kraj = 2100;

            do
            {
                if (pocetak % 100 == 0)
                {
                    if (pocetak % 400 == 0)
                    {
                        Console.WriteLine(pocetak + ". je prijestupna godina.");
                    }
                }
                else if (pocetak % 4 == 0)
                {
                    Console.WriteLine(pocetak + ". je prijestupna godina.");
                }

                pocetak++;
            } while (pocetak <= kraj);


            Console.ReadKey();
        }
    }
}
