using System;
using System.Collections.Generic;
using System.IO;

namespace BookLibraryManager
{

    internal class Program
    {
        static void Main()
        {

        
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string title, double price)
        {
            _ = Title;
            _ = Price;
        }

        public override string ToString()
        {
            return $"{Title} - {Price} GEL";
        }
    }

    public static class LibraryHelper
    {

    }
}