
using System;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Helpers;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
         
            LibraryLocation location1 = new LibraryLocation(1, 2);
            LibraryLocation location2 = new LibraryLocation(2, 3);

           
            Book book1 = new Book("The Great Gatsby", 1925, BookJenre.Fiction, location1);
            Book book2 = new Book("Sapiens: A Brief History of Humankind", 2011, BookJenre.NonFiction, location2);

            DVD dvd1 = new DVD("Inception", 2010);
            DVD dvd2 = new DVD("The Matrix", 1999);

        
            Magazine magazine1 = new Magazine("National Geographic", 2022);
            Magazine magazine2 = new Magazine("Time", 2023);

            Console.WriteLine("Booklar:");
            book1.DisplayInfo();
            book2.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("DVD'ler:");
            dvd1.DisplayInfo();
            dvd2.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Magazinlr:");
            magazine1.DisplayInfo();
            magazine2.DisplayInfo();
            Console.WriteLine();

         
            int bookAge = book1.CalculateAge();
            Console.WriteLine($"'{book1.Title}' kitabının yaşı: {bookAge} il");

            Console.WriteLine($"'{book1.Title}' başlığı küçük harflerle: {book1.ToTitleCase()}");
        }
    }
}
