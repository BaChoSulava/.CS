using System;

namespace _20251225
{
    internal class Program
    {
        static void Main()
        {
            QuadraticEquation equation = new QuadraticEquation;
            equation.A = 1;
            equation.B = 50;
            equation.C = 3;
            
            equation.Solve();
        }
    }

    internal class QuadraticEquation
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("'A' cannot be zero.");
                }

                _a = value;
            }
        }

        public double B
        {
            set => _b = value;
        }

        public double C
        {
            set => _c = value;
        }

        private double Discriminant => _b * _b - 4 * _a * _c;

        public void Solve()
        {
            if (Discriminant > 0)
            {
                PrintTwoRoots();
            }
            else if (Discriminant == 0)
            {
                PrintOneRoot();
            }
            else
            {
                Console.WriteLine("Discriminant is negative, so no real roots.");
            }
        }

        private void PrintTwoRoots()
        {
            double sqrtD = Math.Sqrt(Discriminant);

            double x1 = (-_b + sqrtD) / (2 * _a);
            double x2 = (-_b - sqrtD) / (2 * _a);

            Console.WriteLine(
                $"Two real roots: x1 = {x1:0.00}, x2 = {x2:0.00}");
        }

        private void PrintOneRoot()
        {
            double x = -_b / (2 * _a);

            Console.WriteLine($"One real root: x = {x:0.00}");
        }
    }
}
