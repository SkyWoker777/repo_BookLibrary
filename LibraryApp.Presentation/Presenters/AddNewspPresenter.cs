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
    public class AddNewspPresenter : BasePresenter<IAddNewspView>
    {
        private readonly IRepository _repo;
        public AddNewspPresenter(IApplicationController controller, IAddNewspView view, IRepository repository)
            :base(controller, view)
        {
            _repo = repository;
            View.Add += () => OnAddNewsp(View.NewspaperName, View.PostedOn);
        }

        private void OnAddNewsp(string name, DateTime? postedOn)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                var paper = new Newspaper();
                paper.Name = name;
                paper.PostedOn = postedOn;
                paper.ID = (_repo.Newspapers.Count() == 0) ? 1 : _repo.Newspapers.Max(n => n.ID + 1);

                _repo.Add(paper);
                View.Close();
            }
        }
    }
}
