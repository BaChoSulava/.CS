namespace G18_2025_12_07
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

            int[] z = Concat(x, y);

            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine(z[i]);
            }
        }

        static int[] Union(int[] a, int[] b)
        {
            int[] c = Concat(a, b);
            for
        }

        //static int[] Except(int[] a, int[] b)
        //{

        //}

        //static int[] Intersect(int[] a, int[] b)
        //{

        //}

        static int[] Concat(int[] a, int[] b)
        {
            int[] concat = new int[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                concat[i] = a[i];
            }

            for (int j = 0; j < b.Length; j++)
            {
                concat[a.Length + j] = b[j];
            }

            return concat;
        }

        //static int[] Distinct(int[] a)
        //{

        //}
    }
}
