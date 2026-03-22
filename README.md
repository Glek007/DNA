# 🧬 DNA Generator

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=FFFFFF)](https://dotnet.microsoft.com/download/dotnet-framework)
[![C#](https://img.shields.io/badge/C%23-10-239120?style=for-the-badge&logo=csharp&logoColor=FFFFFF)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Console](https://img.shields.io/badge/Console-App-2D2D2D?style=for-the-badge&logo=windowsterminal&logoColor=FFFFFF)](https://en.wikipedia.org/wiki/Console_application)
[![License](https://img.shields.io/badge/License-MIT-2D2D2D?style=for-the-badge&logo=opensourceinitiative&logoColor=FFFFFF)](LICENSE)

[![Made with Love](https://img.shields.io/badge/Made%20with-❤️-FF69B4?style=for-the-badge)](https://github.com/Glek007/DNA)

## Languages
[![EN](https://img.shields.io/badge/README-EN-2D2D2D?style=for-the-badge&logo=github&logoColor=FFFFFF)](./README.md)
[![RU](https://img.shields.io/badge/README-RU-2D2D2D?style=for-the-badge&logo=google-translate&logoColor=FFFFFF)](./README-RU.md)

---

## 📖 About

**DNA Generator** is a simple yet visually pleasing program that creates a random DNA sequence based on the length you provide. Each nucleotide (A, T, G, C) is displayed in its own unique color, making the output both fun and educational!

Perfect for:
- Learning about DNA bases
- Quick random string generation
- Demonstrating console color manipulation in C#

---

## ✨ Features

| | Feature | Description |
|---|---------|-------------|
| 🎨 | **Colored output** | Each nucleotide gets its own color: A=Green, T=Red, G=Yellow, C=Blue |
| 🧬 | **Random sequence** | Generates truly random DNA strings using built-in `Random` class |
| 💾 | **Auto-save** | Automatically saves the generated sequence to `dna_result.txt` on your desktop |
| 🔢 | **User input** | Choose exactly how many nucleotides you want to generate |
| 🖥️ | **Simple console UI** | Clean, beginner-friendly interface |

---

## 🚀 Getting Started

### Requirements

- Windows OS
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) or later
- Visual Studio 2017+ (optional, for editing)

### Installation

1. Clone this repository or download the source code:
```bash
git clone https://github.com/Glek007/DNA.git
```

2. Open `DNA 1.0.0.csproj` in Visual Studio

3. Build and run (press `F5`)

### Quick Start

Run the program and enter a number when prompted:

```
Введите длину текста: 20
```

The program will display a colored DNA sequence and save it to your desktop:

```
Результат:
AGCTTCGATAGCTAGCCTAG
Файл сохранен: C:\Users\...\Desktop\dna_result.txt
```

---

## 🎮 How It Works

```csharp
char[] nucleotides = { 'A', 'T', 'G', 'C' };
var random = new Random();

// Generate random nucleotide
char symbol = nucleotides[random.Next(nucleotides.Length)];

// Color based on nucleotide type
switch (symbol)
{
    case 'A': Console.ForegroundColor = ConsoleColor.Green; break;
    case 'T': Console.ForegroundColor = ConsoleColor.Red; break;
    case 'G': Console.ForegroundColor = ConsoleColor.Yellow; break;
    case 'C': Console.ForegroundColor = ConsoleColor.Blue; break;
}
```

The sequence is built character by character, displayed with color, and then saved as a plain text file.

---

## 📁 Output

After each run, a file named `dna_result.txt` is created on your desktop containing the raw DNA string (no color codes, just plain text).

Example content:
```
AGCTTCGATAGCTAGCCTAG
```

---

## 🛠️ Project Structure

```
DNA/
├── Program.cs              # Main application logic
├── DNA 1.0.0.csproj        # Project file
├── free-icon-helix-4149254-_1_.ico  # Application icon
├── App.config              # Configuration file
└── README.md               # This file
```

---

## 🤝 Contributing

This is a small project for learning purposes, but feel free to:
- Suggest improvements
- Add new features (like file format options, more nucleotides, etc.)
- Report bugs

Open an issue or submit a pull request!

---

## 📄 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

## 🧪 Future Ideas

- [ ] Support for custom nucleotide sets
- [ ] Export to CSV or FASTA format
- [ ] DNA complement (reverse strand) generation
- [ ] Save to user-defined location
- [ ] Generate multiple sequences at once

---

## 💬 Feedback

If you have any questions or just want to say hi, feel free to reach out!
Made with ❤️ by [Glek007](https://github.com/Glek007), Lonewolf239
