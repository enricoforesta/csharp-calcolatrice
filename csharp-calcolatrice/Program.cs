namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"La somma è {Calcolatrice.Somma(21, 32)}");
            Console.WriteLine($"La somma è {Calcolatrice.Somma(15.55, 0.15)}");
            Console.WriteLine($"La differenza è {Calcolatrice.Differenza(21, 32)}");
            Console.WriteLine($"La differenza è {Calcolatrice.Differenza(15.55, 0.15)}");
            Console.WriteLine($"Il valore assoluto è {Calcolatrice.ValoreAssoluto(-21)}");
            Console.WriteLine($"Il valore assoluto è {Calcolatrice.ValoreAssoluto(-15.55)}");
            Console.WriteLine($"Il numero più piccolo è {Calcolatrice.MinimoNumeri(21, 32)}");
            Console.WriteLine($"Il numero più piccolo è {Calcolatrice.MinimoNumeri(15.55, 0.15)}");
            Console.WriteLine($"Il numero più grande è {Calcolatrice.MassimoNumeri(21, 32)}");
            Console.WriteLine($"Il numero più grande è {Calcolatrice.MassimoNumeri(15.55, 0.15)}");
            Console.WriteLine($"la potenza è {Calcolatrice.ElevatoPotenza(100, -2)}");
        }
    }
}
