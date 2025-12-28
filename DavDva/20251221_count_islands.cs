
namespace G17_20221227
{
    internal class Program
    {
        static void Main()
        {
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

                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        if (sea[x, y] == 1)
                        {
                            count++;
                            Flood(sea, x, y);
                        }
                    }
                }
                return count;
            }

            static void Flood(int[,] sea, int x, int y)
            {
                int rows = sea.GetLength(0);
                int cols = sea.GetLength(1);

                if (x < 0 || y < 0 || x >= rows || y >= cols) return;
                if (sea[x, y] == 0) return;

                sea[x, y] = 0;

                /*
                 * [-1, -1] [-1,  0] [-1,  1]
                 * [ 0, -1]   (x,y)  [ 0,  1]
                 * [ 1, -1] [ 1,  0] [ 1,  1]
                */

                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        if (dx != 0 || dy != 0)
                        {
                            Flood(sea, x + dx, y + dy);
                        }
                    }
                }
            }
        }

    }
}
