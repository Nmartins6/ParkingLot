using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLot
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private const int MaxCapacity = 3;

        private const double HourValue = 5;

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

        public bool IsCarVerify(string isCar)
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

        public void ExitVehicle(string numberPlate)
        {
            Vehicle? vehicle = vehicles.Find(searchedVehicle => searchedVehicle.NumberPlate == numberPlate);

            if (vehicle != null)
            {
                DateTime exitTime = DateTime.Now;
                TimeSpan parkedTime = exitTime - vehicle.EntryTime;
                double parkingFee = parkedTime.TotalHours * HourValue;

                Console.WriteLine($"{vehicle.VehicleModel} placa:{vehicle.NumberPlate} saindo");
                Console.WriteLine($"Tempo estacionado: {parkedTime.TotalHours} horas");
                Console.WriteLine($"Taxa de estacionamento: R${parkingFee:F2}");

                vehicles.Remove(vehicle);
            }
            else
            {
                Console.WriteLine($"Informe um valor valido");
            }
        }

        public void ParkingLotCapacity()
        {
            int parkingSpaces = MaxCapacity - vehicles.Count;

            if (parkingSpaces > 0)
            {
                Console.WriteLine($"Ainda temos {parkingSpaces} vagas disponíveis");
                Console.WriteLine("Aperte qualquer tecla para voltar");
                Console.Read();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Estacionamento lotado.");
                Console.WriteLine("Aperte qualquer tecla para voltar");
                Console.Read();
            }
        }

        public void ShowParkedVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                int position = vehicles.IndexOf(vehicle);
                Console.WriteLine("==============================");
                Console.WriteLine($"Vaga {position}");
                Console.WriteLine($"Modelo: {vehicle.VehicleModel}");
                Console.WriteLine($"Placa: {vehicle.NumberPlate}");
                Console.WriteLine($"Entrada: {vehicle.EntryTime}");
                Console.WriteLine("==============================");

            }
        }
    }
}