using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Models
{
    public class DVD : LibraryItem
    {
        public DVD(string title, int? publicationYear) : base(title, publicationYear)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Hello from DVD");
        }
    }
}
