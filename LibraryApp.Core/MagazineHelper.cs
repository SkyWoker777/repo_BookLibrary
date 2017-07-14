using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core
{
    public class MagazineHelper
    {
        private IRepository _repository;

        public MagazineHelper(IRepository repo)
        {
            _repository = repo;
        }

        private int SetId()
        {
            int id = 1;
            if (_repository.Magazines.Count() != 0)
            {
                return _repository.Magazines.Max(x => x.ID + 1);
            }
            return id;
        }

        public void AddMagazine(string name, string language, DateTime? published)
        {
            var magazine = new Magazine();
            magazine.Name = name;
            magazine.Language = language;
            magazine.Published = published;
            magazine.ID = SetId();
            _repository.Add(magazine);
        }

        public Magazine EditMagazine(int id, string name, string lang, DateTime? published)
        {
            var magaz = GetMagazine(id);
            magaz.Name = name;
            magaz.Language = lang;
            magaz.Published = published;
            _repository.Add(magaz);
            return magaz;
        }

        public void DeleteMagazine(int id)
        {
            var magazine = GetMagazine(id);
            _repository.Delete(magazine);
        }

        public IEnumerable<Magazine> GetMagazines()
        {
            return _repository.Magazines;
        }
        public Magazine GetMagazine(int id)
        {
            return _repository.Magazines.First(b => b.ID == id);
        }
    }
}
