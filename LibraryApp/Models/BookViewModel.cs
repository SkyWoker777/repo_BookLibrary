using LibraryApp.Core;
using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class BookViewModel
    {
        public IEnumerable<Book> BooksList { get; private set; }

        private BookHelper _helper;

        public BookViewModel()
        {
            _helper = new BookHelper(new Repository());
            BooksList = _helper.GetBooks();
        }
    }
}
