namespace ConsoleApp360
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int age = GetAge();
                Console.WriteLine(age >= 18 ? "You are an adult." : "You are a minor.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Type: {ex.GetType().Name}");
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("Goodbye");
        }

        static int GetAge()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine()!);
            if (age < 2 || age > 120)
            {
                throw new ArgumentOutOfRangeException("Age must be between 2 and 120.");
            }
            return age;
        }
    }
}