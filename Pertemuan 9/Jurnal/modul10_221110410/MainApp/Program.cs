using System;
using MatematikaLibraries;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematika mtk = new Matematika();

            Console.WriteLine("FPB(60, 45): " + mtk.FPB(60, 45));
            Console.WriteLine("KPK(12, 8): " + mtk.KPK(12, 8));

            int[] fungsi1 = { 1, 4, -12, 9 };
            Console.WriteLine("Turunan(x^3 + 4x^2 - 12x + 9): " + mtk.Turunan(fungsi1));

            int[] fungsi2 = { 4, 6, -12, 9 };
            Console.WriteLine("Integral(4x^3 + 6x^2 - 12x + 9): " + mtk.Integral(fungsi2));
        }
    }
}
