using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat dua instance Singleton
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // Tambahkan nama anggota dan asisten di data1
        data1.AddSebuahData("Andi");
        data1.AddSebuahData("Budi");
        data1.AddSebuahData("Cici");
        data1.AddSebuahData("Asisten: Dimas");

        Console.WriteLine("\n--- Data2 Print (Harusnya sama dengan data1) ---");
        data2.PrintSemuaData();

        // Hapus data asisten di data2 (index terakhir, misal 3)
        data2.HapusSebuahData(3);

        Console.WriteLine("\n--- Data1 Print Setelah Hapus ---");
        data1.PrintSemuaData();

        // Print jumlah elemen di data1 dan data2
        Console.WriteLine($"\nJumlah data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data2: {data2.GetSemuaData().Count}");
    }
}
