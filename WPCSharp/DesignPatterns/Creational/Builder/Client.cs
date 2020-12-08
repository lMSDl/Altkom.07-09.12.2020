using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public static class Client
    {
        public static void Execute()
        {
            /*var vehicle = new VehicleBuilder()
                .SetWheels(4)
                .SetSeats(5)
                .SetDoors(4)
                .SetTrunkCapacity(500)
                .SetEnginePower(100)
                .Build();

            vehicle = new VehicleManufacturingInfoBuilder(vehicle)
                 .SetModel("X012")
                    .SetManufacturer("Altkom")
                    .SetProductionDate(DateTime.Now)
                    .Build();*/

            var vehicle = new VehicleBuilderFacade()
                .Components
                    .SetWheels(4)
                    .SetSeats(5)
                    .SetDoors(4)
                    .SetTrunkCapacity(500)
                    .SetEnginePower(100)
                .Manufacturing
                    .SetModel("X012")
                    .SetManufacturer("Altkom")
                    .SetProductionDate(DateTime.Now)
                 .Build();

            Console.WriteLine(vehicle);
        }
    }
}
