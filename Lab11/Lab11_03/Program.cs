//Дано рядок, який містить три різні дати,
//розділені комою. Кожна дата – це число, місяць і рік.
//Знайти: 1.рік з найменшим номером;
//2.всі весняні дати;
//3.саму пізнішу дату.


using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        // Введіть рядок з трьома датами, розділеними комою
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.Write("Введіть рядок з трьома датами у форматі dd/mm/yyyy, dd/mm/yyyy, dd/mm/yyyy: ");
        string input = Console.ReadLine();

        // Розділяємо рядок на окремі дати
        string[] dates = input.Split(',');

        // Обробляємо кожну дату
        int minYear = int.MaxValue;
        DateTime latestDate = DateTime.MinValue;
        foreach (string dateStr in dates)
        {
            // Парсимо рядок у дату
            DateTime date = DateTime.ParseExact(dateStr.Trim(), "dd/MM/yyyy", null);

            // Знаходимо рік з найменшим номером
            if (date.Year < minYear)
            {
                minYear = date.Year;
            }

            // Знаходимо всі весняні дати
            if (date.Month >= 3 && date.Month <= 5)
            {
                Console.WriteLine("{0:d}", date);
            }

            // Знаходимо саму пізнішу дату
            if (date > latestDate)
            {
                latestDate = date;
            }
        }

        // Виводимо результати
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("Рік з найменшим номером: {0}", minYear);
        Console.WriteLine("Сама пізніша дата: {0:d}", latestDate);

        Console.ReadLine();
    }
}
