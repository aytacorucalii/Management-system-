using System;
using LibraryManagementSystem.Helper;
using LibraryManagementSystem.Helpers;

namespace LibraryManagementSystem.Models
{
    public class LibraryCatalog
    {
        private LibraryItem[] items; 
        private int currentSize; 
        private const int InitialSize = 2; 

        public LibraryCatalog()
        {
            items = new LibraryItem[InitialSize]; 
            currentSize = 0; 
        }

       
        public void AddItem(LibraryItem item)
        {
            if (currentSize >= items.Length)
            {
                ResizeArray(); 
            }

            items[currentSize] = item; 
            currentSize++; 
        }

        private void ResizeArray()
        {
            int newSize = items.Length * 2; 
            LibraryItem[] newArray = new LibraryItem[newSize]; 

            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }

        public LibraryItem GetItemById(int id)
        {
            for (int i = 0; i < currentSize; i++)
            {
                if (items[i] != null && items[i].Id == id) 
                {
                    return items[i];
                }
            }

            throw new CustomBookError($"ID {id} olan kitab kataloqda tapılmadı."); 
        }
    }
}
