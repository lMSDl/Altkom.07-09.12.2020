using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational
{
    public class VehicleBuilder : IVehicleBuilder<Vehicle>
    {
        private Vehicle _vehicle;

        public VehicleBuilder() : this(new Vehicle())
        {
        }

        public VehicleBuilder(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public IVehicleBuilder<Vehicle> SetDoors(int value)
        {
            _vehicle.Doors = value;
            return this;
        }

        public IVehicleBuilder<Vehicle> SetEnginePower(int? value)
        {
            _vehicle.EnginePower = value;
            return this;
        }

        public IVehicleBuilder<Vehicle> SetSeats(int value)
        {
            _vehicle.Seats = value;
            return this;
        }

        public IVehicleBuilder<Vehicle> SetTrunkCapacity(int? value)
        {
            _vehicle.TrunkCapacity = value;
            return this;
        }

        public IVehicleBuilder<Vehicle> SetWheels(int value)
        {
            _vehicle.Wheels = value;
            return this;
        }

        public Vehicle Build()
        {
            return _vehicle;
        }
    }
}
