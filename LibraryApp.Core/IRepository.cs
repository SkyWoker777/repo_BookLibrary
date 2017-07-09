using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core
{
    public interface IRepository
    {
        IEnumerable<Book> Books { get; }

        void Add<T>(T entity) where T : Entity;
        void Delete<T>(T entity) where T : Entity;
        void SaveChanges();
    }
}
