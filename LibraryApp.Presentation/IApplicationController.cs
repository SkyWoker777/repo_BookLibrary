using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation
{
    public interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;

        IApplicationController RegisterService<TService, TImplementation>()
            where TImplementation : class, TService;

        IApplicationController RegisterInstance<TInstance>(TInstance instance);

        void Run<TPresenter>() where TPresenter : class, IPresenter;

        void Run<TPresenter, TArgumnent, TService>(TArgumnent argumnent, TService service)
            where TPresenter : class, IPresenter<TArgumnent, TService>;
    }
}
