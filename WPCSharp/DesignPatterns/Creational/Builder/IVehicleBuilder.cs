using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public interface IVehicleBuilder<T>
    {
        IVehicleBuilder<T> SetWheels(int value);
        IVehicleBuilder<T> SetSeats(int value);
        IVehicleBuilder<T> SetDoors(int value);
        IVehicleBuilder<T> SetTrunkCapacity(int? value);
        IVehicleBuilder<T> SetEnginePower(int? value);
        T Build();
    }
}
