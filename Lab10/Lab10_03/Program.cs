using System;
using System.Text;

namespace VectorOperations
{
    public class Vector
    {
        private double[] _data;

        public Vector(int size)
        {
            _data = new double[size];
        }

        public double this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        public static Vector operator -(Vector a, Vector b)
        {
            if (a._data.Length != b._data.Length)
            {
                throw new ArgumentException("Вектори мають мати однаковий розмір.");
            }

            Vector result = new Vector(a._data.Length);
            for (int i = 0; i < a._data.Length; i++)
            {
                result[i] = a[i] - b[i];
            }

            return result;
        }

        public static Vector operator -(Vector a, double scalar)
        {
            Vector result = new Vector(a._data.Length);
            for (int i = 0; i < a._data.Length; i++)
            {
                result[i] = a[i] - scalar;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(3);
            Vector b = new Vector(3);

            a[0] = 1.0;
            a[1] = 2.0;
            a[2] = 3.0;

            b[0] = 4.0;
            b[1] = 5.0;
            b[2] = 6.0;

            Vector result1 = a - b;
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine($"Результат віднімання векторів: [{result1[0]}, {result1[1]}, {result1[2]}]");

            double scalar = 1.5;
            Vector result2 = a - scalar;
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine($"Результат віднімання скаляра від вектора: [{result2[0]}, {result2[1]}, {result2[2]}]");
        }
    }
}