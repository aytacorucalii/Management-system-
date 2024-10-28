using LibraryManagementSystem.Models;
using System;

namespace LibraryManagementSystem.Helpers
{
    public static class LibraryHelper
    {

        public static int CalculateAge(this LibraryItem item)
        {

            if (item.PublicationYear != null)
            {

                int currentYear = DateTime.Now.Year;


                int publicationYear = item.PublicationYear.Value;
                int age = currentYear - publicationYear;
                return age;
            }

            return 0;
        }

        static string ToTitleCase(this LibraryItem item)
        {
                if (item.Title == null)
                {
                return null;
                }
            return item.Title.ToLower();


           
        }
        
    }
}