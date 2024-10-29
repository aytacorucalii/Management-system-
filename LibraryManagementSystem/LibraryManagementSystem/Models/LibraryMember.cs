using System;

namespace LibraryManagementSystem.Models
{
    public sealed class LibraryMember : Person
    {
        public DateTime MembershipDate { get; set; }
        public LibraryMember(string name, DateTime membershipDate) : base(name)
        {
            MembershipDate = membershipDate;
        }
        public override string ToString()
        {
            return $"Kitabxana Üzvünün Adı: {Name}, Üzv Olma Tarixi: {MembershipDate}";
        }
    }
}
