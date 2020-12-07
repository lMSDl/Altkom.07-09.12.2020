using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    public interface ICarFactory
    {
        ISedan ManufactureSedan(string segment);
        ISuv ManufactureSuv(string segment);
    }
}
