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
            Console.WriteLine("Inserisci un numero");
            num = Convert.ToInt32(Console.ReadLine());
            while(num>1)
            {
                int resto = num % 8;
                risultato = Convert.ToString(resto,8) + risultato;
                num = num / 8;
            }
            risultato = Convert.ToString(num) + risultato;
            Console.WriteLine($"Il numero in base 8 è {risultato}");

            Console.ReadLine();

        }
    }
}
