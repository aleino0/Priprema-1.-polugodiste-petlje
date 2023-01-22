using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_petlje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char znak=' ';
            int najvise = 0, broj;
            Console.WriteLine("Unesite niz znakova:");
            string niz = Console.ReadLine();
            
            for (int i = 0; i < niz.Length; i++) 
            {
                broj = 0;
                for (int j=0;j < niz.Length; j++) 
                {
                    
                    if (niz[i] == niz[j]) 
                    {
                        broj++;
                    }
                    if (broj > najvise)
                    {
                        znak = niz[i];
                        najvise = broj;
                    }
                }

            }

            Console.WriteLine("Najvise ponovljeni znak: {0} --> {1} puta", znak, najvise);

            Console.ReadKey();
        }
    }
}
