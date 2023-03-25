using System;
public abstract class TSystemLinearEquation
{
    protected int n; // Кількість рівнянь в системі
    protected int m; // Кількість змінних в системі
    protected double[,] A; // Матриця коефіцієнтів
    protected double[] B; // Вектор вільних членів

    // Конструктор
    public TSystemLinearEquation(int n, int m)
    {
        this.n = n;
        this.m = m;
        A = new double[n, m];
        B = new double[n];
    }

    // Введення матриці коефіцієнтів та вектора вільних членів
    public virtual void Input()
    {
        Console.WriteLine("Введіть коефіцієнти та вільні члени:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                A[i, j] = double.Parse(Console.ReadLine());
            }
            B[i] = double.Parse(Console.ReadLine());
        }
    }

    // Виведення системи рівнянь
    public virtual void Print()
    {
        Console.WriteLine("Система рівнянь:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,6:f2}", A[i, j]);
            }
            Console.WriteLine(" = {0,6:f2}", B[i]);
        }
    }

    // Знаходження розв'язків системи рівнянь
    public abstract double[] Solve();

    // Перевірка, чи є заданий набір чисел розв'язком системи рівнянь
    public virtual bool CheckSolution(double[] x)
    {
        for (int i = 0; i < n; i++)
        {
            double sum = 0;
            for (int j = 0; j < m; j++)
            {
                sum += A[i, j] * x[j];
            }
            if (Math.Abs(sum - B[i]) > 1e-6)
            {
                return false;
            }
        }
        return true;
    }
}

public class TSystemLinearEquation2 : TSystemLinearEquation
{
    // Конструктор
    public TSystemLinearEquation2() : base(2, 2)
    {
    }

    // Знаходження розв'язків системи рівнянь
    public override double[] Solve()
    {
        double det = A[0, 0] * A[1, 1]

