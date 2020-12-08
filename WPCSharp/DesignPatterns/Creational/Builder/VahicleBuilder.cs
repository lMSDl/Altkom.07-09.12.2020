using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleBuilder : VehicleBuilderFacade
    {
        public VehicleBuilder() : base()
        {
        }

        public VehicleBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder SetDoors(int value)
        {
            _vehicle.Doors = value;
            return this;
        }

        public VehicleBuilder SetEnginePower(int? value)
        {
            _vehicle.EnginePower = value;
            return this;
        }

        public VehicleBuilder SetSeats(int value)
        {
            _vehicle.Seats = value;
            return this;
        }

        public VehicleBuilder SetTrunkCapacity(int? value)
        {
            _vehicle.TrunkCapacity = value;
            return this;
        }

        public VehicleBuilder SetWheels(int value)
        {
            _vehicle.Wheels = value;
            return this;
        }

    }
}
