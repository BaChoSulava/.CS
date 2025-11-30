using System;

namespace _20251130
{
    // TODO: Quadratic Equation Solver
    class QuadraticEquation
    {
        static void Main()
        {
            string startprogram = "y";

            while (startprogram == "y")
            {
                string chosenMethod = AskWhichMethod();
                string[] answers = DoChosenMethod(chosenMethod);
                PrintAnswer(answers);

                // RESTART
                Console.Write("\n\nTo restart write 'y': ");
                startprogram = Console.ReadLine();
                Console.Write("\n------------------------\n");
            }
        }

        static string AskWhichMethod()
        {
            string method;

            do
            {
                Console.WriteLine("\nI can give you info about 'quadratic equation', or calculate an equation.");
                Console.Write("Type 'i' for info or 'e' for equation: ");
                method = Console.ReadLine();

                if (method != "i" && method != "e")
                {
                    Console.WriteLine("Invalid choice! Please type 'i' or 'e'.\n");
                }
            }
            while (method != "i" && method != "e");

            return method;
        }

        static string[] DoChosenMethod(string chosenMethod)
        {
            if (chosenMethod == "i")
            {
                string info =
                    "A quadratic equation is an equation in mathematics where the highest power of the variable is 2.\n" +
                    "It has the general form: ax² + bx + c = 0\n" +
                    "where a, b, and c are constants (and a ≠ 0), and x is the unknown.";

                return new string[] { info, "empty" };
            }
            else
            {
                double a = Input("a");
                double b = Input("b");
                double c = Input("c");

                return Calculate(a, b, c);
            }
        }

        static double Input(string name)
        {
            double number;
            Console.WriteLine();

            while (true)
            {
                Console.Write($"Enter ({name}) value: ");
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    if (name == "a" && number == 0)
                    {
                        Console.WriteLine("Value 'a' cannot be 0 in a quadratic equation.\n");
                        continue;
                    }
                    return number;
                }
                Console.WriteLine("Invalid input! Please enter a valid number.\n");
            }
        }

        static string[] Calculate(double a, double b, double c)
        {
            double D = CalcDiscriminant(a, b, c);

            string x1 = "empty";
            string x2 = "empty";

            if (D < 0)
            {
                x1 = "Because the discriminant is less than 0, there are no real solutions.";
            }
            else if (D == 0)
            {
                double root = (-b) / (2 * a);
                x2 = root.ToString();
            }
            else
            {
                double root1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                double root2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                x1 = root1.ToString();
                x2 = root2.ToString();
            }

            return new string[] { x1, x2 };
        }

        static double CalcDiscriminant(double a, double b, double c)
        {
            return Square(b) - 4 * a * c;
        }

        static double Square(double number)
        {
            return number * number;
        }

        static void PrintAnswer(string[] answers)
        {
            if (answers[1] == "empty")
            {
                Console.WriteLine($"\n{answers[0]}");
            }
            else if (answers[0] == "empty")
            {
                Console.WriteLine($"\nThe equation has ONE answer and it's: x = {answers[1]}\n");
            }
            else
            {
                Console.WriteLine($"\nThe equation has TWO answers:\n x₁ = {answers[0]}, x₂ = {answers[1]}\n");
            }
        }
    }
}
