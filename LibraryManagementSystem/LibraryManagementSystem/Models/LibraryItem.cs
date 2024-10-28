using System;

namespace LibraryManagementSystem.Models
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public int? PublicationYear { get; set; }
        public int Id { get;  set; }

        protected LibraryItem(string title, int? publicationYear = null)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Başlıq boş ola bilməz.");
            }

            Title = title;
            PublicationYear = publicationYear;
        }
        public abstract void DisplayInfo();
    }
}
