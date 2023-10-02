using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Vehicle

    {
        public string? VehicleModel { get; set; }
        public string? NumberPlate { get; set; }
        public int VehicleYear { get; set; }
        public DateTime EntryTime { get; set; } = DateTime.Now;
        public bool IsCar { get; set; }

        public Vehicle
        (string vehicleModel, string numberPlate, int vehicleYear, bool isCar)
        {
         VehicleModel = vehicleModel;
            NumberPlate = numberPlate;
            VehicleYear = vehicleYear;
            IsCar = isCar;
        }
    }
}