using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_petlje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite pozitivan broj:");
            int broj =Convert.ToInt32(Console.ReadLine());

            for(int i = 1;i< broj;i++) 
            {
                for(int j=1;j<i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
