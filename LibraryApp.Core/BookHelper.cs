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
