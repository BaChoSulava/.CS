namespace G18_20251109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 10;
            int cols = 8;
            int[,] x = new int[rows, cols];

            int totalElements = rows * cols;

            // Fill the 2D array with unique random numbers
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    x[i, j] = Random.Shared.Next(0, 30); // pick range large enough
                    bool duplicateFound = false;

                    // Check for duplicates in already-filled cells
                    for (int m = 0; m <= i; m++)
                    {
                        for (int n = 0; n < (m == i ? j : cols); n++)
                        {
                            if (x[i, j] == x[m, n])
                            {
                                duplicateFound = true;
                                break;
                            }
                        }
                        if (duplicateFound) break;
                    }

                    // If duplicate found, retry same cell
                    if (duplicateFound)
                        j--;
                }
            }

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{x[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
