using System;
using System.IO;

namespace qwerty
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = "test-file.txt";

            var writer = new StreamWriter(Path);
            Console.WriteLine("Введите текст для записи: ");
            var content = Console.ReadLine();
            writer.WriteLine(content);
            writer.Close();

            var reader = new StreamReader(Path);
            Console.WriteLine($"Файл открыт: {Path}");
            Console.Write($"Файл содержит: {reader.ReadToEnd()}");
            reader.Close();

            File.Delete(Path);
            Console.WriteLine("Файл удалён");
        }
    }
}