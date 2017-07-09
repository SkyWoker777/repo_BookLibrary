using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Entities
{
    public class Book : Entity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int? Year { get; set; }
        //public BookGenre Genre { get; set; }
    }
}
