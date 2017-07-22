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
    public class MainPresenter : BasePresenter<IMainView>
    {
        private readonly IRepository _repo;

        public MainPresenter(IApplicationController controller, IMainView view, IRepository repository)
            :base(controller, view)
        {
            _repo = repository;

            LoadData();
            View.AddBook += () => OnClick_AddBook(View.BookName, View.BookAuthor, View.BookYear);
            View.AddMagazine += () => OnClick_AddMagazine(View.MagazineName, View.MagazineLang, View.Published);
            View.AddNewspaper += () => OnClick_AddNewspaper(View.NewspaperName, View.PostedOn);

            View.DeleteBook += () => OnClick_DeleteBook(View.BookId);
            view.DeleteMagazine += () => OnClick_DeleteMagazine(View.MagazId);
            View.DeleteNewspaper += () => OnClick_DeleteNewspaper(View.NewspaperId);
        }

        private void LoadData()
        {
            View.Load(_repo.Books, _repo.Magazines, _repo.Newspapers);
        }

        private void OnClick_AddBook(string name, string author, string year)
        {
            if (String.IsNullOrWhiteSpace(year))
                year = "0";

            var book = new Book();
            book.Name = name;
            book.Author = author;
            book.Year = int.Parse(year);
            book.ID = (_repo.Books.Count() == 0) ? 1 : _repo.Books.Max(b => b.ID + 1);

            _repo.Add(book);
            View.Message("The book is added successfully!");
        }

        private void OnClick_AddMagazine(string name, string lang, DateTime? published)
        {
            var magazine = new Magazine();
            magazine.Name = name;
            magazine.Language = lang;
            magazine.Published = published;
            magazine.ID = (_repo.Magazines.Count() == 0) ? 1 : _repo.Magazines.Max(m => m.ID + 1);

            _repo.Add(magazine);
            View.Message("The magazine is added successfully!");
        }
        private void OnClick_AddNewspaper(string name, DateTime? posted)
        {
            var paper = new Newspaper();
            paper.Name = name;
            paper.PostedOn = posted;
            paper.ID = (_repo.Newspapers.Count() == 0) ? 1 : _repo.Newspapers.Max(n => n.ID + 1);

            _repo.Add(paper);
            View.Message("The newspaper is added successfully!");
        }

        private void OnClick_DeleteBook(int id)
        {
            var book = _repo.Books.First(b => b.ID == id);
            _repo.Delete(book);
            View.Message("It's deleted successfully.");
        }
        private void OnClick_DeleteMagazine(int id)
        {
            var magazine = _repo.Magazines.First(m => m.ID == id);
            _repo.Delete(magazine);
            View.Message("It's deleted successfully");
        }
        private void OnClick_DeleteNewspaper(int id)
        {
            var paper = _repo.Newspapers.First(n => n.ID == id);
            _repo.Delete(paper);
            View.Message("It's deleted successfully.");
        }
    }
}
