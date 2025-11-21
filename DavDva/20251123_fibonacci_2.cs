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
            string startProgram = "y";
            while (startProgram == "y")
            {
                Console.Write("Enter upper bound number: ");
                int upperBound = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Numbers up to {upperBound} are:");

                int[] numbers = GetNumbers(upperBound);
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }



                Console.Write("\n\nTo restart type 'y': ");
                startProgram = Console.ReadLine().ToLower();

                Console.WriteLine("\n--------------------\n");
            }
            
        }

        static int[] GetNumbers(int upperBound)
        {
            int[] x = new int[upperBound];
            x[0] = 0;
            x[1] = 1;
            int counter = 2;

            for (int i = 2; i < x.Length; i++)
            {
                int num = x[i - 2] + x[i - 1];
                if (num > upperBound)
                {
                    break;
                }
                counter++;
                x[i] = num;
            }

            int[] newArr = new int[counter];
            for (int j=0; j< counter; j++)
            {
                newArr[j] = x[j];
            }

            return newArr;
        }
    }
}
