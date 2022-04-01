using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Book
    {
        private static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book()
        {
            _no++;
            No = _no;
        }
    }
}
