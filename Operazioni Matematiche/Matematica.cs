using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Operazioni_Matematiche
{
    class Matematica
    {
        public static int Somma(int a, int b)
        {

            return a + b;
        }
        public static Double SommaDouble(double a, double b)
        {
            return a + b;
        }
        public static Double Sottrazione(double a, double b)
        {
            return a - b;
        }
        public static Double Moltiplicazione(double a, double b)
        {
            return a * b;
        }
        public static double Divisione(double a, double b)
        {
            return a / b;
        }
        public static long Elevato(int a, int b)
        {

            for (int cont = 0; cont > b; cont++)

                return a * a;
            return a * a;
        }


        public static int Minore(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public static int Maggiore(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public static double Inverso(double a)
        {
            return -1 * a;
        }
        public static bool Pari(int a)
        {
            
            if (a % 2 == 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Dispari(int a)
        {
            if (a % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool Positivo(int a)
        {
            if (a >= 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static bool Negativo(int a)
        {
            if (a < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Intero(double a)
        {
                return true;
        }

        


        

            
        
    }
}
