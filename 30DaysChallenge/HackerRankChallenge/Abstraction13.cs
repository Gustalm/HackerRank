using System;

namespace _30DaysChallenge
{
    internal class MyBook
    {

        public MyBook(string title, string author, int price)
        {
            Price = price;
        }

        public int Price { get; }

        public void display()
        {
            Console.WriteLine($"Title: ");
            Console.WriteLine($"Author: ");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
