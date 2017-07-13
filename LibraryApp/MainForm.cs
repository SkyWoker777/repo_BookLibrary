using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.Core;

namespace LibraryApp
{
    public partial class MainForm : Form
    {
        private BookHelper _bookHelper;
        private BindingSource _bindingSource;
        public MainForm()
        {
            InitializeComponent();
            _bookHelper = new BookHelper(new Repository());
            _bindingSource = new BindingSource();
            this.Load += new EventHandler(MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _bookHelper.GetBooks();
            dgvBooks.DataSource = _bindingSource;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _bookHelper.AddBook(tbxName.Text, tbxAuthor.Text, int.Parse(tbxYear.Text));
            _bindingSource.DataSource = _bookHelper.GetBooks();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var bookId = dgvBooks["ID", dgvBooks.CurrentRow.Index].Value;
            _bookHelper.DeleteBook((int)bookId);
            _bindingSource.DataSource = _bookHelper.GetBooks();
            //_bindingSource.ResetBindings(true);
        }
    }
}
