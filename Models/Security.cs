using System.Text;
using System.Security.Cryptography;
namespace Expense_Management.Models
{
    public class Security
    {


        public static string ComputeSHA256Hash(string rawData)
        {
            // SHA256 nesnesini oluştur
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Veriyi byte dizisine dönüştür
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Hash değerini string olarak formatla
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

            {
                string Password = Password;
                string hashedData = ComputeSHA256Hash(Password);
                Console.WriteLine($"Metin: {Password}");
                Console.WriteLine($"Şifrelenmiş Metin: {Password}");
            }

        }
        public ICollection<User> Users { get; set; } = new HashSet<User>();

    }

}
