namespace _20251113
{
    // TODO: დავწეროთ კოდი რომელიც შემოაბრუნებს მასივს 90 გრადუსით.
    internal class Program
    {
        static void Main(string[] args)
        {
            string startProgram = "y";
            while (startProgram == "y")
            {
                // შემოგვაქვს განზომილებები.
                int xLength, yLength;
                int randomMin, randomMax;

                do
                {
                    Console.Write("array-X length: ");
                    xLength = Convert.ToInt32(Console.ReadLine());
                    Console.Write("array-Y length: ");
                    yLength = Convert.ToInt32(Console.ReadLine());

                    if (xLength <= 0 || yLength <= 0)
                    {
                        Console.WriteLine("Invalid length range. Please try again.");
                    }
                } while (xLength <= 0 || yLength <= 0);


                do
                {
                    Console.Write("random MIN value: ");
                    randomMin = Convert.ToInt32(Console.ReadLine());
                    Console.Write("random MAX value: ");
                    randomMax = Convert.ToInt32(Console.ReadLine());

                    if (randomMin >= randomMax)
                    {
                        Console.WriteLine("Invalid random range. Please try again.");
                    }
                    else if (randomMax - randomMin < xLength * yLength)
                    {
                        Console.WriteLine("The range is too small to fill the array with unique values. Please try again.");
                    }

                } while (randomMin >= randomMax || randomMax - randomMin < xLength * yLength);



                // ვქმნით პირველ სიმრავლეს და ვავსებთ random ელემენტებით
                int[,] firstArray = new int[xLength, yLength];
                Console.WriteLine();
                Console.WriteLine("First Array: ");
                Console.WriteLine("---------------------------------");
                for (int i = 0; i < firstArray.GetLength(0); i++)
                {
                    for (int j = 0; j < firstArray.GetLength(1); j++)
                    {
                        firstArray[i, j] = Random.Shared.Next(randomMin, randomMax);
                        Console.Write(firstArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                // ვქმნით მეორე სიმრავლეს და 90-გრადუსით ვავსებთ მას 
                int[,] secondArray = new int[yLength, xLength];
                Console.WriteLine();
                Console.WriteLine("Second Array (Rotated 90 degrees): ");
                Console.WriteLine("---------------------------------");
                for (int i = 0; i < xLength; i++)
                {
                    for (int j = 0; j < yLength; j++)
                    {
                        secondArray[j, xLength - 1 - i] = firstArray[i, j];
                    }
                }

                // დაბეჭდვა
                for (int i = 0; i < secondArray.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray.GetLength(1); j++)
                    {
                        Console.Write(secondArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }


                // პროგრამის ხელახლა დაწყება
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("To restart type 'y': ");
                startProgram = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
