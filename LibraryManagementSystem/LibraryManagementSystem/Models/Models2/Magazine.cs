using System;

namespace LibraryManagementSystem.Models
{
    public class Magazine : LibraryItem
    {
        public Magazine(string title, int? publicationYear = null) : base(title, publicationYear)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Başlıq: {Title}, Buraxılış ili: {PublicationYear}");
        }
    }
}
