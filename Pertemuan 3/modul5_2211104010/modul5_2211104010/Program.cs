using System;
using System.Collections.Generic;

class Penjumlahan
{
    public T JumlahTigaAngka<T>(T a, T b, T c) where T : struct
    {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        return x + y + z;
    }
}


class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}


class Program
{
    static void Main()
    {
        Console.Write("Masukkan NIM Anda: ");
        string nim = Console.ReadLine();
        char lastDigit = nim[nim.Length - 1];


        dynamic num1, num2, num3;
        string part1 = nim.Substring(0, 2);
        string part2 = nim.Substring(2, 2);
        string part3 = nim.Substring(4, 2);

        switch (lastDigit)
        {
            case '1':
            case '2':
                num1 = float.Parse(part1);
                num2 = float.Parse(part2);
                num3 = float.Parse(part3);
                break;
            case '3':
            case '4':
            case '5':
                num1 = double.Parse(part1);
                num2 = double.Parse(part2);
                num3 = double.Parse(part3);
                break;
            case '6':
            case '7':
            case '8':
                num1 = int.Parse(part1);
                num2 = int.Parse(part2);
                num3 = int.Parse(part3);
                break;
            case '9':
            case '0':
                num1 = long.Parse(part1);
                num2 = long.Parse(part2);
                num3 = long.Parse(part3);
                break;
            default:
                throw new Exception("Digit terakhir NIM tidak valid.");
        }


        Penjumlahan penjumlahan = new Penjumlahan();
        var hasil = penjumlahan.JumlahTigaAngka(num1, num2, num3);
        Console.WriteLine($"Hasil penjumlahan: {hasil}");


        SimpleDataBase<dynamic> database = new SimpleDataBase<dynamic>();
        database.AddNewData(num1);
        database.AddNewData(num2);
        database.AddNewData(num3);
        database.PrintAllData();
    }
}
