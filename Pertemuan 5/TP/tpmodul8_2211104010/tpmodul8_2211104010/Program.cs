using System;

class Program
{
    static void Main()
    {
        CovidConfig config = CovidConfig.LoadConfig();

        // Panggil method ubah satuan
        config.UbahSatuan();
        Console.WriteLine($"Satuan suhu sekarang: {config.satuan_suhu}");

        // Input suhu
        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        if (!double.TryParse(Console.ReadLine(), out double suhu))
        {
            Console.WriteLine("Input suhu tidak valid!");
            return;
        }

        // Input hari demam
        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        if (!int.TryParse(Console.ReadLine(), out int hariDemam))
        {
            Console.WriteLine("Input hari tidak valid!");
            return;
        }

        // Cek suhu sesuai dengan satuan
        bool suhuValid = false;
        if (config.satuan_suhu == "celcius")
        {
            suhuValid = suhu >= 36.5 && suhu <= 37.5;
        }
        else if (config.satuan_suhu == "fahrenheit")
        {
            suhuValid = suhu >= 97.7 && suhu <= 99.5;
        }

        bool hariValid = hariDemam < config.batas_hari_deman;

        if (suhuValid && hariValid)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }
    }
}
