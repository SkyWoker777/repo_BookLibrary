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
        string BookName { get; }
        string BookAuthor { get; }
        string BookYear { get; }

        int MagazId { get; }
        string MagazineName { get; }
        string MagazineLang { get; }
        DateTime? Published { get; }

        int NewspaperId { get; }
        string NewspaperName { get; }
        DateTime? PostedOn { get; }

        event Action AddBook;
        event Action DeleteBook;
        //event Action Edit;
        event Action AddMagazine;
        event Action DeleteMagazine;
        event Action AddNewspaper;
        event Action DeleteNewspaper;

        void Load(IEnumerable<Book> listBooks, 
                        IEnumerable<Magazine> listMag, 
                            IEnumerable<Newspaper> listNews);


    }
}
