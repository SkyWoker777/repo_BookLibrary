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
        private BookHelper _bookHelper = new BookHelper(new Repository());
        private MagazineHelper _magazHelper = new MagazineHelper(new Repository());
        private NewspaperHelper _paperHelper = new NewspaperHelper(new Repository());

        private BindingSource _bindingSourceBook = new BindingSource();
        private BindingSource _bindingSourceMagazine = new BindingSource();
        private BindingSource _bindingSourceNewspaper = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            _bindingSourceBook.DataSource = _bookHelper.GetBooks();
            dgvBooks.DataSource = _bindingSourceBook;

            _bindingSourceMagazine.DataSource = _magazHelper.GetMagazines();
            dgvMagazines.DataSource = _bindingSourceMagazine;

            _bindingSourceNewspaper.DataSource = _paperHelper.GetNewspapers();
            dgvNewspapers.DataSource = _bindingSourceNewspaper;
            
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
           _bookHelper.AddBook(tbxNameBook.Text, 
                                tbxAuthor.Text, 
                                int.Parse(tbxYear.Text));
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {
            var bookId = dgvBooks["ID", dgvBooks.CurrentRow.Index].Value;
            _bookHelper.DeleteBook((int)bookId);
        }

        private void btn_AddMagazine_Click(object sender, EventArgs e)
        {
            _magazHelper.AddMagazine(tbxNameMag.Text, 
                                     tbxLang.Text, 
                                     dtp_Pablished.Value.Date);

        }

        private void btn_DeleteMagazine_Click(object sender, EventArgs e)
        {
            var magazId = dgvMagazines["ID", dgvMagazines.CurrentRow.Index].Value;
            _magazHelper.DeleteMagazine((int)magazId);
        }

        private void btn_AddNewspaper_Click(object sender, EventArgs e)
        {
            _paperHelper.AddNewspaper(tbxNameNews.Text, dtp_Posted.Value.Date);
        }

        private void btn_DeleteNewspaper_Click(object sender, EventArgs e)
        {
            var paperId = dgvNewspapers["ID", dgvNewspapers.CurrentRow.Index].Value;
            _paperHelper.DeleteNewspaper((int)paperId);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
