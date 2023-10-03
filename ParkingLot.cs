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
        private const int MaxCapacity = 1;

        private const double HourValue = 5;

        private const double EntryValue = 5;

        public bool IsFull()
        {
            return vehicles.Count >= MaxCapacity;
        }

        public void EnterVehicle()
        {

            if (!IsFull())
            {
                Console.Clear();
                Console.WriteLine("Informe os dados do veículo:");
                Console.WriteLine("Modelo: ");
                string vehicleModel = Console.ReadLine() ?? "Modelo não informado";
                Console.WriteLine("Cor: ");
                string vehicleColor = Console.ReadLine() ?? "Cor não informada";
                Console.WriteLine("Placa: ");
                string numberPlate = Console.ReadLine() ?? "Placa não informada";
                Console.WriteLine("Ano: ");
                int vehicleYear = int.Parse(Console.ReadLine() ?? "Ano não informado");

                Vehicle vehicle = new Vehicle(vehicleModel, vehicleColor, numberPlate, vehicleYear);
                vehicles.Add(vehicle);

                int position = vehicles.IndexOf(vehicle);

                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine($"| Veículo: {vehicleModel} {vehicleColor}          |");
                Console.WriteLine($"| Placa: {numberPlate}             |    ");
                Console.WriteLine($"| Estacionado na vaga: {position}      |");
                Console.WriteLine("========================================");
                Console.WriteLine("**Aperte ENTER para retornar ao menu principal**");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("======================");
                Console.WriteLine("|Estacionamento cheio|");
                Console.WriteLine("======================");
                Console.WriteLine("**Aperte ENTER para retornar ao menu principal**");
                Console.Read();
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

        public void ExitVehicle()
        {
            Console.Clear();
            Console.WriteLine("Informe o veículo que está saíndo");
            string exitNumberPlate = Console.ReadLine() ?? "";
            Vehicle? vehicle = vehicles.Find(searchedVehicle => searchedVehicle.NumberPlate == exitNumberPlate);

            if (vehicle != null)
            {
                Console.Clear();
                DateTime exitTime = DateTime.Now;
                TimeSpan parkedTime = exitTime - vehicle.EntryTime;
                double parkingFee = parkedTime.TotalHours * HourValue;

                Console.WriteLine($"{vehicle.VehicleModel} placa:{vehicle.NumberPlate} saindo");
                Console.WriteLine($"Tempo estacionado: {parkedTime.TotalHours} horas");
                Console.WriteLine($"Taxa de estacionamento: R${parkingFee:F2}");

                vehicles.Remove(vehicle);
                Console.WriteLine("**Aperte ENTER para retornar ao menu principal**");
                Console.Read();

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
            Console.WriteLine("Aperte qualquer tecla para voltar");
            Console.Read();
        }

        public void FindVehicle()
        {
            Console.WriteLine("Informe a placa do veículo que deseja buscar: ");
            string numberPlate = Console.ReadLine() ?? "";
            Vehicle? vehicle = vehicles.Find(searchedVehicle => searchedVehicle.NumberPlate == numberPlate);

            if (vehicle != null)
            {
                int position = vehicles.IndexOf(vehicle);
                Console.WriteLine("==============================");
                Console.WriteLine($"Vaga {position}");
                Console.WriteLine($"Modelo: {vehicle.VehicleModel}");
                Console.WriteLine($"Placa: {vehicle.NumberPlate}");
                Console.WriteLine($"Entrada: {vehicle.EntryTime}");
                Console.WriteLine("==============================");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Veículo não encontrado, confira a placa e tente novamente");
                Console.Read();
            }
            Console.WriteLine("Aperte qualquer tecla para retornar ao menu principal.");
        }
    }
}