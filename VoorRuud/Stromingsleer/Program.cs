using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace Stromingsleer
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamingForNerds();
            //StreamingForDeModerneMens();
            DecoratorDemo();
        }

        private static void DecoratorDemo()
        {
            SchrijfCryptisch();
            LeesCryptisch();
        }

        private static void LeesCryptisch()
        {
            AesManaged aes = new AesManaged();
            aes.Key = key;
            aes.IV = iv;

            using (FileStream fs = File.OpenRead(@"D:\log.crt"))
            {
                using (CryptoStream crypt = new CryptoStream(fs, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (GZipStream xip = new GZipStream(crypt, CompressionMode.Decompress))
                    using (StreamReader rdr = new StreamReader(xip))
                    {
                        string line;
                        while ((line = rdr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
        }

        static byte[] key;
        static byte[] iv;
        private static void SchrijfCryptisch()
        {
            AesManaged aes = new AesManaged();
            key = aes.Key;
            iv = aes.IV;

            string text = "Hello World";
            using (FileStream fs = File.Create(@"D:\log.crt"))
            {
                using (CryptoStream crypt = new CryptoStream(fs, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using(GZipStream xip = new GZipStream(crypt, CompressionMode.Compress))
                    using (StreamWriter wr = new StreamWriter(xip))
                    {
                        for (int i = 0; i < 1000; i++)
                        {
                            wr.WriteLine($"{text} {i}");
                        }
                    }
                }
            }
        }

        private static void StreamingForDeModerneMens()
        {
            //ModernSchrijven();
            ModernLezen();
        }

        private static void ModernLezen()
        {
            using (FileStream fs = File.OpenRead(@"D:\log2.txt"))
            {
                using (StreamReader rdr = new StreamReader(fs))
                {
                    string line;
                    while ((line = rdr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        private static void ModernSchrijven()
        {
            string text = "Hello World";
            using (FileStream fs = File.Create(@"D:\log2.txt"))
            {
                using (StreamWriter wr = new StreamWriter(fs))
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        wr.WriteLine($"{text} {i}");
                    }
                }
            }
        }
        private static void StreamingForNerds()
        {
            //NerdSchrijft();
            NerdLeest();

        }

        private static void NerdLeest()
        {
            using (FileStream fs = File.OpenRead(@"D:\log.txt"))
            {
                byte[] buffer = new byte[100];

                int nrRead;
                do
                {
                    Array.Clear(buffer, 0, buffer.Length);
                    nrRead = fs.Read(buffer, 0, buffer.Length);

                    string text = Encoding.UTF8.GetString(buffer);
                    Console.Write(text);
                }
                while (nrRead > 0);
            }
        }

        private static void NerdSchrijft()
        {
            string text = "Hello World";
            using (FileStream fs = File.Create(@"D:\log.txt"))
            {
                for (int i = 0; i < 1000; i++)
                {
                    byte[] buffer = Encoding.UTF8.GetBytes($"{text}  {i}\r\n");
                    fs.Write(buffer);
                }
            }
        }
    }
}
