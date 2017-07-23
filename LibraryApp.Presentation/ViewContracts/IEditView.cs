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

        string BookName { get; }
        string Author { get; }
        string Year { get; }

        void Message(string text);
        void SetFields(string name, string author, string year);
    }
    public interface IEditMagzView : IView
    {
        event Action Save;

        string MagName { get; }
        string Lang { get; }
        DateTime? Published { get; }


        void SetFields(string name, string language, DateTime? published);
        void Message(string text);
    }
    public interface IEditNewspView : IView
    {
        event Action Save;

        string NewspName { get; }
        DateTime? PostedOn { get; }

        void Message(string text);
        void SetFields(string name, DateTime? posted);

    }
}
