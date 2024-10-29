using System;

namespace LibraryManagementSystem.Models
{
    public class Librarian : Person 
    {
        public DateTime HireDate { get; set; }
        public Librarian(string name, DateTime hireDate) : base(name)
        {
            HireDate = hireDate;
        }
        public override string ToString()
        {
            return $"Kitabxanaçının Adı: {Name}, İşə Götürülmə Tarixi: {HireDate}";
        }
    }
}
