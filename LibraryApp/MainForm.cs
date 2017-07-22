using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        #region tabPageBooks

        public int BookId => (int)dgvBooks["ID", dgvBooks.CurrentRow.Index].Value;
        public string BookName => tbxNameBook.Text;
        public string BookAuthor => tbxAuthorBook.Text;
        public string BookYear => tbxYearBook.Text;

        public event Action AddBook;
        public event Action DeleteBook;
        #endregion

        #region tabPageMagazines

        public int MagazId => (int)dgvMagazines["ID", dgvMagazines.CurrentRow.Index].Value;
        public string MagazineName => tbxNameMag.Text;
        public string MagazineLang => tbxLangMag.Text;
        public DateTime? Published => dtp_Pablished.Value.Date;

        public event Action AddMagazine;
        public event Action DeleteMagazine;
        #endregion

        #region tabPageNewspapers

        public int NewspaperId => (int)dgvNewspapers["ID", dgvNewspapers.CurrentRow.Index].Value;
        public string NewspaperName => tbxNameNews.Text;
        public DateTime? PostedOn => dtp_Posted.Value.Date;

        public event Action AddNewspaper;
        public event Action DeleteNewspaper;
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
        private void Invoke(Action action)
        {
            action?.Invoke();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
