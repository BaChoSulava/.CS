namespace _20251109
{
    // TODO: დავწეროთ კოდი რომელიც შემოაბრუნებს მასივს 90 გრადუსით.
    internal class Program
    {
        static void Main(string[] args)
        {
            // შემოგვაქვს სიმრავლის განზომილებები.
            int a = 4, b = 4;

            // ვქმნით სიმრავლეს და ვავსებთ ელემენტებით.
            int[,] firstArray = new int[a, b];
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(1); j++)
                {
                    firstArray[i, j] = Random.Shared.Next(10, 50);
                    Console.Write(firstArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // ვქმნით მეორე სიმრავლეს და 90-გრადუსით ვავსებთ მას 
            int[,] secondArray = new int[b, a];
            for (int i = 0; i < secondArray.GetLength(1); i++)
            {
                for (int j = 0; j < secondArray.GetLength(0); j++)
                {
                    secondArray[j, a - 1 - i] = firstArray[i, j];
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

            
        }
    }
}
