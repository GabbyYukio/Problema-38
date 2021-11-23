using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//38.Scrieţi o functie care să calculeze factorialul unui număr întreg n

namespace FundamenteleProgramarii38
{
    class Program
    {
        static ulong factorialul(ulong n)//returneaza long pentru ca numerele pot sa fie foarte mari
        {
            ulong e=1;
            while(n!=1)
            {
                e = e * n;
                n--;
            }
            return e;

        }
        static void Main(string[] args)
        {
            //INPUT
            ulong n; //factorialul nu poate sa fie negativ si este intotdeauna pozitiv
            Console.WriteLine("Dati valoare lui n: ");
            n=ulong.Parse(Console.ReadLine());

            Console.WriteLine("Factorialul lui {0} este {1}.", n, factorialul(n));
            Console.ReadLine();
        }
    }
}
