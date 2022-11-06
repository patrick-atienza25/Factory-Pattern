using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string NumOfWheels)
        {
            switch(NumOfWheels)
            {
                case "two":
                case "2":
                    return new Motorcycle();
                case "four":
                case "4":
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
