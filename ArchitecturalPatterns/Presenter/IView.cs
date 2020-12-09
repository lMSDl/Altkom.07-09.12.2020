using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalPatterns.Presenter
{
    public interface IView
    {
        void Load(string value);
        void Display(string value);
    }
}
