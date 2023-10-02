using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Veichle
    {
        public string? VeichleModel { get; set; }
        public string? NumberPlate { get; set; }
        public int VeichleYear { get; set; }
        public DateTime EntryTime { get; set; } = DateTime.Now;
        public bool IsCar { get; set; }

        public Veichle(string veichleModel, string numberPlate, int veichleYear, bool isCar)
        {
            VeichleModel = veichleModel;
            NumberPlate = numberPlate;
            VeichleYear = veichleYear;
            IsCar = isCar;
        }
    }
}