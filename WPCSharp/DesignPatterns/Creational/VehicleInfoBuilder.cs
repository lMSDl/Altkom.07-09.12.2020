using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational
{
    public class VehicleInfoBuilder : IVehicleBuilder<string>
    {
        public StringBuilder _stringBuilder = new StringBuilder();

        public VehicleInfoBuilder()
        {
            _stringBuilder.Append("Obiekt ma:");
        }

        public string Build()
        {
            return _stringBuilder.ToString().Remove(_stringBuilder.Length - 1);
        }

        public IVehicleBuilder<string> SetDoors(int value)
        {
            _stringBuilder.Append($"{value} drzwi,");
            return this;
        }

        public IVehicleBuilder<string> SetEnginePower(int? value)
        {
            _stringBuilder.Append($"silnik o mocy {value} HP,");
            return this;
        }

        public IVehicleBuilder<string> SetSeats(int value)
        {
            _stringBuilder.Append($"{value} siedzeń,");
            return this;
        }

        public IVehicleBuilder<string> SetTrunkCapacity(int? value)
        {
            _stringBuilder.Append($"{value}l pojemności bagażnika,");
            return this;
        }

        public IVehicleBuilder<string> SetWheels(int value)
        {
            _stringBuilder.Append($"{value} kół,");
            return this;
        }
    }
}
