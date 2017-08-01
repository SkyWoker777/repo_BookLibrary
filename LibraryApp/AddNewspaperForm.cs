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
    public partial class AddNewspaperForm : Form, IAddNewspView
    {
        public AddNewspaperForm()
        {
            InitializeComponent();
            btnAddNewsp.Click += (sender, e) => Add();
            tbxCost.TextChanged += (sender, e) => CostNumberChecked();
        }

        public string NewspaperName => tbxName.Text;
        public DateTime? PostedOn => dtpPostedOn.Value.Date;
        public string Cost => tbxCost.Text;

        public event Action Add;
        public event Action CostNumberChecked;

        public void ShowErrName(string text)
        {
            labelErrName.Text = text;
            (new Task(() => {
                Thread.Sleep(3000); this.BeginInvoke((Action)(() => labelErrName.Text = ""));
            })).Start();
        }
        public void ShowErrCost(string text)
        {
            labelErrCost.Text = text;
            tbxCost.Text = tbxCost.Text.Remove(tbxCost.Text.IndexOf(tbxCost.Text.Last()));
            (new Task(() => {
                Thread.Sleep(2000); this.BeginInvoke((Action)(() => labelErrCost.Text = ""));
            })).Start();
        }
        public new void Show()
        {
            ShowDialog();
        }
    }
}
