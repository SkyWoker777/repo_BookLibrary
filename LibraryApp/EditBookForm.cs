using LibraryApp.Presentation.ViewContracts;
using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class EditBookForm : Form, IEditBookView
    {
        public EditBookForm()
        {
            InitializeComponent();

            btnSave.Click += (sender, e) => Invoke(Save);
        }

        public string BookName => tbxName.Text;
        public string Author => tbxAuthor.Text;
        public string Year => tbxYear.Text;

        public event Action Save;

        public void SetFields(string name, string author, string year)
        {
            tbxName.Text = name;
            tbxAuthor.Text = author;
            tbxYear.Text = year;
        }

        public void Message(string text)
        {
            labelErr.Text = text;
        }

        public new void Show()
        {
            ShowDialog();
        }
    }
}
