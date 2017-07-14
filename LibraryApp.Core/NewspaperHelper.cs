using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Core.Entities;

namespace LibraryApp.Core
{
    public class NewspaperHelper
    {
        private IRepository _repository;

        public NewspaperHelper(IRepository repo)
        {
            _repository = repo;
        }

        private int SetId()
        {
            int id = 1;
            if (_repository.Newspapers.Count() != 0)
            {
                return _repository.Newspapers.Max(x => x.ID + 1);
            }
            return id;
        }

        public void AddNewspaper(string name, DateTime? posted)
        {
            var paper = new Newspaper();
            paper.Name = name;
            paper.PostedOn = posted;
            paper.ID = SetId();
            _repository.Add(paper);
        }

        public void DeleteNewspaper(int id)
        {
            var paper = GetNewspaper(id);
            _repository.Delete(paper);
        }

        public Newspaper EditNewspaper(int id, string name, DateTime? posted)
        {
            var paper = GetNewspaper(id);
            paper.Name = name;
            paper.PostedOn = posted;
            _repository.Add(paper);
            return paper;
        }

        public IEnumerable<Newspaper> GetNewspapers()
        {
            return _repository.Newspapers;
        }
        public Newspaper GetNewspaper(int id)
        {
            return _repository.Newspapers.First(b => b.ID == id);
        }
    }
}
