using LibraryManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Services
{
    public class BookService : IBookService
    {
        public static List<BookService> bookServices;
        private readonly int Id;

        public BookService()
        {
            bookServices = new List<BookService>();
        }
        public void CreateLibrarian(Book bookService)
        {
            bookServices.Add(bookService);
        }

        public void DeleteLibrarian(int id, bool IsSoftDelete)
        {
            int index = -1;
            for (int i = 0; i < bookServices.Count; i++)
            {
                if (id == bookServices[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                //softD
            }
            else
            {
                throw new Exception($"books list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden Delete prosesi yekunlasmadi");
            }
        }

       
     

        List<Book> IBookService.GetAllLibrarians()
        {
            return bookServices;
        }

        Book IBookService.GetLibrarianById(int id)
        {
            int index = -1;
            for (int i = 0; i < bookServices.Count; i++)
            {
                if (id == bookServices[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                return bookServices[index];
            }
            else
            {
                throw new Exception($"Librarians list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden geriye deyer qaytarila bilmedi.");
            };
        }
    }

       
}
