using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation.ViewContracts
{
    public interface IAddBookView : IView
    {
        string BookName { get; }
        string BookAuthor { get; }
        string BookYear { get; }
        string Cost { get; }

        event Action Add;
        event Action YearNumberChecked;
        event Action CostNumberChecked;

        void ShowErrName(string text);
        void ShowErrYear(string text);
        void ShowErrCost(string text);
    }

    public interface IAddNewspView : IView
    {
        string NewspaperName { get; }
        DateTime? PostedOn { get; }
        string Cost { get; }

        event Action Add;
        event Action CostNumberChecked;
        void ShowErrName(string text);
        void ShowErrCost(string text);
    }

    public interface IAddMagazineView : IView
    {
        string MagazineName { get; }
        string Lang { get; }
        DateTime? Published { get; }
        string Cost { get; }

        event Action Add;
        event Action CostNumberChecked;
        void ShowErrName(string text);
        void ShowErrCost(string text);
    }
}
