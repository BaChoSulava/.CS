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

            int[] z = Distinct(x);

            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine(z[i]);
            }
        }


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

        static int[] Union(int[] a, int[] b)
        {
            int[] temp = new int[a.Length + b.Length];
            int count = 0;

            foreach (int x in a)
            {
                bool exists = false;
                for (int i = 0; i < count; i++)
                    if (temp[i] == x) exists = true;

                if (!exists)
                    temp[count++] = x;
            }

            foreach (int x in b)
            {
                bool exists = false;
                for (int i = 0; i < count; i++)
                    if (temp[i] == x) exists = true;

                if (!exists)
                    temp[count++] = x;
            }

            Resize(ref temp, count);
            return temp;
        }


        static int[] Except(int[] a, int[] b)
        {
            int[] temp = new int[a.Length];
            int count = 0;

            foreach (int x in a)
            {
                bool found = false;

                foreach (int y in b)
                {
                    if (x == y)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    bool exists = false;
                    for (int i = 0; i < count; i++)
                        if (temp[i] == x) exists = true;

                    if (!exists)
                        temp[count++] = x;
                }
            }

            Resize(ref temp, count);
            return temp;
        }


        //static int[] Intersect(int[] a, int[] b)
        //{

        //}



        static int[] Distinct(int[] a)
        {
            int[] temp = new int[a.Length];
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                bool exists = false;

                for (int j = 0; j < count; j++)
                {
                    if (temp[j] == a[i])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    temp[count++] = a[i];
                }
            }

            Resize(ref temp, count);
            return temp;
        }


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
