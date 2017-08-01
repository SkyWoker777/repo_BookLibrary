using LibraryApp.Core;
using LibraryApp.Core.Entities;
using LibraryApp.Presentation.ViewContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation.Presenters
{
    public class CartPresenter : BasePresenter<ICartView, List<IProduct>>
    {
        private BindingList<IProduct> _cartList;
        private double _paymentAmount;
        public CartPresenter(IApplicationController controller, ICartView view)
            :base(controller, view)
        {
            View.Pay += OnClick_Pay;
            View.Back += OnClick_Back;
            View.DeleteItem += () => OnCellClick_DeleteItem(View.Item);
        }

        private void OnClick_Pay()
        {
            string text = $"Payment has been successful!\nPayment check is not required.\n\nAmount: {_paymentAmount} UAH";
            View.Message(text);
            View.Close();
            _cartList.Clear();
        }
        private void OnCellClick_DeleteItem(IProduct item)
        {
            _cartList.Remove(item);
            _paymentAmount = CountTotalCost();
            View.TotalCost(Convert.ToString($"{_paymentAmount} UAH"));
        }
        private double CountTotalCost()
        {
            double totalCost = 0.0;
            foreach (var obj in _cartList)
            {
                totalCost += (obj.Cost * obj.ProductCount);
            }
            return totalCost;
        }

        public override void Run(List<IProduct> list)
        {
            _cartList = new BindingList<IProduct>(list);
            _paymentAmount = CountTotalCost();
            View.TotalCost(Convert.ToString($"{_paymentAmount} UAH"));
            View.Load(_cartList);
            View.Show();
        }

        private void OnClick_Back()
        {
            View.Close();
        }
    }
}
