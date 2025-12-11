namespace G18_2025_12_11
{
    internal class Resize_Reverse
    {
        static void Main()
        {
            string[] names = { "Alice", "Bob", "Charlie", "Diana" };

            Resize(ref names, names.Length + 1);
            names[4] = "Chuck";

            names = Reverse(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Name {i + 1}: {names[i]}");
            }
        }

        static void Resize(ref string[] array, int newSize)
        {
            string[] resizedArray = new string[newSize];

            int lengthToCopy = Math.Min(array.Length, newSize);

            for (int index = 0; index < lengthToCopy; index++)
            {
                resizedArray[index] = array[index];
            }

            array = resizedArray; 
        }

        // string method
        //static string[] Reverse(string[] array)
        //{
        //    string[] reversedArray = new string[array.Length];

        //    for (int index = 0; index < array.Length; index++)
        //    {
        //        reversedArray[index] = array[array.Length - index - 1];
        //    }

        //    return reversedArray;
        //}


        // void method
        static void ReverseInPlace(string[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                (array[left], array[right]) = (array[right], array[left]);
                left++;
                right--;
            }
        }
    }
}
