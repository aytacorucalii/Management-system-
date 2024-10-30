using LibraryManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Services
{
    public interface ILibraryMember 
    {
        LibraryMember GetLibrarianById(int id);
        List<LibraryMember> GetAllLibrarians();
        void CreateLibrarian(LibraryMember libraryMember);
        void DeleteLibrarian(int id, bool IsSoftDelete);
    }
}
