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
        public IEnumerable<Book> Books => _context.Books;
        public IEnumerable<Magazine> Magazines => _context.Magazines;
        public IEnumerable<Newspaper> Newspapers => _context.Newspapers;

        public void Add<T>(T entity) where T : Entity
        {
            if (typeof(T).Equals(typeof(Book)))
            {
                _context.Books.Add(entity as Book);
            }
            if (typeof(T).Equals(typeof(Magazine)))
            {
                _context.Magazines.Add(entity as Magazine);
            }
            if (typeof(T).Equals(typeof(Newspaper)))
            {
                _context.Newspapers.Add(entity as Newspaper);
            }
        }

        public void Delete<T>(T entity) where T : Entity
        {
            if (typeof(T).Equals(typeof(Book)))
            {
                _context.Books.Remove(entity as Book);
            }
            if (typeof(T).Equals(typeof(Magazine)))
            {
                _context.Magazines.Remove(entity as Magazine);
            }
            if (typeof(T).Equals(typeof(Newspaper)))
            {
                _context.Newspapers.Remove(entity as Newspaper);
            }
        }
        //public void SaveChanges()
        //{
        //    _context.SaveChanges();
        //}
    }
}
