namespace _20251120
{
    internal class Program
    {
        static void Main()
        {
            int dimension = AskDimension();
            int length = AskLength();
            (int min, int max) = AskRange();

            if (dimension == 1)
            {
                int[] arr = Create1DArray(length, min, max);

                int sum = GetSum(arr);
                float avg = GetAverage(arr);
                int maxV = GetMax(arr);
                int minV = GetMin(arr);

                Print1D(arr, sum, avg, maxV, minV);
            }
            else
            {
                int[,] arr2D = Create2DArray(length, min, max);

                int sum = GetSum2D(arr2D);
                float avg = GetAverage2D(arr2D);
                int maxV = GetMax2D(arr2D);
                int minV = GetMin2D(arr2D);

                Print2D(arr2D, sum, avg, maxV, minV);
            }
        }

        // -------------------------------------------------------
        // INPUT METHODS
        // -------------------------------------------------------

        static int AskDimension()
        {
            int d;
            do
            {
                Console.Write("Dimensions (1 or 2): ");
            } while (!int.TryParse(Console.ReadLine(), out d) || (d != 1 && d != 2));

            return d;
        }

        static int AskLength()
        {
            int l;
            do
            {
                Console.Write("Array length: ");
            } while (!int.TryParse(Console.ReadLine(), out l) || l <= 0);

            return l;
        }

        static (int, int) AskRange()
        {
            int min, max;

            do
            {
                Console.Write("Min value: ");
            } while (!int.TryParse(Console.ReadLine(), out min));

            do
            {
                Console.Write("Max value: ");
            } while (!int.TryParse(Console.ReadLine(), out max) || max <= min);

            return (min, max);
        }

        // -------------------------------------------------------
        // ARRAY CREATION
        // -------------------------------------------------------

        static int[] Create1DArray(int length, int min, int max)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
                arr[i] = Random.Shared.Next(min, max + 1);

            return arr;
        }

        static int[,] Create2DArray(int length, int min, int max)
        {
            int[,] arr = new int[length, length];
            for (int r = 0; r < length; r++)
                for (int c = 0; c < length; c++)
                    arr[r, c] = Random.Shared.Next(min, max + 1);

            return arr;
        }

        // -------------------------------------------------------
        // 1D MATH
        // -------------------------------------------------------

        static int GetSum(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr) sum += x;
            return sum;
        }

        static float GetAverage(int[] arr) => (float)GetSum(arr) / arr.Length;

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int x in arr) if (x > max) max = x;
            return max;
        }

        static int GetMin(int[] arr)
        {
            int min = arr[0];
            foreach (int x in arr) if (x < min) min = x;
            return min;
        }

        // -------------------------------------------------------
        // 2D MATH
        // -------------------------------------------------------

        static int GetSum2D(int[,] arr)
        {
            int sum = 0;
            foreach (int x in arr) sum += x;
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
            foreach (int x in arr) if (x > max) max = x;
            return max;
        }

        static int GetMin2D(int[,] arr)
        {
            int min = arr[0, 0];
            foreach (int x in arr) if (x < min) min = x;
            return min;
        }

        // -------------------------------------------------------
        // PRINT
        // -------------------------------------------------------

        static void Print1D(int[] arr, int sum, float avg, int max, int min)
        {
            Console.WriteLine("1D Array:");
            foreach (int x in arr) Console.Write(x + " ");
            Console.WriteLine($"\nSum={sum} Avg={avg} Max={max} Min={min}");
        }

        static void Print2D(int[,] arr, int sum, float avg, int max, int min)
        {
            Console.WriteLine("2D Array:");
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                    Console.Write(arr[r, c] + " ");
                Console.WriteLine();
            }
            Console.WriteLine($"\nSum={sum} Avg={avg} Max={max} Min={min}");
        }
    }
}
