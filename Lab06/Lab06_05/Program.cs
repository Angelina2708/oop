using System;
using System.Collections.Generic;
using System.Linq;

public class Culture
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Area { get; set; }
    public int Harvest { get; set; }
}

public class CultureCollections
{
    private List<List<Culture>> _collections;

    public CultureCollections()
    {
        _collections = new List<List<Culture>>();
    }

    public void AddCollection(List<Culture> collection)
    {
        _collections.Add(collection);
    }

    public List<Culture> this[int index]
    {
        get
        {
            if (index >= 0 && index < _collections.Count)
            {
                return _collections[index];
            }
            throw new IndexOutOfRangeException("Index is out of range");
        }
        set
        {
            if (index >= 0 && index < _collections.Count)
            {
                _collections[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }
    }

    public int CollectionsCount
    {
        get { return _collections.Count; }
    }

    public int CountCollectionsWithSize(int size)
    {
        return _collections.Count(c => c.Count == size);
    }

    public List<Culture> GetMaxCollection()
    {
        return _collections.OrderByDescending(c => c.Count).First();
    }

    public List<Culture> GetMinCollection()
    {
        return _collections.OrderBy(c => c.Count).First();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Culture> collection1 = new List<Culture>
        {
            new Culture { Name = "Кукурудза", Type = "З", Area = 13000, Harvest = 45 },
            new Culture { Name = "Пшениця", Type = "З", Area = 8000, Harvest = 17 }
        };

        List<Culture> collection2 = new List<Culture>
        {
            new Culture { Name = "Рис", Type = "З", Area = 25650, Harvest = 24 }
        };

        CultureCollections cultureCollections = new CultureCollections();
        cultureCollections.AddCollection(collection1);
        cultureCollections.AddCollection(collection2);

        // Знайти кількість колекцій розміру 2
        int countOfSize2 = cultureCollections.CountCollectionsWithSize(2);
        Console.WriteLine($"Кількість колекцій розміру 2: {countOfSize2}");

        // Знайти максимальну колекцію
        List<Culture> maxCollection = cultureCollections.GetMaxCollection();
        Console.WriteLine("Максимальна колекція:");
        foreach (Culture culture in maxCollection)
        {
            Console.WriteLine($"{culture.Name}, Площа посіву: {culture.Area}, Врожайність: {culture.Harvest}");
        }

        // Знайти мінімальну колекцію
        List<Culture> minCollection = cultureCollections.GetMinCollection();
        Console.WriteLine("Мінімальна колекція:");
        foreach (Culture culture in minCollection)
        {
            Console.WriteLine($"{culture.Name}, Площа посіву: {culture.Area}, Врожайність: {culture.Harvest}");
        }

        // Вивести елемент з індексом 1 з першої колекції
        Culture culture1 = cultureCollections[0][1];
        Console.WriteLine($"Елемент з індексом 1 з першої колекції: {culture1.Name}, Площа посіву: {culture1.Area}, Врожайність: {culture1.Harvest}");
    }
}
