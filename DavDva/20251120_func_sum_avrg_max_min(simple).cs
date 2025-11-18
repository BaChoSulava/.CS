namespace _20251120
{
    // TODO: 
    // 1. GetSum - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ელემენტების ჯამს.
    // 2. GetAverage - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ელემენტების საშუალო მნიშვნელობას.
    // 3. GetMax - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ყველაზე დიდ ელემენტს.
    // 4. GetMin - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ყველაზე პატარა ელემენტს.
    // 5. გააკეთეთ იგივე ორ განზომილებიანი მასივებისთვისაც.
    internal class Program
    {
        static void Main()
        {
            // საწყისი მონაცემები
            int[] arr = { 1, 2, 3, 4, 5 };
            int[,] arr2D = { { 1, 2, 3 }, { 4, 5, 6 } };

            // 1. GetSum - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ელემენტების ჯამს.
            int sum = GetSum(arr);
            // 2D
            int sum2D = GetSum2D(arr2D);

            // 2. GetAverage - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ელემენტების საშუალო მნიშვნელობას.
            float average = GetAverage(arr);
            // 2D
            float average2D = GetAverage2D(arr2D);

            // 3. GetMax - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ყველაზე დიდ ელემენტს.
            int max = GetMax(arr);
            // 2D
            int max2D = GetMax2D(arr2D);

            // 4. GetMin - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ყველაზე პატარა ელემენტს.
            int min = GetMin(arr);
            // 2D
            int min2D = GetMin2D(arr2D);

            // შედეგის ამობეჭდვა
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"2D Sum: {sum2D}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"2D Average: {average2D}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"2D Max: {max2D}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"2D Min: {min2D}");
        }


        // 1. GetSum - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ელემენტების ჯამს.
        static int GetSum(int[] arr)
        {
            int sum = 0;
            foreach (int number in arr)
            {
                sum += number;
            }
            return sum;
        }

        // 2D
        static int GetSum2D(int[,] arr2D)
        {
            int sum2D = 0;
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                for (int col = 0; col < arr2D.GetLength(1); col++)
                {
                    sum2D += arr2D[row, col];
                }
            }
            return sum2D;
        }

        // 2. GetAverage - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ელემენტების საშუალო მნიშვნელობას.
        static float GetAverage(int[] arr)
        {
            return (float)GetSum(arr) / arr.Length;
        }

        // 2D
        static float GetAverage2D(int[,] arr2D)
        {
            return (float)GetSum2D(arr2D) / (arr2D.GetLength(0) * arr2D.GetLength(1));
        }

        // 3. GetMax - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ყველაზე დიდ ელემენტს.
        static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        // 2D
        static int GetMax2D(int[,] arr2D)
        {
            int max2D = arr2D[0, 0];
            for (int row=0; row<arr2D.GetLength(0); row++)
            {
                for (int col=0; col<arr2D.GetLength(1); col++)
                {
                    if (max2D < arr2D[row, col])
                    {
                        max2D =  arr2D[row, col];
                    }
                }
            }
            return max2D;
        }

        // 4. GetMin - რომელიც მიიღებს int მასივს და დააბრუნებს მასივში ყველაზე პატარა ელემენტს.
        static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        // 2D
        static int GetMin2D(int[,] arr2D)
        {
            int min2D = arr2D[0, 0];
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                for (int col = 0; col < arr2D.GetLength(1); col++)
                {
                    if (min2D > arr2D[row, col])
                    {
                        min2D = arr2D[row, col];
                    }
                }
            }
            return min2D;
        }
    }
}
