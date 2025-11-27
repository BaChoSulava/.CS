using System;

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
			Console.WriteLine("I can calculate the length of a leg, the hypotenuse, or check if a triangle is right.");
			Console.Write("Type 'l' for leg, 'h' for hypotenuse or 'c' for checking: ");
			method = Console.ReadLine().ToLower();
		}
		while (method != "l" && method != "h" && method != "c");

		return method;
	}

	static string DoChosenMethod(string chosenMethod)
	{
		double a, b, c;

		if (chosenMethod == "l")
		{
			a = Input(a);
			c = Input(c);
		}

		return "Other leg length = " + CalcLeg(a, c);
	}
	else if (chosenMethod == "h")
	{
	    a = Input(a);
		b = Input(b);

		return "Hypotenuse length = " + CalcHypotenuse(a, b);
	}
	else
	{
	    a = Input(a);
	    b = Input(b);
		c = Input(c);

		return CheckExistence(a, b, c);
	}
}

static string CheckExistence(double a, double b, double c)
{
	if (Math.Abs(Square(a) + Square(b) - Square(c)) < 0.01)
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

static double Input(string errorCode) {
	string InputA = "a";
	string InputB = "b";
	string InputC = "c";

	do {
		if (erroCode == InputA) {
			Console.Write("Enter leg (a) value: ");
			while (!double.TryParse(Console.ReadLine(), out a))
			{
				Console.WriteLine("Invalid input! Please enter a valid number for leg (a).");
				Console.Write("Enter leg (a) value: ");
			}
		}

		if (erroCode == InputB) {
			Console.Write("Enter leg (b) value: ");
			while (!double.TryParse(Console.ReadLine(), out b))
			{
				Console.WriteLine("Invalid input! Please enter a valid number for leg (b).");
				Console.Write("Enter leg (b) value: ");
			}
		}

		if (erroCode == InputC) {
			Console.Write("Enter hypotenuse (c) value: ");
			while (!double.TryParse(Console.ReadLine(), out c))
			{
				Console.WriteLine("Invalid input! Please enter a valid number for hypotenuse (c).");
				Console.Write("Enter hypotenuse (c) value: ");
			}
		}
	} while(erroCode != InputA || erroCode != InputB || erroCode != InputC);
}
}
}
