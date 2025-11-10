namespace _20251109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[10, 8];

            // TODO: Fill the array with random unique numbers
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = Random.Shared.Next(10, 100);
                    for (int k = 0; k < j; k++)
                    {
                        if (x[k,j] == x[i,j])
                        {
                            k--;
                            break;
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
