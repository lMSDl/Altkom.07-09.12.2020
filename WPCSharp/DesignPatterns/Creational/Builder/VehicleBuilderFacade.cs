using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleBuilderFacade : VehicleBuilderBase
    {
        public VehicleBuilderFacade() : base()
        {
        }

        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Components => new VehicleBuilder(_vehicle);
        public VehicleManufacturingInfoBuilder Manufacturing => new VehicleManufacturingInfoBuilder(_vehicle);
    }
}
