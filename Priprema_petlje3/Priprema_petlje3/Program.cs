using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Priprema_petlje3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int start;
            Console.WriteLine("Unesite 1. broj:");
            int broj1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite 2. broj:");
            int broj2 = Convert.ToInt32(Console.ReadLine());

            if(broj1 > broj2)
            {
                start =broj1;
            }
            else 
            {
                start = broj2;
            }

            for(int i = start;i>0;i--)
            {
                if(broj1%i == 0 && broj2%i==0)
                {
                    Console.WriteLine("najveći broj koji dijeli broj1 i broj2 je " + i);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
