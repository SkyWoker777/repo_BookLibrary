using LibraryApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation.ViewContracts
{
    public interface ICartView : IView
    {
        IProduct Item { get; }
        event Action Pay;
        event Action Back;
        event Action DeleteItem;

        void Load(BindingList<IProduct> list);
        void TotalCost(string cost);
        void Message(string text);
    }
}
