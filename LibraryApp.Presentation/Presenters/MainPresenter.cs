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

            View.AddBook += OnClick_AddBook;
            View.AddMagazine += OnClick_AddMagazine;
            View.AddNewspaper += OnClick_AddNewspaper;

            View.DeleteBook += () => OnClick_DeleteBook(View.BookId);
            view.DeleteMagazine += () => OnClick_DeleteMagazine(View.MagazId);
            View.DeleteNewspaper += () => OnClick_DeleteNewspaper(View.NewspaperId);

            View.EditBook += OnClick_EditBook;
            View.EditMagazine += OnClick_EditMagz;
            View.EditNewspaper += OnClick_EditNewsp;
        }

        private void LoadData()
        {
            View.Load(_repo.Books, _repo.Magazines, _repo.Newspapers);
        }

        private void OnClick_AddBook()
        {
            Controller.Run<AddBookPresenter>();
            View.Message("The book is added successfully!");
        }

        private void OnClick_AddMagazine()
        {
            Controller.Run<AddMagazinePresenter>();
            View.Message("The magazine is added successfully!");
        }
        private void OnClick_AddNewspaper()
        {
            Controller.Run<AddNewspPresenter>();
            View.Message("The newspaper is added successfully!");
        }

        private void OnClick_DeleteBook(int id)
        {
            var book = _repo.Books.First(b => b.ID == id);
            _repo.Delete(book);
            View.Message("It's deleted.");
        }
        private void OnClick_DeleteMagazine(int id)
        {
            var magazine = _repo.Magazines.First(m => m.ID == id);
            _repo.Delete(magazine);
            View.Message("It's deleted.");
        }
        private void OnClick_DeleteNewspaper(int id)
        {
            var paper = _repo.Newspapers.First(n => n.ID == id);
            _repo.Delete(paper);
            View.Message("It's deleted.");
        }

        private void OnClick_EditBook()
        {
            Controller.Run<EditBookPresenter, int, IRepository>(View.BookId, _repo);
            View.Message("Saved successfully.");
        }
        private void OnClick_EditMagz()
        {
            Controller.Run<EditMagazinePresenter, int, IRepository>(View.MagazId, _repo);
            View.Message("Saved successfully.");
        }
        private void OnClick_EditNewsp()
        {
            Controller.Run<EditNewspPresenter, int, IRepository>(View.NewspaperId, _repo);
            View.Message("Saved successfully.");
        }

    }
}
