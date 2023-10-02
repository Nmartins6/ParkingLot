﻿using System.Runtime.CompilerServices;
using ParkingLot;

ParkingLot.ParkingLot parkingLot = new ParkingLot.ParkingLot();

while (true)
{
    Console.WriteLine("===MENU===");
    Console.WriteLine("1. Entrada de veículo.");
    Console.WriteLine("2. Saída de veículo.");
    Console.WriteLine("3. Capacidade do estacionamento.");
    Console.WriteLine("4. Lista vaículos.");
    Console.WriteLine("5. Busca veículo.");
    Console.WriteLine("6. Sair");

    string? strChoice = Console.ReadLine();

    if (int.TryParse(strChoice, out int choice))
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("Informe os dados do veículo:");
                Console.WriteLine("Modelo: ");
                string vehicleModel = Console.ReadLine() ?? "Modelo nao informado";
                Console.WriteLine("Placa: ");
                string numberPlate = Console.ReadLine() ?? "Placa nao informada";
                Console.WriteLine("Ano: ");
                int vehicleYear = Console.Read();
                Console.WriteLine("Carro ou moto: ");
                string isCarStr = Console.ReadLine() ?? "Carro";
                bool isCar = parkingLot.IsCarVerify(isCarStr);
                parkingLot.EnterVehicle(vehicleModel, numberPlate, vehicleYear, isCar);
                break;
            
            case 6:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opções ainda nao implementadas.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Nao rolou");
    }
}