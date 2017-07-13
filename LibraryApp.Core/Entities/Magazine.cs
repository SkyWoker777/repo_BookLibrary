using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Entities
{
    public class Magazine : Entity
    {
        public string Name { get; set; }
        public DateTime Published { get; set; }
        public string Language { get; set; }

    }
}
