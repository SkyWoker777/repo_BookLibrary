using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core
{
    public class BookHelper
    {
        private IRepository _repository;

        public BookHelper(IRepository repo)
        {
            _repository = repo;
        }

        private int SetId()
        {
            int id = 1;
            if (_repository.Books.Count() != 0)
            {
                return _repository.Books.Max(x => x.ID + 1);
            }
            return id;
        }

        public void AddBook(string name, string author, int? year)
        {
            var book = new Book();
            book.Name = name;
            book.Author = author;
            book.Year = year;
            book.ID = SetId();
            _repository.Add(book);
        }

        public Book EditBook(int id, string name, string author, int? year)
        {
            var book = GetBook(id);
            book.Name = name;
            book.Author = author;
            book.Year = year;
            _repository.Add(book);
            return book;
        }

        public void DeleteBook(int id)
        {
            var book = GetBook(id);
            _repository.Delete(book);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _repository.Books;
        }
        public Book GetBook(int id)
        {
            return GetBooks().First(b => b.ID == id);
        }
    }
}
