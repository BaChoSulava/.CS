namespace _20251109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[10, 8];

            // TODO: Fill the array with random unique numbers
            for (int row = 0; row < x.GetLength(0); row++)
            {
                for (int colomn = 0; colomn < x.GetLength(1); colomn++)
                {
                    x[row, colomn] = Random.Shared.Next(10, 100);

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < colomn; j++)
                        {
                            if (x[i, j] == x[row, colomn])
                            {
                                j--;
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write($"{x[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
