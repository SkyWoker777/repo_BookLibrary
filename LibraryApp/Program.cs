using LibraryApp.Core;
using LibraryApp.Presentation;
using LibraryApp.Presentation.Presenters;
using LibraryApp.Presentation.ViewContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new Adapter())
                .RegisterView<IMainView, MainForm>()
                .RegisterService<IRepository, Repository>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<MainPresenter>();
        }
    }
}
