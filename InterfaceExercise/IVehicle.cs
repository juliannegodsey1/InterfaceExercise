﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {

       
        public string Color { get; set; }
        public int Year { get; set; }
        public int NumberOfWheels {  get; set; }
        public string Model { get; set; }
  

      

    }
}
