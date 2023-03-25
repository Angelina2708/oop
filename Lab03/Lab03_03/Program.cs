using System;

class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction()
    {
        Numerator = 0;
        Denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public double ToPercentage()
    {
        return (double)Numerator / Denominator * 100;
    }

    public int SumOfDenominatorDigits()
    {
        int sum = 0;
        int value = Denominator;

        while (value != 0)
        {
            sum += value % 10;
            value /= 10;
        }

        return sum;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

class MixedFraction : Fraction
{
    public int WholePart { get; set; }

    public MixedFraction() : base()
    {
        WholePart = 0;
    }

    public MixedFraction(int wholePart, int numerator, int denominator) : base(numerator, denominator)
    {
        WholePart = wholePart;
    }

    public double ToDecimal()
    {
        return WholePart + (double)Numerator / Denominator;
    }

    public override string ToString()
    {
        return $"{WholePart} {base.ToString()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(5, 7);
        Console.WriteLine(fraction.ToString());
        Console.WriteLine("Percentage: " + fraction.ToPercentage());
        Console.WriteLine("Sum of denominator digits: " + fraction.SumOfDenominatorDigits());

        MixedFraction mixedFraction = new MixedFraction(1, 2, 3);
        Console.WriteLine(mixedFraction.ToString());
        Console.WriteLine("Decimal: " + mixedFraction.ToDecimal());
    }
}