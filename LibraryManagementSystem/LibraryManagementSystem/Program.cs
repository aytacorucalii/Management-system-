
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

           
            Book book1 = new Book("Xeste Ruhlar", 2015, BookJenre.Fiction, location1);
            Book book2 = new Book("Muthiss psklj", 2021, BookJenre.NonFiction, location2);

            DVD dvd1 = new DVD("DVD1", 2010);
            DVD dvd2 = new DVD("DVD2 ", 2020);

        
            Magazine magazine1 = new Magazine("MAgazine1", 2022);
            Magazine magazine2 = new Magazine("Magazine2", 2023);

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



            try
            {
                
            }
            catch (CustomBookError ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

            int bookAge = book1.CalculateAge();
            Console.WriteLine($"'{book1.Title}' kitabının yaşı: {bookAge} il");

            Console.WriteLine($"'{book1.Title}' başlığı küçük harflerle: {book1.ToTitleCase()}");
        }
    }
}
