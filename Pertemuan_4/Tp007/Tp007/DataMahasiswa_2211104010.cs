using System;
using System.IO;
using System.Text.Json;

class DataMahasiswa_2211104010
{
    public void ReadJSON()
    {
        string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tp7_1_2211104010.json");
        string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tp7_2_2211104010.json");


        if (!File.Exists(path1) || !File.Exists(path2))
        {
            Console.WriteLine("Salah satu file JSON tidak ditemukan di " + Directory.GetCurrentDirectory());
        }

        try
        {

            string json1 = File.ReadAllText(path1);
            string json2 = File.ReadAllText(path2);


            var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json1);
            var matkul = JsonSerializer.Deserialize<MataKuliah>(json2);

            if (mahasiswa == null || matkul == null)
            {
                Console.WriteLine("Gagal membaca JSON.");
                return;
            }


            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
            

            Console.WriteLine("\nDaftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in matkul.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saat membaca JSON: {ex.Message}");
        }
    }
}


class Mahasiswa
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }
}

class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}


class MataKuliah
{
    public Course[] courses { get; set; }
}

class Course
{
    public string code { get; set; }
    public string name { get; set; }
}
