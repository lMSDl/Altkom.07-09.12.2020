using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalPatterns.Models
{
    public class Model : NotifyPropertyChanged
    {
        private string _value;

        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                //OnPropertyChaned(nameof(Value));
                OnPropertyChaned();
            }
        }
    }
}
