using LibraryApp.Core;
using LibraryApp.Core.Entities;
using LibraryApp.Presentation.ViewContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        private readonly IRepository _repo;
        private List<IProduct> _list;

        public MainPresenter(IApplicationController controller, IMainView view, IRepository repository)
            :base(controller, view)
        {
            _repo = repository;
            LoadData();
            View.Cart += OnClick_Cart;

            View.AddBook += OnClick_AddBook;
            View.AddMagazine += OnClick_AddMagazine;
            View.AddNewspaper += OnClick_AddNewspaper;

            View.DeleteBook += () => OnClick_DeleteBook(View.BookId);
            view.DeleteMagazine += () => OnClick_DeleteMagazine(View.MagazId);
            View.DeleteNewspaper += () => OnClick_DeleteNewspaper(View.NewspaperId);

            View.EditBook += OnClick_EditBook;
            View.EditMagazine += OnClick_EditMagz;
            View.EditNewspaper += OnClick_EditNewsp;

            View.AddBookToCart += () => OnCellClick_AddBookToCart(View.BookId);
            View.AddMagazineToCart += () => OnCellClick_AddMagazineToCart(View.MagazId);
            View.AddNewspaperToCart += () => OnCellClick_AddNewspaperToCart(View.NewspaperId);

            _list = new List<IProduct>();
        }

        private void LoadData()
        {
            View.Load(_repo.Books, _repo.Magazines, _repo.Newspapers);
        }
        private void OnClick_Cart()
        {
            Controller.Run<CartPresenter, List<IProduct>>(_list);
        }

        private void OnClick_AddBook()
        {
            Controller.Run<AddBookPresenter, IRepository>(_repo);
            View.Message("The book is added successfully!");
        }
        private void OnClick_AddMagazine()
        {
            Controller.Run<AddMagazinePresenter, IRepository>(_repo);
            View.Message("The magazine is added successfully!");
        }
        private void OnClick_AddNewspaper()
        {
            Controller.Run<AddNewspPresenter, IRepository>(_repo);
            View.Message("The newspaper is added successfully!");
        }
   
        private void OnClick_DeleteBook(int id)
        {
            if (id == 0)
            {
                View.Message("The list is empty.");
                return;
            }
            var book = _repo.Books.First(b => b.ID == id);
            _repo.Delete(book);
            View.Message("It's deleted.");
        }
        private void OnClick_DeleteMagazine(int id)
        {
            if (id == 0)
            {
                View.Message("The list is empty.");
                return;
            }
            var magazine = _repo.Magazines.First(m => m.ID == id);
            _repo.Delete(magazine);
            View.Message("It's deleted.");
        }
        private void OnClick_DeleteNewspaper(int id)
        {
            if (id == 0)
            {
                View.Message("The list is empty.");
                return;
            }
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

        private void OnCellClick_AddBookToCart(int id)
        {
            var book = _repo.Books.First(b => b.ID == id);
            if (_list.Contains(book))
            {
                book.ProductCount += 1;
                return;
            }
            book.ProductCount = 1;
            _list.Add(book);
        }
        private void OnCellClick_AddMagazineToCart(int id)
        {
            var mag = _repo.Magazines.First(m => m.ID == id);
            if (_list.Contains(mag))
            {
                mag.ProductCount += 1;
                return;
            }
            mag.ProductCount = 1;
            _list.Add(mag);
        }
        private void OnCellClick_AddNewspaperToCart(int id)
        {
            var newsp = _repo.Newspapers.First(n => n.ID == id);
            if (_list.Contains(newsp))
            {
                newsp.ProductCount += 1;
                return;
            }
            newsp.ProductCount = 1;
            _list.Add(newsp);
        }
    }
}
