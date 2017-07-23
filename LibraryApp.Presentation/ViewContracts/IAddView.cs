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

        event Action Add;
    }

    public interface IAddNewspView : IView
    {
        string NewspaperName { get; }
        DateTime? PostedOn { get; }

        event Action Add;
    }

    public interface IAddMagazineView : IView
    {
        string MagazineName { get; }
        string Lang { get; }
        DateTime? Published { get; }

        event Action Add;
    }
}
