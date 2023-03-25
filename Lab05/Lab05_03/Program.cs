using System;

interface IMaleClothing
{
    void DressMale();
}

interface IFemaleClothing
{
    void DressFemale();
}

abstract class Clothing
{
    public string Size { get; set; }
    public double Cost { get; set; }
    public string Color { get; set; }
}

class TShirt : Clothing, IMaleClothing, IFemaleClothing
{
    public void DressMale()
    {
        Console.WriteLine("Dressing male in a t-shirt of size {0}, color {1}, and cost {2}", Size, Color, Cost);
    }

    public void DressFemale()
    {
        Console.WriteLine("Dressing female in a t-shirt of size {0}, color {1}, and cost {2}", Size, Color, Cost);
    }
}

class Pants : Clothing, IMaleClothing, IFemaleClothing
{
    public void DressMale()
    {
        Console.WriteLine("Dressing male in pants of size {0}, color {1}, and cost {2}", Size, Color, Cost);
    }

    public void DressFemale()
    {
        Console.WriteLine("Dressing female in pants of size {0}, color {1}, and cost {2}", Size, Color, Cost);
    }
}

class Skirt : Clothing, IFemaleClothing
{
    public void DressFemale()
    {
        Console.WriteLine("Dressing female in a skirt of size {0}, color {1}, and cost {2}", Size, Color, Cost);
    }
}

class Tie : Clothing, IMaleClothing
{
    public void DressMale()
    {
        Console.WriteLine("Dressing male in a tie of size {0}, color {1}, and cost {2}", Size, Color, Cost);
    }
}

class Shop
{
    private string[] sizes = { "XXS", "XS", "S", "M", "L" };

    public string GetDescription(string size)
    {
        if (size == "XXS")
            return "Child size";
        else
            return "Adult size";
    }

    public int GetEuroSize(string size)
    {
        return Array.IndexOf(sizes, size) + 32;
    }
}

class Atelier
{
    public void DressMale(IMaleClothing[] clothes)
    {
        foreach (var item in clothes)
        {
            item.DressMale();
        }
    }

    public void DressFemale(IFemaleClothing[] clothes)
    {
        foreach (var item in clothes)
        {
            item.DressFemale();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Clothing[] clothes = new Clothing[]
        {
            new TShirt { Size = "M", Color = "Red", Cost = 10.99 },
            new Pants { Size = "L", Color = "Blue", Cost = 29.99 },
            new Skirt { Size = "S", Color = "Black", Cost = 24.99 },
            new Tie { Size = "XS", Color = "Green", Cost = 14.99 }
        };

        Shop shop = new Shop();
        Atelier atelier = new Atelier();

        Console.WriteLine("Male clothing:");
        IMaleClothing[] maleClothing = Array.FindAll(clothes, x => shop.GetDescription(x.Size) == "Adult size").OfType<IMaleClothing>().ToArray();
        atelier.DressMale(maleClothing);

        Console.WriteLine("\nFemale clothing:");
        IFemaleClothing[] femaleClothing = Array.FindAll(clothes, x => shop.GetDescription);
        }
}