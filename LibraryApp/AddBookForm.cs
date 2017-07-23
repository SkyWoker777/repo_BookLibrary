using LibraryApp.Presentation.ViewContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AddBookForm : Form, IAddBookView
    {
        public AddBookForm()
        {
            InitializeComponent();

            btnAddBook.Click += (sender, e) => Add();
        }

        public string BookName => tbxNameBook.Text;
        public string BookAuthor => tbxAuthorBook.Text;
        public string BookYear => tbxYearBook.Text;

        public event Action Add;

        public new void Show()
        {
            ShowDialog();
        }
    }
}
