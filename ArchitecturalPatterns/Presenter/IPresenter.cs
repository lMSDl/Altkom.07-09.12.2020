using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalPatterns.Presenter
{
    public interface IPresenter
    {
        void Save(string value);
        void Load();
    }
}
