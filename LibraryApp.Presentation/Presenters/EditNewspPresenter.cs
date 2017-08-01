using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Presentation.ViewContracts;
using LibraryApp.Core;
using LibraryApp.Core.Entities;

namespace LibraryApp.Presentation.Presenters
{
    public class EditNewspPresenter : BasePresenter<IEditNewspView, int, IRepository>
    {
        private Newspaper _newsp;
        private IRepository _repo;

        public EditNewspPresenter(IApplicationController controller, IEditNewspView view)
            :base(controller, view)
        {
            View.Save += () => EditClick(View.NewspName, View.PostedOn, View.Cost);
            View.CostNumberChecked += () => ValidateField(View.Cost);
        }

        private void EditClick(string name, DateTime? posted, string cost)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                View.ShowErrName("field can not be empty.");
                return;
            }
            _newsp.Name = name;
            _newsp.PostedOn = posted;
            _newsp.Cost = Convert.ToDouble(cost);

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
            _newsp = new Newspaper();
            _newsp = _repo.Newspapers.First(m => m.ID == arg);
            View.SetFields(_newsp.Name, _newsp.PostedOn, _newsp.Cost.ToString());
            View.Show();
        }
    }
}
