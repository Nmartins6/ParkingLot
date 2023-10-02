using System.Runtime.CompilerServices;
using ParkingLot;

ParkingLot.ParkingLot parkingLot = new ParkingLot.ParkingLot();
ParkingLot.ParkingLotMenu menu = new ParkingLot.ParkingLotMenu(parkingLot);

menu.DisplayMenu();