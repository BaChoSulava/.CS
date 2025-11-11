namespace G18_20251109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // მასივის შექმნა
            int a = 2;
            int b = 2;
            int[,] x = new int[a, b];

            // მასივის შევსება უნიკალური რიცხვებით
            for (int row = 0; row < a; row++)
            {
                for (int col = 0; col < b; col++)
                {
                    bool duplicateFound;
                    do
                    {
                        x[row, col] = Random.Shared.Next(10, 15);

                        // გადამოწმება უნიკალურობაზე
                        duplicateFound = false;
                        for (int m = 0; m <= row; m++)
                        {
                            for (int n = 0; n < (m == row ? col : b); n++)
                            {
                                if (x[row, col] == x[m, n])
                                {
                                    duplicateFound = true;
                                    break;
                                }
                            }
                            if (duplicateFound) break;
                        }
                    }
                    while (duplicateFound);
                }
            }

            // მასივის დაბეჭდვა
            Console.WriteLine("Unique 2D array:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{x[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
