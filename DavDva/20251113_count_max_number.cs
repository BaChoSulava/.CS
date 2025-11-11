namespace _20251113
{
    // TODO: დაწერეთ პროგრამა რომელიც შეასრულებს შემდეგს: მომიძებეთ და დამიწერეთ ეკრანზე რიცხვი რომელიც ყველაზე მეტჯერ განმეორდა მიყოლებით მასივში. 
    // თუ ესეთი რიცხვი ერთზე მეტია, დაბეჭდეთ რომელიმე ერთი მათგანი.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 2, 2, 7, 0, 3, 3, 4, 4, 4, 3, 4, 5, 6 };
            int number = arr[0];
            int count = 1;
            int maxNumber = number;
            int maxCount = count;

            // show origin array
            Console.WriteLine("Origin array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // find  number

            for (int i = 1; i < arr.Length; i++)
            {
                number = arr[i];
                count = 1;
                for (int j = 0; j < i; j++)
                {
                    if (number == arr[j])
                    {
                        count++;
