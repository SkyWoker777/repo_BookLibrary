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
    public class AddBookPresenter : BasePresenter<IAddBookView, IRepository>
    {
        private IRepository _repo;

        public AddBookPresenter(IApplicationController controller, IAddBookView view)
            :base(controller, view)
        {
            View.Add += () => OnAddBook(View.BookName, View.BookAuthor, View.BookYear, View.Cost);
            View.YearNumberChecked += () => ValidateField(View.BookYear);
            View.CostNumberChecked += () => ValidateField(View.Cost);
        }

        private void OnAddBook(string name, string author, string year, string cost)
        {
            if (String.IsNullOrWhiteSpace(year))
                year = "0";
            if(String.IsNullOrWhiteSpace(name))
            {
                View.ShowErrName("field can not be empty");
                return;
            }
            var book = new Book();
            book.Name = name;
            book.Author = author;
            book.Year = int.Parse(year);
            book.Cost = Convert.ToDouble(cost);
            book.ID = (_repo.Books.Count() == 0) ? 1 : _repo.Books.Max(b => b.ID + 1);

            _repo.Add(book);
            View.Close();
        }

        public override void Run(IRepository context)
        {
            _repo = context;
            View.Show();
        }

        private void ValidateField(string field)
        {
            if (!decimal.TryParse(field, out decimal res) && !String.IsNullOrWhiteSpace(field))
            {
                if(field == View.Cost)
                {
                    View.ShowErrCost("only numbers");
                    return;
                }
                View.ShowErrYear("only numbers");
            }
        }
    }
}
