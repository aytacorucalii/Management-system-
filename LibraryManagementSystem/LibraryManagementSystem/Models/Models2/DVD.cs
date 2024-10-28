using System;
using System.IO;

namespace LibraryManagementSystem.Models
{
    public class DVD : LibraryItem
    {
        public DVD(string title, int? publicationYear = null) : base(title, publicationYear)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Başlıq: {Title}, Buraxılış ili: {PublicationYear}");
        }
    }
}
