using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core
{
    public class LibraryContext
    {
        public IList<Book> Books { get; set; }
        public IList<Newspaper> Newspapers { get; set; }
        public IList<Magazine> Magazines { get; set; }

        public LibraryContext()
        {
            Initialize();
        }

        private void Initialize()
        {
            Books = new List<Book>
            {
                new Book(){ ID = 1, Name = "Крылья Феникса", Author = "Жданова Светлана", Year = 2009 },
                new Book(){ ID = 2, Name = "Метро 2033", Author = "Глуховский Д.А.", Year = 2007 },
                new Book(){ ID = 3, Name = "Застава", Author = "Лукьяненко Сергей", Year = 2001 },
                new Book(){ ID = 4, Name = "Сделка с дьяволом", Author = "Андерсон Эвангелина", Year = 2005 },
                new Book(){ ID = 5, Name = "Голодные игры", Author = "Коллинз Сьюзен", Year = 2010 },
            };
            Newspapers = new List<Newspaper>();
            Magazines = new List<Magazine>
            {
                new Magazine(){ ID = 1, Name = "Cosmopolitan",
                    Language = "English", Published = DateTime.Today },
                new Magazine(){ ID = 2, Name = "Здоровье и Красота",
                    Language = "Русский", Published = DateTime.Today },
                new Magazine(){ ID = 3, Name = "Forbes",
                    Language = "Смешанный", Published = DateTime.Today },
                new Magazine(){ ID = 4, Name = "Как это работает?",
                    Language = "Русский", Published = DateTime.Today },
                new Magazine(){ ID = 5, Name = "People",
                    Language = "English", Published = DateTime.Today },
            };
        }
    }
}
