using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Entities
{
    public class Newspaper : Entity
    {
        public string Name { get; set; }
        public DateTime PostedOn { get; set; } 
    }
}
