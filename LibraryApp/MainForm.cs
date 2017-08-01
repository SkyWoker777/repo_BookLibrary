using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryApp.Presentation.ViewContracts;
using LibraryApp.Core.Entities;
using System.Threading.Tasks;
using System.Threading;

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
            btnCart.Click += (sender, e) => Invoke(Cart);

            dgvBooks.CellClick += DgvBooks_CellClick;
            dgvMagazines.CellClick += DgvMagazines_CellClick;
            dgvNewspapers.CellClick += DgvNewspapers_CellClick;

            dgvBooks.DataBindingComplete += (sender, e) => DgvBooks_DataBindingComplete();
            dgvMagazines.DataBindingComplete +=(sender, e) => DgvMagazines_DataBindingComplete();
            dgvNewspapers.DataBindingComplete += (sender, e) => DgvNewspapers_DataBindingComplete();

        }

        private void DgvNewspapers_DataBindingComplete()
        {
            this.dgvNewspapers.Columns["ID"].Visible = false;
            this.dgvNewspapers.Columns["ProductCount"].Visible = false;
        }
        private void DgvMagazines_DataBindingComplete()
        {
            this.dgvMagazines.Columns["ID"].Visible = false;
            this.dgvMagazines.Columns["ProductCount"].Visible = false;
        }
        private void DgvBooks_DataBindingComplete()
        {
            this.dgvBooks.Columns["ID"].Visible = false;
            this.dgvBooks.Columns["ProductCount"].Visible = false;
        }
        
        public event Action Cart;

        #region tabPageBooks
        public int BookId
        {
            get {
                if(_bsBooks.List.Count != default(int))
                    return (int)dgvBooks["ID", dgvBooks.CurrentRow.Index].Value;
                return default(int);
            }
        }

        public event Action AddBook;
        public event Action DeleteBook;
        public event Action EditBook;
        public event Action AddBookToCart;
        private void DgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvBooks.Columns["CartColumn"].Index)
                return;

            AddBookToCart();
        }

        #endregion

        #region tabPageMagazines
        public int MagazId
        {
            get {
                if(_bsMagazines.List.Count != default(int))
                    return (int)dgvMagazines["ID", dgvMagazines.CurrentRow.Index].Value;
                return default(int);
            }
        }

        public event Action AddMagazine;
        public event Action DeleteMagazine;
        public event Action EditMagazine;
        public event Action AddMagazineToCart;

        private void DgvMagazines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvMagazines.Columns["MagazinesColumnButtonBuy"].Index)
                return;

            AddMagazineToCart();
        }
        #endregion

        #region tabPageNewspapers
        public int NewspaperId
        {
            get
            {
                if(_bsNewspapers.List.Count != default(int))
                    return (int)dgvNewspapers["ID", dgvNewspapers.CurrentRow.Index].Value;
                return default(int);
            }
        }

        public event Action AddNewspaper;
        public event Action DeleteNewspaper;
        public event Action EditNewspaper;
        public event Action AddNewspaperToCart;
        private void DgvNewspapers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvNewspapers.Columns["NewspapersColumnButtonBuy"].Index)
                return;

            AddNewspaperToCart();
        }

        #endregion

        public void Message(string message)
        {
            labelInfo.Text = message;
            (new Task(() =>
            {
                Thread.Sleep(3000); this.BeginInvoke((Action)(() => labelInfo.Text = ""));
            })).Start();
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
