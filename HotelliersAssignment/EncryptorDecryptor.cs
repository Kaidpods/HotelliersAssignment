using HotelliersAssignment.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelliersAssignment
{
    public class FileEncryptor
    {
        static byte[] testSalt = Resources.test;
        public static void EncryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] key = new Rfc2898DeriveBytes(password, testSalt, 10000).GetBytes(256 / 8);

                using (var aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = testSalt;

                    using (var encryptor = aesAlg.CreateEncryptor())
                    using (var inputStream = File.OpenRead(inputFile))
                    using (var outputStream = File.OpenWrite(outputFile))
                    using (var cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                    {
                        inputStream.CopyTo(cryptoStream);
                    }
                }
                Console.WriteLine("Encryption successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Encryption failed: {ex.Message}");
            }
        }

        public static string DecryptFileToString(string inputFile, string password)
        {
            try
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] key = new Rfc2898DeriveBytes(password, testSalt, 10000).GetBytes(256 / 8);

                using (var aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = testSalt;

                    using (var decryptor = aesAlg.CreateDecryptor())
                    using (var inputStream = File.OpenRead(inputFile))
                    using (var cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                    using (var streamReader = new StreamReader(cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Decryption failed: {ex.Message}");
                return null;
            }
        }

        private static byte[] GenerateRandomSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
        public static void GenerateSaltToFile(string outputFile)
        {
            try
            {
                byte[] salt = GenerateRandomSalt();
                File.WriteAllBytes(outputFile, salt);
                Console.WriteLine("Salt generated and saved to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating and saving salt: {ex.Message}");
            }
        }
        public static byte[] ReadSaltFromFile(string inputFile)
        {
            try
            {
                byte[] salt = File.ReadAllBytes(inputFile);
                Console.WriteLine("Salt read from file successfully.");
                return salt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading salt from file: {ex.Message}");
                return null;
            }
        }

        public static string[] DecryptFileAndSplit(string inputFile, string password)
        {
            string decryptedContent = DecryptFileToString(inputFile, password);
            return decryptedContent.Split(',');
        }

        
        
    }
}
