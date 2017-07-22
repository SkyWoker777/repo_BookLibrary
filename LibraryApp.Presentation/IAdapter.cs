using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation
{
    public interface IAdapter
    {
        void RegisterInstance<T>(T instance);
        void Register<TService>();
        void Register<TService, TImplementation>() where TImplementation : TService;
        TService Resolve<TService>();
        bool IsRegistered<TService>();
    }
}
