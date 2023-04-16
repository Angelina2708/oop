using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFile = "f.txt";
        string outputFile = "g.txt";

        // Відкриваємо файли для читання та запису
        StreamReader reader = new StreamReader(inputFile);
        StreamWriter writer = new StreamWriter(outputFile);

        // Читаємо числа з файлу f та записуємо відповідні числа до файлу g
        while (!reader.EndOfStream)
        {
            double number = double.Parse(reader.ReadLine());

            // Якщо число є парним, записуємо його до файлу g
            if (number % 2 == 0)
            {
                writer.WriteLine(number);
            }

            // Якщо число ділиться на 3 і не ділиться на 7, записуємо його до файлу g
            if (number % 3 == 0 && number % 7 != 0)
            {
                writer.WriteLine(number);
            }

            // Якщо число є точним квадратом, записуємо його до файлу g
            int squareRoot = (int)Math.Sqrt(number);
            if (squareRoot * squareRoot == number)
            {
                writer.WriteLine(number);
            }
        }

        // Закриваємо файли
        reader.Close();
        writer.Close();
    }
}
