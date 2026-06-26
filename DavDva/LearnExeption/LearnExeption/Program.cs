namespace ConsoleApp360
{
    internal class Program
    {
        static void Main()
        {
            const string errorTypeTemplate = "Error Type: {0}";

            try
            {
                int age = GetAge();
                Console.WriteLine(age >= 18 ? "You are an adult." : "You are a minor.");
            }
            catch (AgeException ex)
            {
                Console.WriteLine($"Age Error: {ex.Message} Age: {ex.Age}");
                Console.WriteLine(errorTypeTemplate, ex.GetType().Name);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format Error: {ex.Message}");
                Console.WriteLine(errorTypeTemplate, ex.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(errorTypeTemplate, ex.GetType().Name);
            }

            Console.WriteLine("Goodbye");
        }

        static int GetAge()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine()!);
            if (age < 2 || age > 120)
            {
                throw new AgeException("Age must be between 2 and 120.", age);
            }
            return age;
        }
    }

    class AgeException : Exception
    {
        public AgeException(string message, int age) : base(message)
        {
            Age = age;
        }

        public int Age { get; }
    }
}