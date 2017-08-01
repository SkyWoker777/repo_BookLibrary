using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core
{
    public interface IProduct
    {
        int ID { get; }
        string Name { get; }
        double Cost { get; }
        int ProductCount { get; }
    }
}
