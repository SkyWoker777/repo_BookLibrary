using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Entities
{
    public class Magazine : Entity, IProduct
    {
        private string _name;
        private string _lang;
        private DateTime? _published;
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
        public DateTime? Published
        {
            get { return _published; }
            set
            {
                _published = value;
                OnPropertyChanged();
            }
        }
        public string Language
        {
            get { return _lang; }
            set
            {
                _lang = value;
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
