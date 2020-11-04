using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Operazioni_Matematiche
{
    class Matematica
    {
        public static int Somma(int a,int b)
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
        public static long Potenza(int a,int b)
        {
            
             for (int cont=0 ; cont>b; cont++)
            {
                
                return a * a;
            }
        }
             
    }
}
