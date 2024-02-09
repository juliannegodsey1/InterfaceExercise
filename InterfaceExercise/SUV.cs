using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise 
{
    public class SUV : ICompany , IVehicle
    {
        public int NumberOfSeats {  get; set; }
        public bool AllWheelDrive { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }
    }
}
