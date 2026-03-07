using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Title = "DNA";
        Console.Write("Введите длину текста: ");
        if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
        {
            Console.WriteLine("Ошибка: нужно ввести положительное целое число.");
            return;
        }

        char[] chars = { 'A', 'T', 'G', 'C' };
        var rand = new Random();
        var sb = new StringBuilder();
        Console.WriteLine("\nРезультат:");

        for (int i = 0; i < length; i++)
        {
            char symbol = chars[rand.Next(chars.Length)];
            sb.Append(symbol);

            switch (symbol)
            {
                case 'A': Console.ForegroundColor = ConsoleColor.Green; break;
                case 'T': Console.ForegroundColor = ConsoleColor.Red; break;
                case 'G': Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 'C': Console.ForegroundColor = ConsoleColor.Blue; break;
            }

            Console.Write(symbol);
        }

        Console.ResetColor();
        Console.WriteLine("\n");

        try
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "dna_result.txt");

            File.WriteAllText(filePath, sb.ToString());

            Console.WriteLine($"Файл сохранен: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при сохранении: {ex.Message}");
        }

        Console.WriteLine("Программа завершена. Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
