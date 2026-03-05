using System;

namespace G18_20260226
{
    internal class Program
    {
        static void Main()
        {
            Dog[] dogs = new Dog[]
            {
                new Dog { Name = "Buddy", Breed = "Labrador", Weight = 30 },
                new Dog { Name = "Max", Breed = "Bulldog", Weight = 25 },
                new Dog { Name = "Rocky", Breed = "German Shepherd", Weight = 35 },
                new Dog { Name = "Charlie", Breed = "Poodle", Weight = 10 },
            };

            ArrayHelper.Sort(dogs);

            for (int i = 0; i < dogs.Length; i++)
            {
                Console.WriteLine(dogs[i]);
            }
        }
    }

    class Dog : Comparable
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Breed: {Breed}, Weight: {Weight}kg";
        }

        public override int CompareTo(object obj)
        {
            if (obj is not Dog otherDog)
            {
                throw new InvalidOperationException("Object must be of type Dog.");
            }

            if (this.Weight > otherDog.Weight)
                return 1;
            if (this.Weight < otherDog.Weight)
                return -1;
            return 0;
        }
    }

    abstract class Comparable
    {
        public abstract int CompareTo(object obj);
    }

    static class ArrayHelper
    {
        public static void Sort(object[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] is not Comparable item)
                    {
                        throw new InvalidOperationException("Array elements must inherit from Comparable.");
                    }

                    if (item.CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
