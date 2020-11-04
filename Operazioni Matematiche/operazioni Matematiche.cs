using System;

namespace Operazioni_Matematiche
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci un numero:");
            int b = Convert.ToInt32(Console.ReadLine());

            int somma = Matematica.Somma(a,b);
            Console.WriteLine($"la somma é:{somma}");

            double sommaDouble = Matematica.SommaDouble(a,b);
            Console.WriteLine($"la somma double è:{sommaDouble}");

            double sottrazione = Matematica.Sottrazione(a, b);
            Console.WriteLine($"la sottrazione è:{sottrazione}");

            Double moltiplicazione = Matematica.Moltiplicazione(a, b);
            Console.WriteLine($"la moltiplicazione è:{moltiplicazione}");

            double divisione = Matematica.Divisione(a,b);
            Console.WriteLine($"la divisione è:{divisione}");
            
        }
    }
}
