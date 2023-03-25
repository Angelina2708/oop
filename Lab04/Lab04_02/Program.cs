using System;

abstract class TSystemLinearEquation
{
    public abstract void InputCoefficients();
    public abstract void OutputCoefficients();
    public abstract double[] FindRoots();
    public abstract bool IsSolution(double[] values);

    protected static double GetDeterminant(double a, double b, double c, double d)
    {
        return a * d - b * c;
    }
}

class TwoEquationSystem : TSystemLinearEquation
{
    private double a1, b1, c1;
    private double a2, b2, c2;

    public override void InputCoefficients()
    {
        a1 = new Random().Next(-10, 10);
        b1 = new Random().Next(-10, 10);
        c1 = new Random().Next(-10, 10);
        a2 = new Random().Next(-10, 10);
        b2 = new Random().Next(-10, 10);
        c2 = new Random().Next(-10, 10);
    }

    public override void OutputCoefficients()
    {
        Console.WriteLine($"Equation 1: {a1}x + {b1}y = {c1}");
        Console.WriteLine($"Equation 2: {a2}x + {b2}y = {c2}");
    }

    public override double[] FindRoots()
    {
        double det = GetDeterminant(a1, b1, a2, b2);

        if (Math.Abs(det) < 1e-9)
        {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return null; // No unique solution or no solution at all
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        }

        double detX = GetDeterminant(c1, b1, c2, b2);
        double detY = GetDeterminant(a1, c1, a2, c2);

        double x = detX / det;
        double y = detY / det;

        return new double[] { x, y };
    }

    public override bool IsSolution(double[] values)
    {
        if (values == null || values.Length != 2)
        {
            return false;
        }

        double x = values[0];
        double y = values[1];

        return Math.Abs(a1 * x + b1 * y - c1) < 1e-9 && Math.Abs(a2 * x + b2 * y - c2) < 1e-9;
    }
}

class ThreeEquationSystem : TSystemLinearEquation
{
    private double a1, b1, c1, d1;
    private double a2, b2, c2, d2;
    private double a3, b3, c3, d3;

    public override void InputCoefficients()
    {
        a1 = new Random().Next(-10, 10);
        b1 = new Random().Next(-10, 10);
        c1 = new Random().Next(-10, 10);
        d1 = new Random().Next(-10, 10);
        a2 = new Random().Next(-10, 10);
        b2 = new Random().Next(-10, 10);
        c2 = new Random().Next(-10, 10);
        d2 = new Random().Next(-10, 10);
        a3 = new Random().Next(-10, 10);
        b3 = new Random().Next(-10, 10);
        c3 = new Random().Next(-10, 10);
        d3 = new Random().Next(-10, 10);
    }

    public override void OutputCoefficients()
    {
        Console.WriteLine($"Equation 1: {a1}x + {b1}y + {c1}z = {d1}");
        Console.WriteLine($"Equation 2: {a2}x + {b2}y + {c2}z = {d2}");
        Console.WriteLine($"Equation 3: {a3}x + {b3}y + {c3}z = {d3}");
    }

    public override double[] FindRoots()
    {
        double det = a1 * GetDeterminant(b2, c2, b3, c3) - b1 * GetDeterminant(a2, c2, a3, c3) + c1 * GetDeterminant(a2, b2, a3, b3);

        if (Math.Abs(det) < 1e-9)
        {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return null; // No unique solution or no solution at all
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        }

        double detX = d1 * GetDeterminant(b2, c2, b3, c3) - b1 * GetDeterminant(d2, c2, d3, c3) + c1 * GetDeterminant(d2, b2, d3, b3);
        double detY = a1 * GetDeterminant(d2, c2, d3, c3) - d1 * GetDeterminant(a2, c2, a3, c3) + c1 * GetDeterminant(a2, d2, a3, d3);
        double detZ = a1 * GetDeterminant(b2, d2, b3, d3) - b1 * GetDeterminant(a2, d2, a3, d3) + d1 * GetDeterminant(a2, b2, a3, b3);

        double x = detX / det;
        double y = detY / det;
        double z = detZ / det;

        return new double[] { x, y, z };
    }

    public override bool IsSolution(double[] values)
    {
        if (values == null || values.Length != 3)
        {
            return false;
        }

        double x = values[0];
        double y = values[1];
        double z = values[2];

        return Math.Abs(a1 * x + b1 * y + c1 * z - d1) < 1e-9 &&
               Math.Abs(a2 * x + b2 * y + c2 * z - d2) < 1e-9 &&
               Math.Abs(a3 * x + b3 * y + c3 * z - d3) < 1e-9;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TSystemLinearEquation[] equations = new TSystemLinearEquation[2];
        equations[0] = new TwoEquationSystem();
        equations[1] = new ThreeEquationSystem();

        foreach (TSystemLinearEquation equation in equations)
        {
            equation.InputCoefficients();
            equation.OutputCoefficients();
            double[] roots = equation.FindRoots();

            if (roots != null)
            {
                Console.WriteLine("Roots found:");
                for (int i = 0; i < roots.Length; i++)
                {
                    Console.WriteLine($"x{i + 1} = {roots[i]}");
                }

                Console.WriteLine($"Is solution: {equation.IsSolution(roots)}");
            }
            else
            {
                Console.WriteLine("No unique solution found.");
            }

            Console.WriteLine();
        }
    }
}



