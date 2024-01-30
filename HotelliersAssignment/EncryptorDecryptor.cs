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

        public static List<string> DecryptFileToString(string inputFile, string password)
        {
            List<string> decryptedLines = new List<string>();
            try
            {
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
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            decryptedLines.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Decryption failed: {ex.Message}");
            }
            return decryptedLines;
        }

        public static void DecryptAndEncryptFile(string encryptedFile, string plainText, string password)
        {
            string decryptedText;
            try
            {
                byte[] key = new Rfc2898DeriveBytes(password, testSalt, 10000).GetBytes(256 / 8);
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = testSalt;

                    using (var decryptor = aesAlg.CreateDecryptor())
                    using (var inputStream = File.OpenRead(encryptedFile))
                    using (var outputStream = new MemoryStream())
                    using (var cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                    {
                        cryptoStream.CopyTo(outputStream);
                        decryptedText = Encoding.UTF8.GetString(outputStream.ToArray());

                        // Now, you have the decrypted text in 'decryptedText'.
                        // You can perform any operations on the decrypted text here.

                        // For demonstration, let's encrypt the decrypted text again and write it back to the same file.
                    }
                    EncryptStringsToFile(encryptedFile, password, decryptedText, plainText);
                }
                Console.WriteLine("Decryption and encryption successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Decryption and encryption failed: {ex.Message}");
            }
        }
        private static void EncryptStringsToFile(string outputFile, string password, params string[] data)
        {
            try
            {
                byte[] key = new Rfc2898DeriveBytes(password, testSalt, 10000).GetBytes(256 / 8);
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = testSalt;

                    using (var encryptor = aesAlg.CreateEncryptor())
                    {
                        using (var outputStream = File.Open(outputFile, FileMode.Create, FileAccess.Write))
                        using (var cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(cryptoStream))
                        {
                            foreach (string str in data)
                            {
                                swEncrypt.WriteLine(str); // Write the encrypted string
                                swEncrypt.Write("\r\n");     // Write a newline character
                            }
                        }
                    }
                }
                Console.WriteLine("Encryption successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Encryption failed: {ex.Message}");
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
            try
            {
                List<string> decryptedLines = DecryptFileToString(inputFile, password);
                List<string> splitContent = new List<string>();

                foreach (string line in decryptedLines)
                {
                    splitContent.AddRange(line.Split(','));
                }

                return splitContent.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Decryption and split failed: {ex.Message}");
                return null;
            }
        }



    }
}
