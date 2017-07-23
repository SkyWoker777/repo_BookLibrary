using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryApp.Presentation.ViewContracts;
using LibraryApp.Core.Entities;

namespace LibraryApp
{
    public partial class MainForm : Form, IMainView
    {
        private BindingSource _bsBooks = new BindingSource();
        private BindingSource _bsMagazines = new BindingSource();
        private BindingSource _bsNewspapers = new BindingSource();

        private readonly ApplicationContext _context;
        public MainForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            btnAddBook.Click += (sender, e) => Invoke(AddBook);
            btnDeleteBook.Click += (sender, e) => Invoke(DeleteBook);
            btnAddMagazine.Click += (sender, e) => Invoke(AddMagazine);
            btnDeleteMagazine.Click += (sender, e) => Invoke(DeleteMagazine);
            btnAddNewspaper.Click += (sender, e) => Invoke(AddNewspaper);
            btnDeleteNewspaper.Click += (sender, e) => Invoke(DeleteNewspaper);
            btnEditBook.Click += (sender, e) => Invoke(EditBook);
            btnEditMag.Click += (sender, e) => Invoke(EditMagazine);
            btnEditNper.Click += (sender, e) => Invoke(EditNewspaper);
        }

        #region tabPageBooks
        public int BookId => (int)dgvBooks["ID", dgvBooks.CurrentRow.Index].Value;

        public event Action AddBook;
        public event Action DeleteBook;
        public event Action EditBook;
        #endregion

        #region tabPageMagazines
        public int MagazId => (int)dgvMagazines["ID", dgvMagazines.CurrentRow.Index].Value;

        public event Action AddMagazine;
        public event Action DeleteMagazine;
        public event Action EditMagazine;
        #endregion

        #region tabPageNewspapers
        public int NewspaperId => (int)dgvNewspapers["ID", dgvNewspapers.CurrentRow.Index].Value;

        public event Action AddNewspaper;
        public event Action DeleteNewspaper;
        public event Action EditNewspaper;
        #endregion

        public void Message(string message)
        {
            labelInfo.Text = message;
        }

        public new void Load(IEnumerable<Book> listBook, IEnumerable<Magazine> listMag,
            IEnumerable<Newspaper> listNews)
        {
            _bsBooks.DataSource = listBook;
            dgvBooks.DataSource = _bsBooks;

            _bsMagazines.DataSource = listMag;
            dgvMagazines.DataSource = _bsMagazines;

            _bsNewspapers.DataSource = listNews;
            dgvNewspapers.DataSource = _bsNewspapers;
        }
        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
