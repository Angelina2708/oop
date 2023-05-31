using System;

public class Polynomial
{
    private int degree;
    private double[] coefficients;

    public Polynomial(int degree, double[] coefficients)
    {
        if (degree < 0)
        {
            throw new ArgumentException("Степінь многочлена не може бути від'ємною");
        }

        if (coefficients.Length != degree + 1)
        {
            throw new ArgumentException("Кількість коефіцієнтів має співпадати зі степенем многочлена + 1");
        }

        this.degree = degree;
        this.coefficients = new double[degree + 1];
        coefficients.CopyTo(this.coefficients, 0);
    }

    public double Calculate(double x)
    {
        double result = 0;
        for (int i = 0; i <= degree; i++)
        {
            result += coefficients[i] * Math.Pow(x, i);
        }
        return result;
    }

    public override string ToString()
    {
        string result = "";
        for (int i = degree; i >= 0; i--)
        {
            if (coefficients[i] != 0)
            {
                if (i != degree)
                {
                    result += " + ";
                }
                result += $"{coefficients[i]}*x^{i}";
            }
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double[] coefficients = { 5, -7, 2 }; // коефіцієнти многочлена для многочлена 2x^2 - 3x + 5
        Polynomial polynomial = new Polynomial(2, coefficients);
        Console.WriteLine(polynomial); // вивести многочлен
        double x = 7;
        double result = polynomial.Calculate(x); // обчислити значення многочлена для x
        Console.WriteLine($"Значення многочлена при x = {x} є {result}");
    }
}