using System.Diagnostics.Metrics;

namespace G17_20221227
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] sea = new int[Random.Shared.Next(10, 20), Random.Shared.Next(10, 20)];

            GenerateIslands(sea);
            PrintIslands(sea);
            Console.WriteLine($"There is {CountIslands(sea)} islands");
        }


        static void GenerateIslands(int[,] sea)
        {
            for (int i = 0; i < sea.GetLength(0); i++)
            {
                for (int j = 0; j < sea.GetLength(1); j++)
                {
                    sea[i, j] = Random.Shared.Next(10) > 7 ? 1 : 0;
                }
            }
        }
        static void PrintIslands(int[,] sea)
        {
            for (int i = 0; i < sea.GetLength(0); i++)
            {
                for (int j = 0; j < sea.GetLength(1); j++)
                {
                    if (sea[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }

                    Console.Write($"{sea[i, j]} ");
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }

        static int CountIslands(int[,] sea)
        {
            int rows = sea.GetLength(0);
            int cols = sea.GetLength(1);
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (sea[i, j] == 1)
                    {
                        count++;
                        FloodFill(sea, i, j);
                    }
                }
            }

            return count;
        }


        static void FloodFill(int[,] sea, int x, int y)
        {
            int rows = sea.GetLength(0);
            int cols = sea.GetLength(1);

            if (x < 0 || y < 0 || x >= rows || y >= cols)
                return;

            if (sea[x, y] == 0)
                return;

            // Mark as visited
            sea[x, y] = 0;

            // Visit all 8 directions
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx != 0 || dy != 0)
                        FloodFill(sea, x + dx, y + dy);
                }
            }
        }

    }
}
