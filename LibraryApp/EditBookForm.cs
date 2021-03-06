﻿using LibraryApp.Presentation.ViewContracts;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class EditBookForm : Form, IEditBookView
    {
        public EditBookForm()
        {
            InitializeComponent();

            btnSave.Click += (sender, e) => Invoke(Save);
            tbxYear.TextChanged += (sender, e) => YearNumberChecked();
            tbxCost.TextChanged += (sender, e) => CostNumberChecked();
        }

        public string BookName => tbxName.Text;
        public string Author => tbxAuthor.Text;
        public string Year => tbxYear.Text;
        public string Cost => tbxCost.Text;

        public event Action Save;
        public event Action CostNumberChecked;
        public event Action YearNumberChecked;

        public void SetFields(string name, string author, string year, string cost)
        {
            tbxName.Text = name;
            tbxAuthor.Text = author;
            tbxYear.Text = year;
            tbxCost.Text = cost;
        }

        public void ShowErrName(string text)
        {
            labelErrName.Text = text;
            (new Task(() => {
                Thread.Sleep(2000); this.BeginInvoke((Action)(() => labelErrName.Text = ""));
            })).Start();
        }
        public void ShowErrYear(string text)
        {
            labelErrYear.Text = text;
            tbxYear.Text = tbxYear.Text.Remove(tbxYear.Text.IndexOf(tbxYear.Text.Last()));
            (new Task(() =>
            {
                Thread.Sleep(2000); this.BeginInvoke((Action)(() => labelErrYear.Text = ""));
            })).Start();
        }
        public void ShowErrCost(string text)
        {
            labelErrCost.Text = text;
            tbxCost.Text = tbxCost.Text.Remove(tbxCost.Text.IndexOf(tbxCost.Text.Last()));
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
