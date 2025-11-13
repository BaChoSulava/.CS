namespace _20251113
{
    // TODO: მომიძებეთ და დამიწერეთ ეკრანზე რიცხვი რომელიც ყველაზე მეტჯერ განმეორდა მიყოლებით მასივში. 
    // თუ ესეთი რიცხვი ერთზე მეტია, დაბეჭდეთ რომელიმე ერთი მათგანი.
    internal class Program
    {
        static void Main(string[] args)
        {
            // საწყისი ცვლადები
            int[] arr = { 1, 2, 2, 2, 2, 7, 0, 3, 3, 4, 4, 4, 3, 4, 5, 6 };
            int correntCount = 1;
            int maxNumber = arr[0];
            int maxCount = 1;

            // სიმრავლის ამობეჭდვა
            Console.WriteLine("Origin array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();


            // მაქსიმალური განმეორების ძებნა
            for (int i = 1; i < arr.Length; i++)
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

            // შედეგის დაბეჭდვა
            Console.WriteLine($"ყველაზე ხშირაც მეორდება რიცხვი {maxNumber}, მეორდება {maxCount}-ჯერ)");
        }
    }
}
