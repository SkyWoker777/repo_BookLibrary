using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Entities
{
    public class Newspaper : Entity, IProduct
    {
        private string _name;
        private DateTime? _posted;
        private double _cost;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public DateTime? PostedOn
        {
            get { return _posted; }
            set
            {
                _posted = value;
                OnPropertyChanged();
            }
        }
        public double Cost
        {
            get { return _cost; }
            set
            {
                _cost = value;
                OnPropertyChanged();
            }
        }
        public int ProductCount { get; set; }
    }
}
