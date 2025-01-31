using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    internal class LibraryEngine
    {

        public static void ProcessBooks(List<Book> bList, BookFuncDelegate fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr (B));
            }
        }




    }
}
