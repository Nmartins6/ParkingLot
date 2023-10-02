using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLot
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private const int MaxCapacity = 1;

        public bool IsFull()
        {
            return vehicles.Count >= MaxCapacity;
        }

        public void EnterVehicle(string vehicleModel, string numberPlate, int vehicleYear, bool isCar)
        {
            if (!IsFull())
            {
                Vehicle vehicle = new Vehicle(vehicleModel, numberPlate, vehicleYear, isCar);
                vehicles.Add(vehicle);
                Console.WriteLine($"Veículo: {vehicleModel}");
                Console.WriteLine($"Placa: {numberPlate}");
                Console.WriteLine($"Estacionado na vaga: //adcionar funcionalidade de busca na lista//");

            }
            else
            {
                Console.WriteLine("Estacionamento cheio, impossível estacionar mais veículos");
            }
        }

        public bool IsCarVerify (string isCar)
        {
            if (isCar == "carro")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}