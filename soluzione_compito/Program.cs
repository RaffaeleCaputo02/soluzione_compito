using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soluzione_compito
{
    class Program
    {
        static void Main(string[] args)
        {
            string risultato="";
            int num;
            int valBase;
            Console.WriteLine("Inserisci un numero");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Inserisci la base in cui vuoi convertire il numero, quelle disponibili sono 2, 8 e 16");
                valBase = Convert.ToInt32(Console.ReadLine());
                if (valBase != 2 || valBase != 8 || valBase != 16)
                {
                    Console.WriteLine("ATTENZIONE, la base inserita non è disponinile");
                }
            } while (valBase != 2 || valBase != 8 || valBase != 16);

            while (num>1)
            {
                int resto = num % valBase;
                risultato = Convert.ToString(resto,valBase) + risultato;
                num = num / valBase;
            }
            risultato = Convert.ToString(num) + risultato;
            Console.WriteLine($"Il numero in base {valBase} è {risultato}");

            Console.ReadLine();

        }
    }
}
