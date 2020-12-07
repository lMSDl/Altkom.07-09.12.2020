using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational
{
    public static class Client
    {
        public static void Execute()
        {
            var vehicle = new VehicleInfoBuilder()
                .SetWheels(4)
                .SetSeats(5)
                .SetDoors(4)
                .SetTrunkCapacity(500)
                .SetEnginePower(100)
                .Build();

            Console.WriteLine(vehicle);
        }
    }
}
