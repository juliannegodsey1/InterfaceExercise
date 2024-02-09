using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE: Create 2 Interfaces called IVehicle & ICompany

            //DONE: Create 3 classes called Car , Truck , & SUV

            //DONE: In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //DONE: In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //DONE: In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values


            var car1 = new Car() { Year = 2021, Color = "Black", Model = "Jetta", NumberOfWheels = 4 };
            var truck1 = new Truck() { Year = 2023, Color = "Red", Model = "Ram", NumberOfWheels = 4 };  
            var suv1 = new SUV() { Year = 2024, Color = "White", Model = "Tahoe", NumberOfWheels = 4 };

            var vehicleList = new List<IVehicle>();

            vehicleList.Add(car1);
            vehicleList.Add(truck1);
            vehicleList.Add(suv1);

            foreach (var vehicle in vehicleList)
            {
               
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Number of Wheels: {vehicle.NumberOfWheels}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine("");
                Console.WriteLine("-------");
                Console.WriteLine("");

            }



        }
    }
}
