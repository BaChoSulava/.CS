namespace G18_2025_12_11
{
    internal class Program
    {
        static void Main()
        {
            int[] x = { 1, 2, 9, 3, 4, 5, 3 };
            int[] y = { 5, 6, 7, 2, 7, 1 };

            //int[] z = x.Concat(y).ToArray();
            //int[] z = x.Union(y).ToArray();
            //int[] z = x.Except(y).ToArray();
            //int[] z = x.Intersect(y).ToArray();
            //int[] z = x.Distinct().ToArray();

            int[] z = Union(x, y);

            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine(z[i]);
            }
        }

        static int[] Union(int[] a, int[] b)
        {
            int count = 0;
            bool present = false;
            int[] unionArray = new int {a.Length};
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        present = true;
                    }
                }
                if (!present)
                {
                    unionArray[count] = a[i];
                    count++;
                }
            }
            return Resize(ref unionArray, count);
            
        }

        //static int[] Except(int[] a, int[] b)
        //{

        //    int exceptArray = 
        //}

        //static int[] Intersect(int[] a, int[] b)
        //{

        //}

        static int[] Concat(int[] a, int[] b)
        {
            int[] concatArray = new int[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                concatArray[i] = a[i];
            }

            for (int j = 0; j < b.Length; j++)
            {
                concatArray[a.Length + j] = b[j];
            }

            return concatArray;
        }

        //static int[] Distinct(int[] a)
        //{

        //}


        static void Resize(ref int[] array, int newSize)
        {
            string[] resizedArray = new string[newSize];

            int lengthToCopy = Math.Min(array.Length, newSize);

            for (int index = 0; index < lengthToCopy; index++)
            {
                resizedArray[index] = array[index];
            }

            array = resizedArray;
        }
    }
}
