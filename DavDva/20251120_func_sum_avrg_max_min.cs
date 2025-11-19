namespace _20251120
{
    internal class Program
    {
        static void Main()
        {
            string startProgram = "y";

            while (startProgram == "y")
            {
                int dimension = AskDimension();
                int length = AskLength();
                (int minRange, int maxRange) = AskRange();

                Console.WriteLine("----------------\n");

                if (dimension == 1)
                {
                    int[] arr = Create1DArray(length, minRange, maxRange);

                    int sum = GetSum(arr);
                    float avg = GetAverage(arr);
                    int max = GetMax(arr);
                    int min = GetMin(arr);

                    Print1D(arr, sum, avg, max, min);
                }
                else
                {
                    int[,] arr2D = Create2DArray(length, minRange, maxRange);

                    int sum = GetSum2D(arr2D);
                    float avg = GetAverage2D(arr2D);
                    int max = GetMax2D(arr2D);
                    int min = GetMin2D(arr2D);

                    Print2D(arr2D, sum, avg, max, min);
                }

                Console.WriteLine("\n\nTo restart type 'y': ");
                startProgram = Console.ReadLine().ToLower();

                Console.WriteLine("\n--------------------\n");
            }
        }

        // INPUT METHODS
        static int AskDimension()
        {
            int dimension;
            do
            {
                Console.Write("Dimensions (1 or 2): ");
            } while (!int.TryParse(Console.ReadLine(), out dimension) || (dimension != 1 && dimension != 2));

            return dimension;
        }

        static int AskLength()
        {
            int length;
            do
            {
                Console.Write("Array length: ");
            } while (!int.TryParse(Console.ReadLine(), out length) || length <= 0);

            return length;
        }

        static (int, int) AskRange()
        {
            int minRange, maxRange;

            do
            {
                Console.Write("Min value: ");
            } while (!int.TryParse(Console.ReadLine(), out minRange));

            do
            {
                Console.Write("Max value: ");
            } while (!int.TryParse(Console.ReadLine(), out maxRange) || maxRange <= minRange);

            return (minRange, maxRange);
        }

        // ARRAY CREATION
        static int[] Create1DArray(int length, int minRange, int maxRange)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
                arr[i] = Random.Shared.Next(minRange, maxRange + 1);

            return arr;
        }

        static int[,] Create2DArray(int length, int minRange, int maxRange)
        {
            int[,] arr = new int[length, length];
            for (int row = 0; row < length; row++)
                for (int col = 0; col < length; col++)
                    arr[row, col] = Random.Shared.Next(minRange, maxRange + 1);

            return arr;
        }

        // 1D MATH
        static int GetSum(int[] arr)
        {
            int sum = 0;
            foreach (int element in arr) sum += element;
            return sum;
        }

        static float GetAverage(int[] arr)
        {
            return (float)GetSum(arr) / arr.Length;
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int element in arr) if (element > max) max = element;
            return max;
        }

        static int GetMin(int[] arr)
        {
            int min = arr[0];
            foreach (int element in arr) if (element < min) min = element;
            return min;
        }

        // 2D MATH
        static int GetSum2D(int[,] arr)
        {
            int sum = 0;
            foreach (int element in arr) sum += element;
            return sum;
        }

        static float GetAverage2D(int[,] arr)
        {
            int total = arr.GetLength(0) * arr.GetLength(1);
            return (float)GetSum2D(arr) / total;
        }

        static int GetMax2D(int[,] arr)
        {
            int max = arr[0, 0];
            foreach (int element in arr) if (element > max) max = element;
            return max;
        }

        static int GetMin2D(int[,] arr)
        {
            int min = arr[0, 0];
            foreach (int element in arr) if (element < min) min = element;
            return min;
        }

        // PRINT METHODS
        static void Print1D(int[] arr, int sum, float avg, int max, int min)
        {
            Console.WriteLine("1D Array:");
            foreach (int element in arr) Console.Write(element + " ");
            Console.WriteLine($"\n\nSum={sum} Avg={avg} Max={max} Min={min}");
        }

        static void Print2D(int[,] arr, int sum, float avg, int max, int min)
        {
            Console.WriteLine("2D Array:\n");
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                    Console.Write(arr[row, col] + " ");
                Console.WriteLine();
            }

            Console.WriteLine($"\nSum={sum} Avg={avg} Max={max} Min={min}");
        }
    }
}
