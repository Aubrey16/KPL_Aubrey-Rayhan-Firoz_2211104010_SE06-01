using System;

class Program
{
    static void Main()
    {
        var config = BankTransferConfig.LoadConfig();

        Console.WriteLine(config.lang == "en" 
            ? "Please insert the amount of money to transfer:" 
            : "Masukkan jumlah uang yang akan di-transfer:");
        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        Console.WriteLine(config.lang == "en"
            ? $"Transfer fee = {fee}\nTotal amount = {total}"
            : $"Biaya transfer = {fee}\nTotal biaya = {total}");

        Console.WriteLine(config.lang == "en"
            ? "Select transfer method:"
            : "Pilih metode transfer:");

        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.ReadLine(); // input pilihan transfer (tidak dipakai)

        Console.WriteLine(config.lang == "en"
            ? $"Please type \"{config.confirmation.en}\" to confirm the transaction:"
            : $"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:");

        string confirmationInput = Console.ReadLine();

        if ((config.lang == "en" && confirmationInput == config.confirmation.en) ||
            (config.lang == "id" && confirmationInput == config.confirmation.id))
        {
            Console.WriteLine(config.lang == "en"
                ? "The transfer is completed"
                : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(config.lang == "en"
                ? "Transfer is cancelled"
                : "Transfer dibatalkan");
        }
    }
}
