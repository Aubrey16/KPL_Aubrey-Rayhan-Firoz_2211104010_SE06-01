using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

public static class UserService
{
    private static readonly string filePath = "users.json";

    public static List<User> LoadUsers()
    {
        if (!File.Exists(filePath)) return new List<User>();
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
    }

    public static void SaveUsers(List<User> users)
    {
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public static string HashPassword(string password)
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }

    public static bool Register(string username, string password, out string message)
    {
        var users = LoadUsers();

        // Validasi panjang dan karakter
        if (username.Length < 4 || username.Length > 20 || !username.All(char.IsLetterOrDigit))
        {
            message = "Username harus 4-20 karakter dan hanya huruf/angka.";
            return false;
        }

        if (password.Length < 8 || password.Length > 20 ||
            !password.Any(char.IsDigit) ||
            !password.Any("!@#$%^&*".Contains) ||
            password.ToLower().Contains(username.ToLower()))
        {
            message = "Password harus 8-20 karakter, mengandung angka & simbol (!@#$%^&*), dan tidak boleh mengandung username.";
            return false;
        }

        if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
        {
            message = "Username sudah digunakan.";
            return false;
        }

        users.Add(new User { Username = username, PasswordHash = HashPassword(password) });
        SaveUsers(users);
        message = "Registrasi berhasil.";
        return true;
    }

    public static bool Login(string username, string password)
    {
        var users = LoadUsers();
        string hash = HashPassword(password);
        return users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.PasswordHash == hash);
    }
}
