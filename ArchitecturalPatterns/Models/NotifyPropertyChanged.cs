using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ArchitecturalPatterns.Models
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChaned([CallerMamerName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
