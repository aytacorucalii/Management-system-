using LibraryManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Services
{
    internal class LibraryMemberService : ILibraryMember
    {
        public static List<LibraryMemberService> libraryMemberService;

        public LibraryMemberService()
        {
            libraryMemberService = new List<LibraryMemberService>();
        }

        public int Id { get; private set; }

        public void CreateLibrarian(LibraryMember libraryMember)
        {
            libraryMemberService.Add(libraryMember);
        }

        public void DeleteLibrarian(int id, bool IsSoftDelete)
        {
            int index = -1;
            for (int i = 0; i < libraryMemberService.Count; i++)
            {
                if (id == libraryMemberService[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                //soft
            }
            else
            {
                throw new Exception($"Librarians list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden Delete prosesi yekunlasmadi");
            }
        }

        public List<LibraryMember> GetAllLibrarians()
        {
            return libraryMemberService;
        }

        public LibraryMember GetLibrarianById(int id)
        {
            int index = -1;
            for (int i = 0; i < libraryMemberService.Count; i++)
            {
                if (id == libraryMemberService[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                return libraryMemberService[index];
            }
            else
            {
                throw new Exception($"Librarians list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden geriye deyer qaytarila bilmedi.");
            }
        }
    }
}
