using System;
using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    private const string configFile = "covid_config.json";

    // Nilai default jika file belum ada
    private static readonly CovidConfig defaultConfig = new CovidConfig
    {
        satuan_suhu = "celcius",
        batas_hari_deman = 14,
        pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini",
        pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini"
    };

    public static CovidConfig LoadConfig()
    {
        if (File.Exists(configFile))
        {
            string json = File.ReadAllText(configFile);
            return JsonSerializer.Deserialize<CovidConfig>(json);
        }
        else
        {
            SaveConfig(defaultConfig);
            return defaultConfig;
        }
    }

    public static void SaveConfig(CovidConfig config)
    {
        string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(configFile, json);
    }

    public void UbahSatuan()
    {
        satuan_suhu = satuan_suhu == "celcius" ? "fahrenheit" : "celcius";
        SaveConfig(this);
    }
}
