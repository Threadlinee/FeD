using System;
using System.IO;

namespace FileEncryptor
{
    class Program
    {
        static void DisplayBanner()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
███████╗██╗██╗     ███████╗    ███████╗███╗   ██╗ ██████╗██████╗ ██╗   ██╗██████╗ ████████╗███████╗██████╗ 
██╔════╝██║██║     ██╔════╝    ██╔════╝████╗  ██║██╔════╝██╔══██╗╚██╗ ██╔╝██╔══██╗╚══██╔══╝██╔════╝██╔══██╗
█████╗  ██║██║     █████╗      █████╗  ██╔██╗ ██║██║     ██████╔╝ ╚████╔╝ ██████╔╝   ██║   █████╗  ██████╔╝
██╔══╝  ██║██║     ██╔══╝      ██╔══╝  ██║╚██╗██║██║     ██╔══██╗  ╚██╔╝  ██╔═══╝    ██║   ██╔══╝  ██╔══██╗
██║     ██║███████╗███████╗    ███████╗██║ ╚████║╚██████╗██║  ██║   ██║   ██║        ██║   ███████╗██║  ██║
╚═╝     ╚═╝╚══════╝╚══════╝    ╚══════╝╚═╝  ╚═══╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝        ╚═╝   ╚══════╝╚═╝  ╚═╝
                                                                                                           
███████╗██╗██╗     ███████╗    ██████╗ ███████╗ ██████╗██████╗ ██╗   ██╗██████╗ ████████╗███████╗██████╗   
██╔════╝██║██║     ██╔════╝    ██╔══██╗██╔════╝██╔════╝██╔══██╗╚██╗ ██╔╝██╔══██╗╚══██╔══╝██╔════╝██╔══██╗  
█████╗  ██║██║     █████╗      ██║  ██║█████╗  ██║     ██████╔╝ ╚████╔╝ ██████╔╝   ██║   █████╗  ██████╔╝  
██╔══╝  ██║██║     ██╔══╝      ██║  ██║██╔══╝  ██║     ██╔══██╗  ╚██╔╝  ██╔═══╝    ██║   ██╔══╝  ██╔══██╗  
██║     ██║███████╗███████╗    ██████╔╝███████╗╚██████╗██║  ██║   ██║   ██║        ██║   ███████╗██║  ██║  
╚═╝     ╚═╝╚══════╝╚══════╝    ╚═════╝ ╚══════╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝        ╚═╝   ╚══════╝╚═╝  ╚═╝  
                                                                                                                          
               File Encrypter  - Add discord: snoglide540
");
        }

        static byte[] EncryptDecrypt(byte[] data, byte key)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(data[i] ^ key);
            }
            return result;
        }

        static string GetFilePath(string action)
        {
            string filePath;
            while (true)
            {
                Console.Write($"\nEnter the path of the file to {action}: ");
                filePath = Console.ReadLine();

                if (File.Exists(filePath))
                {
                    return filePath;
                }
                else
                {
                    Console.WriteLine("File not found, please try again.");
                }
            }
        }

        // Get the encryption/decryption key (numeric value within valid range)
        static byte GetEncryptionKey()
        {
            byte key;
            while (true)
            {
                Console.Write("\nEnter the encryption key (numeric value between 0 and 255): ");
                string input = Console.ReadLine();

                // Validate if input is a valid number and within the byte range
                if (byte.TryParse(input, out key) && key >= 0 && key <= 255)
                {
                    return key;
                }
                else
                {
                    Console.WriteLine("Invalid key. Please enter a numeric value between 0 and 255.");
                }
            }
        }

        static void ProcessFile(string action)
        {
            string filePath = GetFilePath(action);

            byte key = GetEncryptionKey();

            byte[] fileBytes = File.ReadAllBytes(filePath);

            byte[] processedBytes = EncryptDecrypt(fileBytes, key);

            string processedFilePath = filePath + (action == "encrypt" ? ".encrypted" : ".decrypted");

            File.WriteAllBytes(processedFilePath, processedBytes);

            Console.WriteLine($"\nFile {action}ed successfully. Processed file: {processedFilePath}");
        }

        static void Main(string[] args)
        {
            DisplayBanner();

            Console.WriteLine("\nWould you like to (e)ncrypt or (d)ecrypt a file?");
            string choice = Console.ReadLine().ToLower();

            if (choice == "e")
            {
                ProcessFile("encrypt");
            }
            else if (choice == "d")
            {
                ProcessFile("decrypt");
            }
            else
            {
                Console.WriteLine("Invalid choice! Please restart the program and choose 'e' for encrypt or 'd' for decrypt.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
