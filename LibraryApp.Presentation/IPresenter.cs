using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Presentation
{
    public interface IPresenter
    {
        void Run();
    }
    public interface IPresenter<in TArgument, in TService>
    {
        void Run(TArgument arg, TService service);
    }
}
