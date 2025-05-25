using System;
using System.Collections.Generic;

/// <summary>
/// Kelas untuk melakukan operasi penjumlahan tiga angka bertipe generik.
/// </summary>
class AdditionCalculator
{
    /// <summary>
    /// Menjumlahkan tiga nilai bertipe generic (menggunakan dynamic).
    /// </summary>
    /// <typeparam name="T">Tipe data numerik (int, float, double, long, dll).</typeparam>
    /// <param name="a">Angka pertama.</param>
    /// <param name="b">Angka kedua.</param>
    /// <param name="c">Angka ketiga.</param>
    /// <returns>Hasil penjumlahan dari ketiga angka.</returns>
    public T AddThreeNumbers<T>(T a, T b, T c) where T : struct
    {
        dynamic x = a, y = b, z = c;
        return x + y + z;
    }
}

/// <summary>
/// Kelas database sederhana untuk menyimpan data generik bersama waktu inputnya.
/// </summary>
/// <typeparam name="T">Tipe data yang akan disimpan.</typeparam>
class SimpleDataBase<T>
{
    private List<T> storedData = new(); // Menyimpan data yang diinput
    private List<DateTime> inputDates = new(); // Menyimpan waktu UTC saat data diinput

    /// <summary>
    /// Menambahkan data baru ke database.
    /// </summary>
    /// <param name="data">Data yang ingin disimpan.</param>
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow); // Waktu input disimpan dalam format UTC
    }

    /// <summary>
    /// Menampilkan seluruh data beserta waktu penyimpanan.
    /// </summary>
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, disimpan pada: {inputDates[i]} UTC");
        }
    }
}

/// <summary>
/// Program utama untuk membaca NIM, memproses angka, menjumlahkan, dan menyimpan ke database.
/// </summary>
class Program
{
    static void Main()
    {
        // Meminta input NIM dari pengguna
        Console.Write("Masukkan NIM Anda: ");
        string nim = Console.ReadLine();
        char lastDigit = nim[^1]; // Mengambil digit terakhir dari NIM

        // Memisahkan NIM menjadi tiga bagian dua digit
        string part1 = nim[..2];
        string part2 = nim.Substring(2, 2);
        string part3 = nim.Substring(4, 2);

        // Mendeklarasikan tiga angka dengan tipe dinamis
        dynamic num1, num2, num3;

        // Menentukan tipe data berdasarkan digit terakhir NIM
        (num1, num2, num3) = lastDigit switch
        {
            '1' or '2' => (float.Parse(part1), float.Parse(part2), float.Parse(part3)),
            '3' or '4' or '5' => (double.Parse(part1), double.Parse(part2), double.Parse(part3)),
            '6' or '7' or '8' => (int.Parse(part1), int.Parse(part2), int.Parse(part3)),
            '9' or '0' => (long.Parse(part1), long.Parse(part2), long.Parse(part3)),
            _ => throw new Exception("Digit terakhir NIM tidak valid.") // Error jika digit tidak valid
        };

        // Menghitung hasil penjumlahan
        var calculator = new AdditionCalculator();
        var result = calculator.AddThreeNumbers(num1, num2, num3);
        Console.WriteLine($"Hasil penjumlahan: {result}");

        // Menyimpan ketiga angka ke dalam database dan mencetak semua data
        var db = new SimpleDataBase<dynamic>();
        db.AddNewData(num1);
        db.AddNewData(num2);
        db.AddNewData(num3);
        db.PrintAllData();
    }
}
