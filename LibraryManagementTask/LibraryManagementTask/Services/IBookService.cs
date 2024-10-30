using LibraryManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Services
{
    public interface IBookService
    {
        Book GetLibrarianById(int id);
        List<Book> GetAllLibrarians();
        void CreateLibrarian(Book book);
        void DeleteLibrarian(int id, bool IsSoftDelete);
    }
}
