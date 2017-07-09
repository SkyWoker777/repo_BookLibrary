using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Core.Entities;

namespace LibraryApp.Core
{
    public class Repository : IRepository
    {
        private LibraryContext _context;

        public Repository()
        {
            _context = new LibraryContext();
        }
        public IEnumerable<Book> Books => _context.Books.ToList();

        public void Add<T>(T entity) where T : Entity
        {
            throw new NotImplementedException();
        }
        public void Delete<T>(T entity) where T : Entity
        {
            throw new NotImplementedException();
        }
        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
