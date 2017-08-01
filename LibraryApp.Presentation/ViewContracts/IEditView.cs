using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation.ViewContracts
{
    public interface IEditBookView : IView
    {
        event Action Save;
        event Action CostNumberChecked;
        event Action YearNumberChecked;

        string BookName { get; }
        string Author { get; }
        string Year { get; }
        string Cost { get; }

        void SetFields(string name, string author, string year, string cost);
        void ShowErrName(string text);
        void ShowErrCost(string text);
        void ShowErrYear(string text);
    }
    public interface IEditMagzView : IView
    {
        event Action Save;
        event Action CostNumberChecked;
        string MagName { get; }
        string Lang { get; }
        DateTime? Published { get; }
        string Cost { get; }

        void SetFields(string name, string language, DateTime? published, string cost);
        void ShowErrName(string text);
        void ShowErrCost(string text);
    }
    public interface IEditNewspView : IView
    {
        event Action Save;
        event Action CostNumberChecked;
        string NewspName { get; }
        DateTime? PostedOn { get; }
        string Cost { get; }

        void SetFields(string name, DateTime? posted, string cost);
        void ShowErrName(string text);
        void ShowErrCost(string text);

    }
}
