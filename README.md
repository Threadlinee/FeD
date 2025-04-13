# 🔐 File Encryptor & Decryptor (C#)

A simple and fast console tool to encrypt and decrypt **any kind of file** using XOR byte encryption. Perfect for basic obfuscation or fun file-locking projects. Works on **Windows** and **Linux**.

---

## ✨ Features

- 🔒 Encrypts **any file type** (ZIP, PDF, EXE, TXT, JPG, etc.)
- 🔁 Reversible XOR cipher encryption
- ✅ Input validation for file path and key
- 📂 Saves output as `.encrypted` or `.decrypted`
- 🧠 One key does both encryption & decryption
- 💻 Runs on Windows and Linux

---

## ⚙️ How It Works

This tool uses a **symmetric XOR algorithm**:
- XORs each byte of the file with a numeric key (0–255)
- XORing the same file twice with the same key restores the original

| Operation | Input File             | Output File                     |
|-----------|------------------------|----------------------------------|
| Encrypt   | `example.zip`          | `example.zip.encrypted`          |
| Decrypt   | `example.zip.encrypted`| `example.zip.encrypted.decrypted`|

---

## 💻 How to Run

### 🪟 Windows

1. Make sure [.NET SDK](https://dotnet.microsoft.com/download) is installed.
2. Open CMD or PowerShell in the folder containing the `.cs` file.
3. Build and run:

```bash
dotnet new console -o FileEncryptorApp
cd FileEncryptorApp
# Replace default Program.cs
copy ..\Program.cs .\Program.cs
dotnet build
After building, run the .exe directly:

cd bin\Debug\net8.0
File\ Encryptor\ \&\ Decrypter.exe
💡 Tip: You can also double-click the File Encryptor & Decrypter.exe in File Explorer.


🐧 Linux
Install .NET SDK:

sudo apt update
sudo apt install dotnet-sdk-8.0
In terminal:

dotnet new console -o FileEncryptorApp
cd FileEncryptorApp
mv ../Program.cs ./Program.cs
dotnet run
Or, build and run the output manually:

dotnet build
cd bin/Debug/net8.0
./File\ Encryptor\ \&\ Decrypter
🧪 Example Usage

Enter file path: /home/user/Desktop/test.pdf
Enter encryption key (0–255): 123
✅ File encrypted successfully: test.pdf.encrypted
To decrypt, run again with the .encrypted file and the same key.

⚠️ Disclaimer
This tool uses basic XOR encryption, which is not secure for highly sensitive data. It’s intended for educational purposes, light protection, or pranking.

📄 License
Open-source under the MIT License.

👤 Author
Made by @dionabazi with ❤️

---

Let me know if you want me to:
- Generate a `.csproj` for GitHub upload
- Add a logo/banner to the top of the README
- Add a command-line argument version (no user input)  
Ready to roll this into your next tool too 👊
