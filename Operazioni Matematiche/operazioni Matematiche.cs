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
            Console.WriteLine("inserisci un numero:");
            int c = Convert.ToInt32(Console.ReadLine());

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

            long elevato = Matematica.Elevato(a, b);
            Console.WriteLine($"il numero elevato è:{elevato}");

            int minore = Matematica.Minore(a, b, c);
            Console.WriteLine($"il più piccolo è:{minore}");

            int maggiore = Matematica.Maggiore(a, b, c);
            Console.WriteLine($"il più grande è:{maggiore}");

            double inverso = Matematica.Inverso(a);
            Console.WriteLine($"l'inverso di {a} è: {inverso}");

            bool pari = Matematica.Pari(a);
            Console.WriteLine($"{a} è un numero pari?:{pari}");

            bool dispari = Matematica.Dispari(a);
            Console.WriteLine($"{a} è un numero dispari?:{dispari}");

            bool positivo = Matematica.Positivo(a);
            Console.WriteLine($"{a} è un numero positivo?:{positivo}");

            bool negativo = Matematica.Negativo(a);
            Console.WriteLine($"{a} è un numero negativo?:{negativo}");

            bool intero = Matematica.Intero(a);
            Console.WriteLine($"{a} è un numero intero?:{intero}");
        }
    }
}
