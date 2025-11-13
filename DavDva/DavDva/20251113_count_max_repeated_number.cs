namespace _20251113
{
    // TODO: მომიძებეთ და დამიწერეთ ეკრანზე რიცხვი რომელიც ყველაზე მეტჯერ განმეორდა მიყოლებით მასივში. 
    // თუ ესეთი რიცხვი ერთზე მეტია, დაბეჭდეთ რომელიმე ერთი მათგანი.
    internal class Program
    {
        static void Main(string[] args)
        {
            string startProgram = "y";
            while (startProgram == "y")
            {
                int[] arr = { 1, 2, 2, 2, 2, 7, 0, 3, 3, 4, 4, 4, 3, 4, 5, 6 };     //?? როგორ შევქმნა მასივი ReadLine-ით?
                int arrLength = arr.Length;

                // ცარიელი მასივის შემოწმება
                if (arrLength == 0)
                {
                    Console.WriteLine("Empty array");

                }
                else
                {
                    // საწყისი ცვლადები
                    int correntCount = 1;
                    int maxNumber = arr[0];
                    int maxCount = 1;


                    // მაქსიმალური განმეორების ძებნა
                    if (arrLength > 1)
                    {
                        for (int i = 1; i < arrLength; i++)
                        {
                            if (arr[i] == arr[i - 1])
                            {
                                correntCount++;
                                if (correntCount > maxCount)
                                {
                                    maxCount = correntCount;
                                    maxNumber = arr[i];
                                }
                            }
                            else
                            {
                                correntCount = 1;
                            }
                        }
                    }

                    // სიმრავლის დაბეჭდვა
                    string plural = maxCount > 1 ? "s are" : " is";
                    Console.Write ($"Array element{plural}: ");
                    for (int i = 0; i < arrLength; i++)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    // შედეგის დაბეჭდვა
                    plural = maxCount > 1 ? "s" : "";
                    Console.WriteLine($"Most repeated number is {maxNumber} ({maxCount}-time{plural})");
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
