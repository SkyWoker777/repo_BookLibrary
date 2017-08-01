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
    public partial class EditNewspaperForm : Form, IEditNewspView
    {
        public EditNewspaperForm()
        {
            InitializeComponent();
            btnSave.Click += (sender, e) => Save();
            tbxCost.TextChanged += (sender, e) => CostNumberChecked();
        }

        public string NewspName => tbxName.Text;
        public DateTime? PostedOn => dtpPostedOn.Value.Date;
        public string Cost => tbxCost.Text;

        public event Action Save;
        public event Action CostNumberChecked;

        public void SetFields(string name, DateTime? posted, string cost)
        {
            tbxName.Text = name;
            dtpPostedOn.Value = posted.Value;
            tbxCost.Text = cost;
        }

        public void ShowErrName(string text)
        {
            labelErrName.Text = text;
            (new Task(() => {
                Thread.Sleep(2000); this.BeginInvoke((Action)(() => labelErrName.Text = ""));
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
