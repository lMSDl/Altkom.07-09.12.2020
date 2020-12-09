using ArchitecturalPatterns.Commands;
using ArchitecturalPatterns.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ArchitecturalPatterns.ViewModels
{
    public class ViewModel : NotifyPropertyChanged
    {
        private string inputValue;

        public Model Model { get; set; }
        public string InputValue
        {
            get => inputValue;
            set
            {
                inputValue = value;
                //OnPropertyChaned(nameof(InputValue));
                OnPropertyChaned();
            }
        }
        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }

        public ViewModel()
        {
            Model = new Model();
            SaveCommand = new CustomCommand(x => Model.Value = InputValue, x => InputValue != Model.Value);
            LoadCommand = new CustomCommand(x => InputValue = Model.Value, x => InputValue != Model.Value);
        }
    }
}
