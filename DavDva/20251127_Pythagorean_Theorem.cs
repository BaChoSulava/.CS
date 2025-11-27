using System;

namespace _20251127
{
    class PythagoreanTheorem
    {
        static void Main()
        {
            string startprogram = "y";

            while (startprogram == "y")
            {
                string chosenMethod = AskWhichMethod();
                string answer = DoChosenMethod(chosenMethod);
                PrintAnswer(answer);

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
                Console.WriteLine("\nI can calculate the length of a leg, the hypotenuse, or check if a triangle may exist.");
                Console.Write("\nType 'l' for leg, 'h' for hypotenuse or 'c' for checking: ");
                method = Console.ReadLine();

                if (method != "l" && method != "h" && method != "c")
                {
                    Console.WriteLine("Invalid choice! Please type 'l', 'h', or 'c'.\n");
                }
            }
            while (method != "l" && method != "h" && method != "c");

            return method;
        }

        static string DoChosenMethod(string chosenMethod)
        {
            double a, b, c;

            if (chosenMethod == "l")
            {
                a = Input("a");
                c = Input("c");
                return "Other leg length = " + CalcLeg(a, c);
            }

            else if (chosenMethod == "h")
            {
                a = Input("a");
                b = Input("b");
                return "Hypotenuse length = " + CalcHypotenuse(a, b);
            }

            else
            {
                a = Input("a");
                b = Input("b");
                c = Input("c");
                return CheckExistence(a, b, c);
            }
        }

        static string CheckExistence(double a, double b, double c)
        {
            if (Square(a) + Square(b) == Square(c))
                return "This is a valid right triangle.";
            else
                return "This is NOT a valid right triangle.";
        }

        static double CalcLeg(double a, double c)
        {
            return Math.Sqrt(Square(c) - Square(a));
        }

        static double CalcHypotenuse(double a, double b)
        {
            return Math.Sqrt(Square(a) + Square(b));
        }

        static void PrintAnswer(string answer)
        {
            Console.WriteLine($"\nThe answer is: {answer}");
        }

        static double Square(double number)
        {
            return number * number;
        }

        static double Input(string name)
        {
            double number;

            while (true)
            {
                if (name == "a")
                    Console.Write("Enter leg (a) value: ");
                else if (name == "b")
                    Console.Write("Enter leg (b) value: ");
                else if (name == "c")
                    Console.Write("Enter hypotenuse (c) value: ");

                if (double.TryParse(Console.ReadLine(), out number))
                    return number;

                Console.WriteLine("Invalid input! Please enter a valid number.\n");
            }
        }
    }
}
