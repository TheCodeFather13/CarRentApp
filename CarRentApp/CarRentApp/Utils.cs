using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp
{
     public static class Utils
    {
        public static bool  FormIsOpen(string name)
        {
            // Check if window is already open
            var openForms = Application.OpenForms.Cast<Form>();
            var isOpen = openForms.Any(x => x.Name == name);
            return isOpen;
        }

        public static string HashPassword(string password)
        {
            // Read info about criptografy
            SHA256 sHA256 = SHA256.Create();
            // Convert string to byte array and compute hash
            byte[] data = sHA256.ComputeHash(Encoding.UTF8.GetBytes(password));
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }

        public static string DefaultHashPassword()
        {
            var defaultHash = HashPassword("qwerty");
            return defaultHash;
        }



    }
}
