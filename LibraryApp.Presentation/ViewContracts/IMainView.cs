using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation.ViewContracts
{
    public interface IMainView : IView
    {
        int BookId { get; }
        int MagazId { get; }
        int NewspaperId { get; }

        event Action AddBook;
        event Action DeleteBook;
        event Action EditBook;

        event Action AddMagazine;
        event Action DeleteMagazine;
        event Action EditMagazine;

        event Action AddNewspaper;
        event Action DeleteNewspaper;
        event Action EditNewspaper;

        void Load(IEnumerable<Book> listBooks, 
                        IEnumerable<Magazine> listMag, 
                            IEnumerable<Newspaper> listNews);
        void Message(string message);

    }
}
