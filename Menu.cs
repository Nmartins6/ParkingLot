using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using ParkingLot;

namespace ParkingLot
{
    public class ParkingLotMenu
    {
        ParkingLot parkingLot = new ParkingLot();

        public ParkingLotMenu(ParkingLot parkingLot)
        {
            this.parkingLot = parkingLot;
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("============== MENU ==============");
                Console.WriteLine("|1. Entrada de veículo.          |");
                Console.WriteLine("|2. Saída de veículo.            |");
                Console.WriteLine("|3. Capacidade do estacionamento.|");
                Console.WriteLine("|4. Lista veículos.              |");
                Console.WriteLine("|5. Busca veículo.               |");
                Console.WriteLine("|6. Sair.                        |");
                Console.WriteLine("==================================");
                string? strChoice = Console.ReadLine();

                if (int.TryParse(strChoice, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            parkingLot.EnterVehicle();
                            break;

                        case 2:
                            parkingLot.ExitVehicle();
                            break;

                        case 3:
                            parkingLot.ParkingLotCapacity();
                            break;

                        case 4:
                            parkingLot.ShowParkedVehicles();
                            break;

                        case 5:
                            parkingLot.FindVehicle();
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
                    Console.WriteLine("Erro na opção informada, Tente novamente.");
                    Console.WriteLine("**Aperte ENTER para retornar ao menu principal");
                    Console.Read();
                }
            }
        }
    }
}