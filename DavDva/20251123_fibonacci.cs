using System.ComponentModel;

namespace FunctionsReturn
{
    // TODO:
    /* დავწეროთ მეთოდი, რომელიც მიიღებს int upperBound პარამეტრის სახით დასაგენერირებელი რიცხვებისთვის
     * უმაღლეს ზღვარს და დააბრუნებს int[] მასივის სახით upperBound-ის ჩათვლით არსებულ ყველა ფიბონაჩის რიცხვს.
     * გაითვალისწინეთ, რომ მასივის ელემენტები უნდა ემთხვეოდეს არსებულ ფიბონაჩის რიცხვების რაოდენობას.
     * მ.გ. თუ გადავეცით 15, უნდა დაბრუნდეს 8 ელემენტიანი მასივი შემდეგი რიცხვებით: 0, 1, 1, 2, 3, 5, 8, 13.
     * https://en.wikipedia.org/wiki/Fibonacci_number
     */
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter upper bound number: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers up to {upperBound} are:");

            int[] numbers = GetNumbers(upperBound);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static int[] GetNumbers(int upperBound)
        {
            // Count how many Fibonacci numbers are below upperBound
            int a = 0, b = 1;
            int count = 1;
            int lastFibo;
            for (int i=0; i<upperBound; i++)
            {
                if (b < upperBound)
                {
                    lastFibo = a + b;
                    a = b;
                    b = lastFibo;
                    count++;
                }
            }

            // Create array to hold Fibonacci numbers
            int[] arr = new int[count];
            arr[0] = 0;
            arr[1] = 1;
            for (int i =2; i< count; i++)
            {
                arr[i] = arr[i-2] + arr[i-1];
            }

            return arr;
        }

    }
}
