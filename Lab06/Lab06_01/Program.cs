using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо масив об'єктів CollectionType
        CollectionType[] collections = new CollectionType[]
        {
            new CollectionType() { Name = "Collection 1", Items = new List<int> { 1, 2, 3 } },
            new CollectionType() { Name = "Collection 2", Items = new List<int> { 4, 5, 6, 7 } },
            new CollectionType() { Name = "Collection 3", Items = new List<int> { 8, 9 } },
            new CollectionType() { Name = "Collection 4", Items = new List<int> { 10 } },
            new CollectionType() { Name = "Collection 5", Items = new List<int> { } }
        };

        // Знаходимо кількість колекцій, рівних заданому розміру
        int size = 3;
        int count = collections.Count(c => c.Items.Count == size);
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Кількість колекцій, розмір яких дорівнює {size}: {count}");

        // Знаходимо максимальну та мінімальну колекцію в масиві
        CollectionType maxCollection = collections.OrderByDescending(c => c.Items.Count).FirstOrDefault();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Максимальна колекція: {maxCollection.Name} ({maxCollection.Items.Count} елементів)");

        CollectionType minCollection = collections.OrderBy(c => c.Items.Count).FirstOrDefault();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Мінімальна колекція: {minCollection.Name} ({minCollection.Items.Count} елементів)");
    }
}

// Клас, що представляє об'єкт колекції
class CollectionType
{
    public string Name { get; set; }
    public List<int> Items { get; set; }
}
