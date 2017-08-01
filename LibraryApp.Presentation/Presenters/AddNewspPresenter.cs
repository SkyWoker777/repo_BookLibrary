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
    public class AddNewspPresenter : BasePresenter<IAddNewspView, IRepository>
    {
        private IRepository _repo;
        public AddNewspPresenter(IApplicationController controller, IAddNewspView view)
            :base(controller, view)
        {
            View.Add += () => OnAddNewsp(View.NewspaperName, View.PostedOn, View.Cost);
            View.CostNumberChecked += () => ValidateField(View.Cost);
        }

        private void OnAddNewsp(string name, DateTime? postedOn, string cost)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                View.ShowErrName("field can not be empty.");
                return;
            }
            var paper = new Newspaper();
            paper.Name = name;
            paper.PostedOn = postedOn;
            paper.Cost = Convert.ToDouble(cost);
            paper.ID = (_repo.Newspapers.Count() == 0) ? 1 : _repo.Newspapers.Max(n => n.ID + 1);

            _repo.Add(paper);
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
