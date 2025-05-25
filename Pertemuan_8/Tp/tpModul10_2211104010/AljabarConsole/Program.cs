using System;
using AljabarLibraries;

namespace AljabarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] persamaanKuadrat = { 1, -3, -10 };
            double[] akar = Aljabar.AkarPersamaanKuadrat(persamaanKuadrat);
            Console.WriteLine($"Akar-akar persamaan: {akar[0]}, {akar[1]}");

            double[] persamaanLinear = { 2, -3 };
            double[] hasilKuadrat = Aljabar.HasilKuadrat(persamaanLinear);
            Console.WriteLine($"Hasil kuadrat: {hasilKuadrat[0]}x^2 + {hasilKuadrat[1]}x + {hasilKuadrat[2]}");
        }
    }
}
