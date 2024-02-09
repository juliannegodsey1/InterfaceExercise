using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public int NumberOfDoors { get; set; }
        public bool HasTrunk { get; set; }

        public string Name { get; set; }
        public string Logo { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }
    }
}
