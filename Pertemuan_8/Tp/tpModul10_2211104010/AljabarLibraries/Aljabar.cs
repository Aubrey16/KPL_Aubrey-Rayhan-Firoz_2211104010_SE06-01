using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                throw new Exception("Tidak memiliki akar real.");
            }

            double sqrtDisc = Math.Sqrt(discriminant);
            double x1 = (-b + sqrtDisc) / (2 * a);
            double x2 = (-b - sqrtDisc) / (2 * a);

            return new double[] { x1, x2 };
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double hasilA = a * a;
            double hasilB = 2 * a * b;
            double hasilC = b * b;

            return new double[] { hasilA, hasilB, hasilC };
        }
    }
}
