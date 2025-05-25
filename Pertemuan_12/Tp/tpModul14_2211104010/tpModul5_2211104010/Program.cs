using System;

namespace TpModul14
{
    /// <summary>
    /// Kelas untuk menyapa user dengan generic.
    /// </summary>
    public class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    /// <summary>
    /// Kelas generic untuk menyimpan dan menampilkan data.
    /// </summary>
    /// <typeparam name="T">Tipe data generic.</typeparam>
    public class DataGeneric<T>
    {
        private T _data;

        public DataGeneric(T data)
        {
            _data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {_data}");
        }
    }

    /// <summary>
    /// Kelas utama untuk menjalankan program.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            var halo = new HaloGeneric();
            halo.SapaUser("Aubrey");

            var data = new DataGeneric<string>("2211104010");
            data.PrintData();
        }
    }
}
