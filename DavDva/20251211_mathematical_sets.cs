namespace G18_2025_12_11
{
    internal class Program
    {
        static void Main()
        {
            int[] x = { 1, 2, 9, 3, 4, 5, 3 };
            int[] y = { 5, 6, 7, 2, 7, 1 };

            //int[] z = x.Concat(y).ToArray();      //done      //ყველა ელემენტების გაერთიანება
            //int[] z = x.Distinct().ToArray();      //done      //უნიკალური ელემენტები x-დან
            //int[] z = x.Union(y).ToArray();      //done       //უნიკალური ელემენტები ორივედან
            //int[] z = x.Except(y).ToArray();      //      //უნიკალური ელემენტები x-დან y-ის მიმართ
            //int[] z = x.Intersect(y).ToArray();      //      //საერთო ელემენტები


            int[] z = Intersect(x, y);

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

        static int[] Union(int[] a, int[] b)
        {
            return Distinct(Concat(a, b));
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


        static int[] Intersect(int[] a, int[] b)
        {
            //int[] temp = new int[Math.Min(a.Length, b.Length)];
            //int count = 0;

            //foreach (int x in a)
            //{
            //    bool foundInB = false;

            //    // Check if x exists in b
            //    foreach (int y in b)
            //    {
            //        if (x == y)
            //        {
            //            foundInB = true;
            //            break;
            //        }
            //    }

            //    if (foundInB)
            //    {
            //        // Prevent duplicates
            //        bool exists = false;
            //        for (int i = 0; i < count; i++)
            //        {
            //            if (temp[i] == x)
            //            {
            //                exists = true;
            //                break;
            //            }
            //        }

            //        if (!exists)
            //        {
            //            temp[count++] = x;
            //        }
            //    }
            //}

            //Resize(ref temp, count);
            //return temp;
            int[] temp = new int[a.Length + b.Length];
            int count = 0;

            for (int i=0; i<a.Length; i++)
            {
                bool exist = false;
                for (int j=0; j<b.Length)
                {

                }
            }
        }




        


        static void Resize(ref int[] array, int newSize)
        {
            int[] resizedArray = new int[newSize];

            int lengthToCopy = Math.Min(array.Length, newSize);

            for (int i = 0; i < lengthToCopy; i++)
            {
                resizedArray[i] = array[i];
            }

            array = resizedArray;
        }
    }
}
