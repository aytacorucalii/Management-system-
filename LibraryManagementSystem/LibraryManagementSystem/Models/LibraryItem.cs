using System;

namespace LibraryManagementSystem.Models
{
    public abstract class LibraryItem : ILibrarianService
    {
        public string Title { get; set; }
        public int? PublicationYear { get; set; }
        public int Id { get; set; }

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

        public Librarian GetLibrarianById(int id)
        {
            foreach (var librarian in  )
            {
                if (librarian.Id == id)
                {
                    return librarian;
                }
            }
            //foreach (var item in Id)
            //{

            //}
            return null;
        }

        public Librarian GetAllLibrarians()
        {
            return LibraryItem;
        }

        public void CreateLibrarian(Librarian librarian)
        {
            throw new NotImplementedException();
        }

        public void DeleteLibrarian(Librarian librarian, bool IsSoftDelete)
        {
            if (!IsSoftDelete) {
                Console.WriteLine("yoxdur, tamamile silindi");
            }
            else {
                Console.WriteLine("soft delete");
        }
    }
}
