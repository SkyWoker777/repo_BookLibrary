using LibraryApp.Core;
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
    public partial class CartForm : Form, ICartView
    {
        private BindingSource _bsCart = new BindingSource();
        public CartForm()
        {
            InitializeComponent();

            btnBack.Click += (sender, e) => Back();
            btnPay.Click += (sender, e) => Pay();

            dgvCart.CellClick += DgvCart_CellClick;
        }

        private void DgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvCart.Columns["ColumnButtonDeleteItem"].Index)
                return;

            DeleteItem();
        }

        public event Action Pay;
        public event Action Back;
        public event Action DeleteItem;
        public IProduct Item => (dgvCart.Rows[dgvCart.CurrentRow.Index].DataBoundItem) as IProduct;
        public void TotalCost(string cost)
        {
            labelTotalCost.Text = cost;
        }

        public new void Load(BindingList<IProduct> list)
        {
            _bsCart.DataSource = list;
            dgvCart.DataSource = _bsCart;
        }
        public void Message(string text)
        {
            MessageBox.Show(text, "Success!");
        }
        public new void Show()
        {
            ShowDialog();
        }
    }
}
