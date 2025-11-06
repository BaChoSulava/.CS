namespace _20251106
{
    // gamiketet igive amocanebi oyond or ganzomilebian masivze.
    // sum avg min max
    // aseve luwebi da kentebi cal calke
    internal class Program
    {
        static void Main(string[] args)
        {
            string start = "y";
            while (start == "y")
            {
                Console.Write("number of Rows: ");
                int row = Convert.ToInt32(Console.ReadLine());

                Console.Write("number of Colooms: ");
                int colomn = Convert.ToInt32(Console.ReadLine());

                Console.Write("numbers min range: ");
                int limitDown = Convert.ToInt32(Console.ReadLine());

                Console.Write("numbers Max range: ");
                int limitUp = Convert.ToInt32(Console.ReadLine());

                int[,] x = new int[row, colomn];
                int sum = 0;
                int max = limitDown;
                int min = limitUp;
                int? evenMax = null;
                int? evenMin = null;
                bool evenExists = false;
                int evenSum = 0;
                int? oddMax = null;
                int? oddMin = null;
                bool oddExists = false;
                int oddSum = 0;

                Console.WriteLine();
                for (int i = 0; i < x.GetLength(0); i++)
                {
                    for (int j = 0; j < x.GetLength(1); j++)
                    {
                        x[i, j] = Random.Shared.Next(limitDown, limitUp);
                        Console.Write($"{x[i, j]} ");

                        sum += x[i, j];

                        if (max < x[i, j]) max = x[i, j];
                        if (min > x[i, j]) min = x[i, j];

                        if (x[i, j] % 2 == 0)
                        {
                            evenExists = true;
                            evenSum += x[i, j];
                            if (evenMax == null || x[i, j] > evenMax) evenMax = x[i, j];
                            if (evenMin == null || x[i, j] < evenMin) evenMin = x[i, j];
                        }
                        else
                        {
                            oddExists = true;
                            oddSum += x[i, j];
                            if (oddMax == null || x[i, j] > oddMax) oddMax = x[i, j];
                            if (oddMin == null || x[i, j] < oddMin) oddMin = x[i, j];
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.Write("Sum: ");
                Console.WriteLine(sum);

                Console.Write("Avrg: ");
                Console.WriteLine((float)sum / (x.GetLength(0) * x.GetLength(1)));

                Console.Write("Max: ");
                Console.WriteLine(max);

                Console.Write("Min: ");
                Console.WriteLine(min);

                Console.Write("Even Sum: ");
                Console.WriteLine(evenSum);

                Console.Write("Odd Sum: ");
                Console.WriteLine(oddSum);


                if (evenExists)
                {
                    if (evenMax.HasValue)
                    {
                        Console.Write("There is Even number and it's Max value is: ");
                        Console.WriteLine(evenMax);
                    }
                    if (evenMin.HasValue)
                    {
                        Console.Write("There is Even number and it's Min value is: ");
                        Console.WriteLine(evenMin);
                    }
                }
                else
                {

                    Console.Write("there is no Even number");
                }

                if (oddExists)
                {
                    if (oddMax.HasValue)
                    {
                        Console.Write("There is Odd number and it's Max value is: ");
                        Console.WriteLine(oddMax);
                    }
                    if (oddMin.HasValue)
                    {
                        Console.Write("There is Odd number and it's Min value is: ");
                        Console.WriteLine(oddMin);
                    }
                }
                else
                {

                    Console.Write("there is no Odd number");
                }

                Console.WriteLine(); 
                Console.WriteLine();
                Console.Write("to restart type 'y': ");
                start = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("-------------------");
                Console.WriteLine();
            }
            
        }
    }
}
