using Vehicles;
using ParkingLots;
using ParkSystems;
using System.Security.AccessControl;
using System.Security.Cryptography;


namespace ParkingSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new();

            Console.WriteLine("\n=================================================================================");
            Console.WriteLine("                                 PARKING SYSTEM                                    ");
            Console.WriteLine("=================================================================================");
            Console.WriteLine("\nList Of Instruction: ");
            Console.WriteLine();
            Console.WriteLine("1.  Create Parking Lot       6.  Registration Numbers For Vehicles With Odd Plate");
            Console.WriteLine("2.  Park                     7.  Registration Numbers For Vehicles With Even Plate");
            Console.WriteLine("3.  Leave                    8.  Registration Numbers For Vehicles With Colour");
            Console.WriteLine("4.  Status                   9.  Slot Numbers For Vehicles With Colour");
            Console.WriteLine("5.  Type Of Vehicle          10. Slot Number For Registration Number");

            // Print the note
            Console.WriteLine("\nNote: ");
            Console.WriteLine("You can choose instruction by choose the number or use this format");
            Console.WriteLine("(create_parking_lot <value>)");
            Console.WriteLine("\n=================================================================================");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nGive your instruction or exit: ");
                    Console.Write("$ ");
                    var input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input)) continue;
                    var commands = input.Split(' ');

                    switch (commands[0])
                    {
                        case "1":
                        case "create_parking_lot":
                            if (commands.Length > 1)
                            {
                                parkingLot = ParkSystem.createParkingLot(int.Parse(commands[1]));
                                break;
                            }
                            Console.Write("\n>> Enter the number of parking slot: ");
                            var amount = Console.ReadLine();
                            if (string.IsNullOrEmpty(amount)) continue;
                            parkingLot = ParkSystem.createParkingLot(int.Parse(amount));
                            break;

                        case "2":
                        case "park":
                            Vehicle vehicle = new();
                            if (commands.Length > 1)
                            {
                                vehicle.LicensePlate = commands[1];
                                vehicle.Color = commands[2];
                                vehicle.Type = commands[3];
                                parkingLot = ParkSystem.getIn(vehicle, parkingLot);
                                break;
                            }

                            Console.WriteLine("Enter vehicle data: \n(format input -> B-1234-XYZ Putih Mobil)");
                            Console.Write(">> ");

                            var vehicleInput = Console.ReadLine();
                            if (string.IsNullOrEmpty(vehicleInput)) continue;
                            var splitCommand = vehicleInput.Split(' ');

                            vehicle.LicensePlate = splitCommand[0];
                            vehicle.Color = splitCommand[1];
                            vehicle.Type = splitCommand[2];

                            parkingLot = ParkSystem.getIn(vehicle, parkingLot);

                            break;

                        case "3":
                        case "leave":
                            if (commands.Length > 1)
                            {
                                parkingLot = ParkSystem.getOut(int.Parse(commands[1]), parkingLot);
                                break;
                            }
                            Console.WriteLine("Enter slot number: ");
                            Console.Write(">> ");
                            var slotNumeber = Console.ReadLine();
                            if (string.IsNullOrEmpty(slotNumeber)) continue;
                            parkingLot = ParkSystem.getOut(int.Parse(slotNumeber), parkingLot);
                            break;

                        case "4":
                        case "status":
                            ParkSystem.status(parkingLot);
                            break;

                        case "5":
                        case "type_of_vehicles":
                        if (commands.Length > 1)
                            {
                                ParkSystem.typeOfVehicles(commands[1], parkingLot);
                                break;
                            }
                            Console.WriteLine("Enter type of vehicles:");
                            Console.Write(">> ");
                            var type = Console.ReadLine();
                            if (string.IsNullOrEmpty(type)) continue;

                            ParkSystem.typeOfVehicles(type, parkingLot);
                        break;

                        case "exit":
                            return;
                        default:
                            Console.WriteLine("Wrong instruction!");
                            break;

                    }

                    Console.WriteLine($"\nCapacity: {parkingLot.Capacity}");
                    foreach (var slot in parkingLot.Slots)
                    {
                        Console.WriteLine($"Slot Number: {slot.getSlotNumber}, Vehicle: {slot.getVehicle}");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetBaseException().Message);
                    Console.Write("\nDo you want to continue (Y/N)?");
                    var instruction = Console.ReadLine();
                    if (instruction == "N" || instruction == "n") break;
                }
            }
        }
    }

}




/* 
1. Create Parking Lot       6.  Registration Numbers For Vehicles With Odd Plate 
2. Park                     7.  Registration Numbers For Vehicles With Even Plate
3. Leave                    8.  Registration Numbers For Vehicles With Colour
4. Status                   9.  Slot Numbers For Vehicles With Colour
5. Type Of Vehicle          10. Slot Number For Registration Number

Note: 
You can choose instruction by choose the number or use this format
(create_parking_lot <value>)

----------------------------------------------------------------------------------
>> Give your instruction or exit: 
B-1234-XYZ Putih Mobil
*/
