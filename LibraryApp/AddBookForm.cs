using LibraryApp.Presentation.ViewContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            tbxYearBook.TextChanged += (sender, e) => YearNumberChecked();
            tbxBookCost.TextChanged += (sender, e) => CostNumberChecked();
        }

        public string BookName => tbxNameBook.Text;
        public string BookAuthor => tbxAuthorBook.Text;
        public string BookYear => tbxYearBook.Text;
        public string Cost => tbxBookCost.Text;

        public event Action Add;
        public event Action YearNumberChecked;
        public event Action CostNumberChecked;

        public void ShowErrName(string text)
        {
            labelErrName.Text = text;
            (new Task(() =>
            {
                Thread.Sleep(2000); this.BeginInvoke((Action)(() => labelErrName.Text = ""));
            })).Start();
        }
        public void ShowErrYear(string text)
        {
            labelErrYear.Text = text;
            tbxYearBook.Text = tbxYearBook.Text.Remove(tbxYearBook.Text.IndexOf(tbxYearBook.Text.Last()));
            (new Task(() =>
            {
                Thread.Sleep(2000); this.BeginInvoke((Action)(() => labelErrYear.Text = ""));
            })).Start();
        }
        public void ShowErrCost(string text)
        {
            labelErrCost.Text = text;
            tbxBookCost.Text = tbxBookCost.Text.Remove(tbxBookCost.Text.IndexOf(tbxBookCost.Text.Last()));
            (new Task(() =>
            {
                Thread.Sleep(2000); this.BeginInvoke((Action)(() => labelErrCost.Text = ""));
            })).Start();
        }

        public new void Show()
        {
            ShowDialog();
        }
    }
}
