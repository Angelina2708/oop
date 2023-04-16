using System;
using System.Collections.Generic;

class Set
{
    private List<char> elements = new List<char>();

    // Додати елемент до множини
    public static Set operator +(Set set, char element)
    {
        set.elements.Add(element);
        return set;
    }

    // Перетин множин
    public static Set operator *(Set set1, Set set2)
    {
        Set result = new Set();
        foreach (char element in set1.elements)
        {
            if (set2.elements.Contains(element))
            {
                result.elements.Add(element);
            }
        }
        return result;
    }

    // Потужність множини
    public static int operator ~(Set set)
    {
        return set.elements.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Set set1 = new Set() + 'a' + 'b' + 'c';
        Set set2 = new Set() + 'b' + 'c' + 'd';
        Set set3 = set1 * set2;
        int power = ~(set1 * set2);

        Console.WriteLine("Set 1: " + string.Join(", ", set1));
        Console.WriteLine("Set 2: " + string.Join(", ", set2));
        Console.WriteLine("Set 1 * Set 2: " + string.Join(", ", set3));
        Console.WriteLine("Power of Set 1 * Set 2: " + power);
    }
}
