namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calcolatrice.Somma(21, 32));
            Console.WriteLine(Calcolatrice.Somma(15.55, 0.15));
            Console.WriteLine(Calcolatrice.Differenza(21, 32));
            Console.WriteLine(Calcolatrice.Differenza(15.55, 0.15));
           // Console.WriteLine(Calcolatrice.ValoreAssoluto(-21));
            //Console.WriteLine(Calcolatrice.ValoreAssoluto(-15.55));
            Console.WriteLine(Calcolatrice.MinimoNumeri(21, 32));
            Console.WriteLine(Calcolatrice.MinimoNumeri(15.55, 0.15));
            Console.WriteLine(Calcolatrice.MassimoNumeri(21, 32));
            Console.WriteLine(Calcolatrice.MassimoNumeri(15.55, 0.15));
          //  Console.WriteLine($" la potenza è {Calcolatrice.ElevatoPotenza(2, -5)}");
        }
    }
}
