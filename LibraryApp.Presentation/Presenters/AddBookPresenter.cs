using LibraryApp.Core;
using LibraryApp.Core.Entities;
using LibraryApp.Presentation.ViewContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation.Presenters
{
    public class AddBookPresenter : BasePresenter<IAddBookView>
    {
        private readonly IRepository _repo;

        public AddBookPresenter(IApplicationController controller, IAddBookView view, IRepository repository)
            :base(controller, view)
        {
            _repo = repository;
            View.Add += () => OnAddBook(View.BookName, View.BookAuthor, View.BookYear);
        }

        private void OnAddBook(string name, string author, string year)
        {
            if (String.IsNullOrWhiteSpace(year))
                year = "0";
            if (!String.IsNullOrWhiteSpace(name))
            {
                var book = new Book();
                book.Name = name;
                book.Author = author;
                book.Year = int.Parse(year);
                book.ID = (_repo.Books.Count() == 0) ? 1 : _repo.Books.Max(b => b.ID + 1);

                _repo.Add(book);
                View.Close();
            }
        }
    }
}
