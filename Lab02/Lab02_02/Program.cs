using System;

class Crop
{
    public string Name { get; set; }
    public int Type { get; set; }
    public int SownArea { get; set; }
    public int Yield { get; set; }

    public static int Count { get; private set; }

    public Crop(string name, int type, int sownArea, int yield)
    {
        Name = name;
        Type = type;
        SownArea = sownArea;
        Yield = yield;

        Count++;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Type: {Type}, Sown Area: {SownArea}, Yield: {Yield}";
    }
}

class CropArray
{
    private Crop[] crops;

    public CropArray(int size)
    {
        crops = new Crop[size];
    }

    public Crop this[int index]
    {
        get { return crops[index]; }
        set { crops[index] = value; }
    }

    public int Length
    {
        get { return crops.Length; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CropArray cropArray = new CropArray(10);

        cropArray[0] = new Crop("Soy", 6, 13000, 45);
        cropArray[1] = new Crop("Chumyza", 3, 8000, 17);
        cropArray[2] = new Crop("Fig", 3, 25650, 24);
        cropArray[3] = new Crop("Wheat", 2, 20000, 50);
        cropArray[4] = new Crop("Corn", 1, 15000, 70);
        cropArray[5] = new Crop("Rice", 5, 18000, 40);
        cropArray[6] = new Crop("Potatoes", 4, 10000, 30);
        cropArray[7] = new Crop("Tomatoes", 4, 5000, 25);
        cropArray[8] = new Crop("Cabbage", 4, 7000, 20);
        cropArray[9] = new Crop("Carrots", 4, 4000, 15);

        Crop minSownAreaCrop = cropArray[0];
        Crop maxYieldCrop = cropArray[0];

        for (int i = 1; i < cropArray.Length; i++)
        {
            if (cropArray[i].SownArea < minSownAreaCrop.SownArea)
            {
                minSownAreaCrop = cropArray[i];
            }

            if (cropArray[i].Yield > maxYieldCrop.Yield)
            {
                maxYieldCrop = cropArray[i];
            }
        }

        Console.WriteLine("Crop with the smallest cultivated area:");
        Console.WriteLine(minSownAreaCrop);
        Console.WriteLine();

        Console.WriteLine("Crop with the highest yield:");
        Console.WriteLine(maxYieldCrop);
        Console.WriteLine();

        if (Crop.Count > 1)
        {
            Console.WriteLine("Message 1: The number of existing objects exceeds the specified limit value.");
        }
        else if (Crop.Count < 2)
        {
            Console.WriteLine("Message 2: The number of existing objects is less than the specified limit value.");
        }
    }
}