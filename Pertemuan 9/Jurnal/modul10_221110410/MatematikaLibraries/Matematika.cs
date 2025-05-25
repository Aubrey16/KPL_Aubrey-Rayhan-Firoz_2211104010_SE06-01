using System;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public string Turunan(int[] koefisien)
        {
            string hasil = "";
            int derajat = koefisien.Length - 1;

            for (int i = 0; i < koefisien.Length - 1; i++)
            {
                int koef = koefisien[i] * (derajat - i);
                int pangkat = derajat - i - 1;

                if (koef == 0) continue;

                if (hasil.Length > 0 && koef > 0) hasil += " + ";
                else if (koef < 0) hasil += " - ";

                hasil += Math.Abs(koef);
                if (pangkat > 0)
                {
                    hasil += "x";
                    if (pangkat > 1)
                        hasil += pangkat;
                }
            }

            return hasil;
        }

        public string Integral(int[] koefisien)
        {
            string hasil = "";
            int derajat = koefisien.Length;

            for (int i = 0; i < koefisien.Length; i++)
            {
                int pangkatBaru = derajat - i;
                double koefBaru = (double)koefisien[i] / pangkatBaru;

                if (hasil.Length > 0 && koefBaru > 0) hasil += " + ";
                else if (koefBaru < 0) hasil += " - ";

                hasil += Math.Abs(koefBaru).ToString("G"); // G = General format
                hasil += "x";
                if (pangkatBaru > 1)
                    hasil += pangkatBaru;
            }

            hasil += " + C";
            return hasil;
        }
    }
}
