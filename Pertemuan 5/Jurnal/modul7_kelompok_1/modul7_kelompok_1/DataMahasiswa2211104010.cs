using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jurnal7
{
    public class DataMahasiswa2211104010
    {
        // Class model JSON
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_2211104010.json";

            try
            {
                string jsonContent = File.ReadAllText(filePath);
                Mahasiswa mhs = JsonConvert.DeserializeObject<Mahasiswa>(jsonContent);

                Console.WriteLine("=== Data Mahasiswa ===");
                Console.WriteLine($"Nama      : {mhs.firstName} {mhs.lastName}");
                Console.WriteLine($"Gender    : {mhs.gender}");
                Console.WriteLine($"Usia      : {mhs.age}");
                Console.WriteLine("Alamat    : ");
                Console.WriteLine($"  Jalan   : {mhs.address.streetAddress}");
                Console.WriteLine($"  Kota    : {mhs.address.city}");
                Console.WriteLine($"  Provinsi: {mhs.address.state}");
                Console.WriteLine("Mata Kuliah:");
                foreach (var course in mhs.courses)
                {
                    Console.WriteLine($"  {course.code} - {course.name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal membaca file JSON:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
