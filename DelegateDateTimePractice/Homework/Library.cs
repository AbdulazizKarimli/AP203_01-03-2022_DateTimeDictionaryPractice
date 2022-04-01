using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Library
    {
        public List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> filteredBooks = new List<Book>();
            foreach (Book book in _books)
            {
                if(book.Name.Contains(value))
                    filteredBooks.Add(book);
            }
            return filteredBooks;
        }
        public void RemoveAllBookByName(string value)
        {
            foreach (var book in _books)
            {
                if (book.Name.Contains(value))
                    _books.Remove(book);
            }
        }
        public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
        {
            List<Book> filteredBooks = new List<Book>();
            foreach (var book in _books)
            {
                if(book.PageCount >= minPageCount && book.PageCount <= maxPageCount)
                    filteredBooks.Add(book);
            }

            return filteredBooks;
        }
        public void RemoveByCode(int no)
        {
            foreach (var book in _books)
            {
                if(book.No == no)
                    _books.Remove(book);    
            }
        }
        public List<Book> SearchBooks(string search)
        {
            List<Book> filteredBooks = new List<Book>();
            foreach (var book in _books)
            {
                if(book.AuthorName == search || book.Name == search || book.PageCount.ToString() == search)
                {
                    filteredBooks.Add(book);
                }
            }
            return filteredBooks;
        }
    }
}
