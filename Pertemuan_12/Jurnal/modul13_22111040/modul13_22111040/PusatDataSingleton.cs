using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
    private static PusatDataSingleton _instance;
    private List<string> DataTersimpan;

    // Konstruktor private
    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    // Method untuk mengakses instance
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }
        return _instance;
    }

    // Mendapatkan semua data
    public List<string> GetSemuaData()
    {
        return DataTersimpan;
    }

    // Mencetak semua data
    public void PrintSemuaData()
    {
        if (DataTersimpan.Count == 0)
        {
            Console.WriteLine("Tidak ada data.");
            return;
        }

        foreach (string data in DataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    // Menambahkan sebuah data
    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    // Menghapus data berdasarkan index
    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Index tidak valid.");
        }
    }
}
