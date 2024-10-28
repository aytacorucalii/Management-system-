using System;
using LibraryManagementSystem.Helpers;

namespace LibraryManagementSystem.Models
{
    public class Book : LibraryItem
    {

        public BookJenre Genre { get; set; }
        public LibraryLocation Location { get; set; }

        public Book(string title, int? publicationYear, BookJenre genre, LibraryLocation location)
            : base(title, publicationYear)
        {
            Genre = genre;
            Location = location;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Kitab: {Title}, Nəşr ili: {PublicationYear}, Janr: {Genre}, Koridor: {Location.Aisle}, Rəf: {Location.Shelf}");
        }

        internal object ToTitleCase()
        {
            throw new NotImplementedException();
        }
    }
}
