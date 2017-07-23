using LibraryApp.Core;
using LibraryApp.Presentation.ViewContracts;
using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation.Presenters
{
    public class EditMagazinePresenter : BasePresenter<IEditMagzView, int, IRepository>  
    {
        private Magazine _magazine;
        private IRepository _repo;

        public EditMagazinePresenter(IApplicationController controller, IEditMagzView view)
            :base(controller, view)
        {
            View.Save += () => EditClick(View.MagName, View.Lang, View.Published);
        }

        private void EditClick(string name, string lang, DateTime? published)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                View.Message("field can not be empty.");
                return;
            }
            _magazine.Name = name;
            _magazine.Language = lang;
            _magazine.Published = published;

            View.Close();
        }

        public override void Run(int arg, IRepository context)
        {
            _repo = context;
            _magazine = new Magazine();
            _magazine = _repo.Magazines.First(m => m.ID == arg);
            View.SetFields(_magazine.Name, _magazine.Language, _magazine.Published);
            View.Show();
        }
    }
}
