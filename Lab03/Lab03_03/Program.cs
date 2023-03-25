using System.IO;
using System.Text;
using System;

class ProperFraction
{
    public int GetNumerator()
    {
        return numerator;
    }
    public int GetDenominator()
    {
        return denominator;
    }

    public ProperFraction()
    {
        GetNumerator = 0;
        GetDenominator = 1;
    }

    public ProperFraction(int num, int denom)
    {
        GetNumerator = num;
        GetDenominator = denom;
    }

    public void ToPercentage()
    {
        double percent = (double)GetNumerator / GetDenominator * 100;
        Console.WriteLine("The fraction as a percentage is: {0}%", percent);
    }

    public int SumDenominator()
    {
        return denominator;
    }

    public override string ToString()
    {
        return string.Format("{0}/{1}", GetNumerator, GetDenominator);
    }
}

class MixedFraction : ProperFraction
{
    private int wholePart;

    public MixedFraction(int whole, int num, int denom) : base(num, denom)
    {
        wholePart = whole;
    }

    public void ToDecimal()
    {
        double result = (double)wholePart + (double)GetNumerator / GetDenominator;
        Console.WriteLine("The mixed fraction as a decimal is: {0}", result);
    }

    public override string ToString()
    {
        return string.Format("{0} {1}/{2}", wholePart, GetNumerator, GetDenominator);
    }
}

class FractionTest
{
    static void Main(string[] args)
    {
        ProperFraction f1 = new ProperFraction(3, 4);
        f1.ToPercentage();
        Console.WriteLine("The sum of denominators is: {0}", f1.SumDenominator());
        Console.WriteLine("The fraction is: {0}", f1.ToString());

        MixedFraction f2 = new MixedFraction(2, 1, 4);
        f2.ToDecimal();
        Console.WriteLine("The mixed fraction is: {0}", f2.ToString());

        Console.ReadLine();
    }
}