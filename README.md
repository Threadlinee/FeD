# 🔐 File Encryptor & Decryptor (C#)

A simple and lightweight console application for encrypting and decrypting any type of file using XOR encryption. Built in C# for easy cross-platform use on Windows and Linux.

---

## ✨ Features

- 🔁 **Encrypt & Decrypt** any file format (ZIP, PDF, DOCX, images, etc.)
- 🧠 **Symmetric XOR encryption** (same key used for encryption & decryption)
- 🧩 Works with both **binary** and **text** files
- 📦 Minimal dependencies, easy to run
- ✅ Includes input validation for file paths and keys
- 🖥️ Cross-platform: Windows & Linux supported

---

## 🚀 How It Works

This tool applies a basic XOR cipher to encrypt and decrypt the contents of a file byte-by-byte.

- Encryption simply XORs each byte with a key (0–255)
- Decryption is identical (XOR is reversible)
- Encrypted files are saved with `.encrypted` appended
- Decrypted files are saved with `.decrypted` appended

---

## 🛠 How to Run

### 🪟 On Windows

1. Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
2. Open **CMD** or **PowerShell**.
3. Navigate to the folder where the `.cs` file is saved.
4. Run:

```bash
dotnet new console -o FileEncryptorApp
cd FileEncryptorApp
# Replace Program.cs with the provided one
copy ..\Program.cs .\Program.cs
dotnet run
🐧 On Linux
Install the .NET SDK via terminal (if not installed):

bash
Copy
Edit
sudo apt update
sudo apt install dotnet-sdk-7.0
Open terminal and run:

bash
Copy
Edit
dotnet new console -o FileEncryptorApp
cd FileEncryptorApp
# Replace Program.cs with the provided one
mv ../Program.cs ./Program.cs
dotnet run
🧪 Example
bash
Copy
Edit
Enter the path of the file to encrypt: C:\Users\yourname\Desktop\myfile.zip
Enter the encryption key (numeric value between 0 and 255): 123

# => Output:
File encrypted successfully. Processed file: C:\Users\yourname\Desktop\myfile.zip.encrypted
To decrypt:

Run the tool again

Select "decrypt"

Use the same key

Get the .decrypted version of the file

📁 File Output
Action	Input Filename	Output Filename
Encrypt	file.txt	file.txt.encrypted
Decrypt	file.txt.encrypted	file.txt.encrypted.decrypted
⚠️ Disclaimer
This is a basic encryption tool and should not be used for securing highly sensitive data in production. XOR encryption is not secure against reverse engineering or advanced attacks.

📄 License
This project is open-source and available under the MIT License. Contributions are welcome!

❤️ Author
Made with love by @dionabazi

yaml
Copy
Edit

---

Let me know if you'd like a LICENSE file included, or if you want this turned into a GitHub release-ready project (with solution files, .csproj, etc.).
