
// ამოცანები: 
// 1. ვისაც არ გქონდათ გაკეთებული, დაასრულეთ While ოპერატორით.
// 2. იპოვეთ ეს მნიშვნელობები ერთ for ციკლში.
// 3. გააკეთეთ იგივე ფუნქციონალობა ცალ-ცალკე ლუწებისთვის და კენტებისთვის.

namespace _20251031
{
    internal class Program
    {
        static void Main()
        {
            string startProgramm = "yes";
            while (startProgramm == "yes")
            {
                Console.Write("Enter SIZE of Array: ");
                int arraySize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter BOTTOM value for arr components: ");
                int arrRandomBottom = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter TOP value for arr components: ");
                int arrRandomTop = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[arraySize];
                int arrLength = arr.Length;
                int arrSum = 0;
                int arrMax = arrRandomBottom;
                int arrMin = arrRandomTop;

                // მასივის შემოწმება Null-ზე
                if (arrLength == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("0 element array has no Sum, no Average Mean, no Max and no Min");
                }

                if (arrLength != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("generated array elements are:");
                    for (int arrIndex = 0; arrIndex < arrLength; arrIndex++)
                    {
                        // მასივის ელემენტებთ შევსება
                        arr[arrIndex] = Random.Shared.Next(arrRandomBottom, arrRandomTop);
                        Console.WriteLine($"arr[{arrIndex}] = {arr[arrIndex]}");

                        // მასივის რიცხვთა ჯამი.
                        arrSum += arr[arrIndex];

                        // Max
                        if (arr[arrIndex] > arrMax)
                        {
                            arrMax = arr[arrIndex];
                            
                        }
                        // Min
                        if (arr[arrIndex] < arrMin)
                        {
                            arrMin = arr[arrIndex];
                        }
                    }

                    // მასივის რიცხვთა ჯამი.
                    Console.WriteLine();
                    Console.Write("array Sum is ");
                    Console.WriteLine(arrSum);

                    // მასივის რიცხვთა საშუალო არითმეტიკული.
                    float avrg = (float)arrSum / arrLength;
                    Console.WriteLine();
                    Console.Write("arithmetic mean is ");
                    Console.WriteLine(avrg);

                    // მასივის მაქსიმალური
                    Console.WriteLine();
                    Console.Write("MAXIMAL number is ");
                    Console.WriteLine(arrMax);

                    // მინიმალური მნიშვნელობები.
                    Console.WriteLine();
                    Console.Write("MINIMAL number is ");
                    Console.WriteLine(arrMin);

                }

                // პროგრამის ხელახლა გაშვება
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("restart programm type 'yes': ");
                startProgramm = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
