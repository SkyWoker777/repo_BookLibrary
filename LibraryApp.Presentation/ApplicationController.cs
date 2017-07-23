using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation
{
    public class ApplicationController : IApplicationController
    {
        private readonly IAdapter _adapter;

        public ApplicationController(IAdapter adapter)
        {
            _adapter = adapter;
            _adapter.RegisterInstance<IApplicationController>(this);
        }

        public IApplicationController RegisterInstance<TInstance>(TInstance instance)
        {
            _adapter.RegisterInstance(instance);
            return this;
        }

        public IApplicationController RegisterView<TView, TImplementation>()
            where TView : IView
            where TImplementation : class, TView
        {
            _adapter.Register<TView, TImplementation>();
            return this;
        }

        public IApplicationController RegisterService<TService, TImplementation>()
            where TImplementation : class, TService
        {
            _adapter.Register<TService, TImplementation>();
            return this;
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if (!_adapter.IsRegistered<TPresenter>())
            {
                _adapter.Register<TPresenter>();
            }
            var presenter = _adapter.Resolve<TPresenter>();
            presenter.Run();
        }

        public void Run<TPresenter, TArgument, TService>(TArgument arg, TService service)
            where TPresenter : class, IPresenter<TArgument, TService>
        {
            if (!_adapter.IsRegistered<TPresenter>())
            {
                _adapter.Register<TPresenter>();
            }
            var presenter = _adapter.Resolve<TPresenter>();
            presenter.Run(arg, service);
        }
    }
}
