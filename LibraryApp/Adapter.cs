using LibraryApp.Presentation;
using LibraryApp.Presentation.ViewContracts;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Adapter : IAdapter
    {
        private IKernel _kernel = new StandardKernel();

        public void Register<TService>()
        {
            _kernel.Bind<TService>().ToSelf();
        }
        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            _kernel.Bind<TService>().To<TImplementation>();
        }

        public void RegisterInstance<T>(T instance)
        {
            _kernel.Bind<T>().ToConstant(instance);
        }

        public bool IsRegistered<TService>() => _kernel.CanResolve<TService>();

        public TService Resolve<TService>() => _kernel.Get<TService>();

    }
}
