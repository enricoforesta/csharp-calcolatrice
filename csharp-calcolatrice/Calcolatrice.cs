﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class Calcolatrice
    {
        public static int Somma(int numero1, int numero2) { return numero1 + numero2; }

        public static double Somma (double numero1, double numero2) {  return numero1 + numero2; }

        public static int Differenza (int numero1, int numero2) { return numero1 - numero2; }

        public static double Differenza(double numero1, double numero2) { return numero1 - numero2; }

        public static int ValoreAssoluto(int numero1)
        {
            if (numero1 < 0) return numero1 * -1; 
            return numero1;
        }
        public static double ValoreAssoluto(double numero1)
        {
            if (numero1 < 0) return numero1 * -1; 
            return numero1;
        }
        
        public static int MinimoNumeri(int numero1, int numero2)
        {
            if (numero1 > numero2) return numero2;
            if (numero1 < numero2) return numero1;
            return numero1;
        }
        public static double MinimoNumeri(double numero1, double numero2)
        {
            if (numero1 > numero2) return numero2;
            if (numero1 < numero2) return numero1;
            return numero1;
        }

        public static int MassimoNumeri(int numero1, int numero2)
        {
            if (numero1 > numero2) return numero1;
            if (numero1 < numero2) return numero2;
            return numero1;
        }
        public static double MassimoNumeri(double numero1, double numero2)
        {
            if (numero1 > numero2) return numero1;
            if (numero1 < numero2) return numero2;
            return numero1;
        }

        public static int ElevatoPotenza(int baseNumero, int esponenteNumero)
        {
            if ((baseNumero == 0 && esponenteNumero == 0) || esponenteNumero == 0)
                return 1;

            if (esponenteNumero < 0)
            {
                int resultAssoluto = ValoreAssoluto(esponenteNumero);
                return ElevatoPotenza(baseNumero, resultAssoluto);
            }

            int result = 1;
            for (int i = 0; i < esponenteNumero; i++)
            {
                result *= baseNumero;
            }
            return result;
        }
    }
}
// uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? 
// Il principio di Polimorfismo , dove possiamo chiamare un metodo con lo stesso nome , ma con argomenti diversi.