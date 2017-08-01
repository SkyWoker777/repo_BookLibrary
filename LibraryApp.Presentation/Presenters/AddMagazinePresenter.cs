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
    public class AddMagazinePresenter : BasePresenter<IAddMagazineView, IRepository>
    {
        public IRepository _repo;

        public AddMagazinePresenter(IApplicationController controller, IAddMagazineView view)
            :base(controller,view)
        {
            View.Add += () => OnAddMagazine(View.MagazineName, View.Lang, View.Published, View.Cost);
            View.CostNumberChecked += () => ValidateField(View.Cost);
        }

        private void OnAddMagazine(string name, string lang, DateTime? published, string cost)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                View.ShowErrName("field can not be empty.");
                return;
            }
            var magazine = new Magazine();
            magazine.Name = name;
            magazine.Language = lang;
            magazine.Published = published;
            magazine.Cost = Convert.ToDouble(cost);
            magazine.ID = (_repo.Magazines.Count() == 0) ? 1 : _repo.Magazines.Max(m => m.ID + 1);

            _repo.Add(magazine);
            View.Close();
        }
        private void ValidateField(string field)
        {
            if (!decimal.TryParse(field, out decimal res) && !String.IsNullOrWhiteSpace(field))
            {
                View.ShowErrCost("only numbers");
            }
        }
        public override void Run(IRepository context)
        {
            _repo = context;
            View.Show();
        }
    }
}
