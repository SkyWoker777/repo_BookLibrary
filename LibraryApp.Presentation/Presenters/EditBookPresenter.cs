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
    public class EditBookPresenter : BasePresenter<IEditBookView, int, IRepository>
    {
        private Book _book;
        private IRepository _repo;

        public EditBookPresenter(IApplicationController controller, IEditBookView view)
            :base(controller, view)
        {
            View.Save += () => EditClick(View.BookName, View.Author, View.Year, View.Cost);
            View.CostNumberChecked += () => ValidateField(View.Cost);
            View.YearNumberChecked += () => ValidateField(View.Year);
        }

        private void EditClick(string name, string author, string year, string cost)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                View.ShowErrName("field can not be empty.");
                return;
            }
            _book.Name = name;
            _book.Author = author;
            _book.Year = int.Parse(year);
            _book.Cost = Convert.ToDouble(cost);

            View.Close();
        }
        private void ValidateField(string field)
        {
            if (!decimal.TryParse(field, out decimal res) && !String.IsNullOrWhiteSpace(field))
            {
                if (field == View.Cost)
                {
                    View.ShowErrCost("only numbers");
                    return;
                }
                View.ShowErrYear("only numbers");
            }
        }
        public override void Run(int bookId, IRepository context)
        {
            _repo = context;
            _book = new Book();
            _book = _repo.Books.First(b => b.ID == bookId);

            View.SetFields(_book.Name, _book.Author, _book.Year.ToString(), _book.Cost.ToString());
            View.Show();
        }
    }
}
