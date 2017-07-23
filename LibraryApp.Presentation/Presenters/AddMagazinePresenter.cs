using LibraryApp.Core;
using LibraryApp.Core.Entities;
using LibraryApp.Presentation.ViewContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation.Presenters
{
    public class AddMagazinePresenter : BasePresenter<IAddMagazineView>
    {
        public readonly IRepository _repo;

        public AddMagazinePresenter(IApplicationController controller, IAddMagazineView view, IRepository repository)
            :base(controller,view)
        {
            _repo = repository;
            View.Add += () => OnAddMagazine(View.MagazineName, View.Lang, View.Published);
        }

        private void OnAddMagazine(string name, string lang, DateTime? published)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                var magazine = new Magazine();
                magazine.Name = name;
                magazine.Language = lang;
                magazine.Published = published;
                magazine.ID = (_repo.Magazines.Count() == 0) ? 1 : _repo.Magazines.Max(m => m.ID + 1);

                _repo.Add(magazine);
                View.Close();
            }
        }
    }
}
