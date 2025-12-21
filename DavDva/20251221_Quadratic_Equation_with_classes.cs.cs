using System;

namespace _20251221
{
    internal class Program
    {
        static void Main()
        {
            QuadraticEquation eq1 = new QuadraticEquation();

            eq1.SetA(1);
            eq1.SetB(50);
            eq1.SetC(3);

            eq1.Solve();
        }
    }

    class QuadraticEquation
    {
        private double _a;
        private double _b;
        private double _c;

        public void SetA(double a)
        {
            if (a == 0)
                throw new ArgumentException("'a' cannot be zero.");

            _a = a;
        }

        public void SetB(double b)
        {
            _b = b;
        }

        public void SetC(double c)
        {
            _c = c;
        }

        public double GetDiscriminant()
        {
            return _b * _b - 4 * _a * _c;
        }

        public void Solve()
        {
            double d = GetDiscriminant();

            if (d > 0)
            {
                double x1 = (-_b + Math.Sqrt(d)) / (2 * _a);
                double x2 = (-_b - Math.Sqrt(d)) / (2 * _a);

                Console.WriteLine($"Two real roots: x1 = {x1:0.00}, x2 = {x2:0.00}");
            }
            else if (d == 0)
            {
                double x = -_b / (2 * _a);
                Console.WriteLine($"One real root: x = {x}");
            }
            else
            {
                Console.WriteLine("Discriminant is negative, so no real roots.");
            }
        }
    }
}
