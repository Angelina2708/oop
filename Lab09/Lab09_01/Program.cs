using System;

delegate double Function(double x);

class RectangleIntegral
{
    public static double Calculate(double a, double b, int n, Function f)
    {
        double h = (b - a) / n; // h - крок
        double result = 0.0;

        for (int i = 0; i < n; i++)
        {
            double x = a + i * h;
            result += f(x + h) * h;
        }

        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Function f = Math.Sin; // функція, яку ми хочемо інтегрувати
        double a = 0.0;
        double b = Math.PI;
        int n = 100; // кількість прямокутників

        double result = RectangleIntegral.Calculate(a, b, n, f);

        Console.WriteLine($"The integral of sin(x) from {a} to {b} is approximately {result}.");
    }
}
