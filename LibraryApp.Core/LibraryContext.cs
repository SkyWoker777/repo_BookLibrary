using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core
{
    class LibraryContext
    {
        public BindingList<Book> Books { get; set; }
        public BindingList<Newspaper> Newspapers { get; set; }
        public BindingList<Magazine> Magazines { get; set; }

        public LibraryContext()
        {
            Initialize();
        }

        private void Initialize()
        {
            Books = new BindingList<Book>
            {
                new Book(){ ID = 1, Name = "Крылья Феникса", Author = "Жданова Светлана", Year = 2009, Cost = 150 },
                new Book(){ ID = 2, Name = "Метро 2033", Author = "Глуховский Д.А.", Year = 2007, Cost = 210 },
                new Book(){ ID = 3, Name = "Застава", Author = "Лукьяненко Сергей", Year = 2001, Cost = 233},
                new Book(){ ID = 4, Name = "Сделка с дьяволом", Author = "Андерсон Эвангелина", Year = 2005, Cost = 150 },
                new Book(){ ID = 5, Name = "Голодные игры", Author = "Коллинз Сьюзен", Year = 2010, Cost = 320 },
            };
            Newspapers = new BindingList<Newspaper>
            {
                new Newspaper(){ ID = 1, Name = "Факты", PostedOn = DateTime.Today, Cost = 15 },
                new Newspaper(){ ID = 2, Name = "Корреспондент", PostedOn = DateTime.Today, Cost = 15 },
                new Newspaper(){ ID = 3, Name = "Сила", PostedOn = DateTime.Today, Cost = 15 },
                new Newspaper(){ ID = 4, Name = "Правда", PostedOn = DateTime.Today, Cost = 15 },
                new Newspaper(){ ID = 5, Name = "Енакиевский рабочий", PostedOn = DateTime.Today, Cost = 15 },
            };
            Magazines = new BindingList<Magazine>
            {
                new Magazine(){ ID = 1, Name = "Cosmopolitan",
                    Language = "English", Published = DateTime.Today, Cost = 50 },
                new Magazine(){ ID = 2, Name = "Здоровье и Красота",
                    Language = "Русский", Published = DateTime.Today, Cost = 50 },
                new Magazine(){ ID = 3, Name = "Forbes",
                    Language = "Смешанный", Published = DateTime.Today, Cost = 50 },
                new Magazine(){ ID = 4, Name = "Теленеделя",
                    Language = "Русский", Published = DateTime.Today, Cost = 50 },
                new Magazine(){ ID = 5, Name = "People",
                    Language = "English", Published = DateTime.Today, Cost = 50 },
            };
        }
    }
}
