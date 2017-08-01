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
            View.Save += () => EditClick(View.MagName, View.Lang, View.Published, View.Cost);
            View.CostNumberChecked += () => ValidateField(View.Cost);
        }

        private void EditClick(string name, string lang, DateTime? published, string cost)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                View.ShowErrName("field can not be empty.");
                return;
            }
            _magazine.Name = name;
            _magazine.Language = lang;
            _magazine.Published = published;
            _magazine.Cost = Convert.ToDouble(cost);

            View.Close();
        }
        private void ValidateField(string field)
        {
            if (!decimal.TryParse(field, out decimal res) && !String.IsNullOrWhiteSpace(field))
            {
                View.ShowErrCost("only numbers");
            }
        }
        public override void Run(int arg, IRepository context)
        {
            _repo = context;
            _magazine = new Magazine();
            _magazine = _repo.Magazines.First(m => m.ID == arg);
            View.SetFields(_magazine.Name, _magazine.Language, _magazine.Published, _magazine.Cost.ToString());
            View.Show();
        }
    }
}
