using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    class Order
    {
        private readonly ICar _car;

        public Order(ICarFactory manufacturer, string type, string segment)
        {
            switch (type)
            {
                case nameof(ISedan):
                    _car = manufacturer.ManufactureSedan(segment);
                    break;
                case nameof(ISuv):
                    _car = manufacturer.ManufactureSuv(segment);
                    break;
                default:
                    break;
            }
        }

        public string ManufacturedCarName()
        {
            return _car.Name();
        }
    }
}
