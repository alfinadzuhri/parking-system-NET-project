using ParkingLots;
using Slots;
using Vehicles;
using ParkSystemServices;

namespace ParkSystems{
    class ParkSystem{
        public static void run(){
            ParkingLot parkingLot = new();
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
                                parkingLot = ParkSystemService.createParkingLot(int.Parse(commands[1]), parkingLot);
                                break;
                            }
                            Console.Write("\n>> Enter the number of parking slot: ");
                            var amount = Console.ReadLine();
                            if (string.IsNullOrEmpty(amount)) continue;
                            parkingLot = ParkSystemService.createParkingLot(int.Parse(amount), parkingLot);
                            break;

                        case "2":
                        case "park":
                            Vehicle vehicle = new();
                            if (commands.Length > 1)
                            {
                                vehicle.LicensePlate = commands[1];
                                vehicle.Color = commands[2];
                                vehicle.Type = commands[3];
                                parkingLot = ParkSystemService.getIn(vehicle, parkingLot);
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

                            parkingLot = ParkSystemService.getIn(vehicle, parkingLot);

                            break;

                        case "3":
                        case "leave":
                            if (commands.Length > 1)
                            {
                                parkingLot = ParkSystemService.getOut(int.Parse(commands[1]), parkingLot);
                                break;
                            }
                            Console.WriteLine("Enter slot number: ");
                            Console.Write(">> ");
                            var slotNumeber = Console.ReadLine();
                            if (string.IsNullOrEmpty(slotNumeber)) continue;
                            parkingLot = ParkSystemService.getOut(int.Parse(slotNumeber), parkingLot);
                            break;

                        case "4":
                        case "status":
                         ParkSystemService.status(parkingLot);
                            break;

                        case "5":
                        case "type_of_vehicles":
                            if (commands.Length > 1)
                            {
                             ParkSystemService.typeOfVehicles(commands[1], parkingLot);
                                break;
                            }
                            Console.WriteLine("Enter type of vehicles:");
                            Console.Write(">> ");
                            var type = Console.ReadLine();
                            if (string.IsNullOrEmpty(type)) continue;

                         ParkSystemService.typeOfVehicles(type, parkingLot);
                            break;

                        case "6":
                        case "registration_numbers_for_vehicles_with_ood_plate":
                         ParkSystemService.findOddLicensePlate(parkingLot);
                            break;

                        case "7":
                        case "registration_numbers_for_vehicles_with_event_plate":
                         ParkSystemService.findEvenLicensePlate(parkingLot);
                            break;

                        case "8":
                        case "registration_numbers_for_vehicles_with_colour":
                            if (commands.Length > 1)
                            {
                             ParkSystemService.findLicensePlateByColour(commands[1], parkingLot);
                                break;
                            }
                            Console.WriteLine("Enter colour of vehicles:");
                            Console.Write(">> ");
                            var color = Console.ReadLine();
                            if (string.IsNullOrEmpty(color)) continue;

                         ParkSystemService.findLicensePlateByColour(color, parkingLot);
                            break;
                        case "9":
                        case "slot_numbers_for_vehicles_with_colour":
                            if (commands.Length > 1)
                            {
                             ParkSystemService.findSlotNumberByColour(commands[1], parkingLot);
                                break;
                            }
                            Console.WriteLine("Enter colour of vehicles:");
                            Console.Write(">> ");
                            var colorInput = Console.ReadLine();
                            if (string.IsNullOrEmpty(colorInput)) continue;

                         ParkSystemService.findSlotNumberByColour(colorInput, parkingLot);
                            break;
                        case "10":
                        case "slot_number_for_registration_number":
                            if (commands.Length > 1)
                            {
                             ParkSystemService.findSlotNumberByLicensePlate(commands[1], parkingLot);
                                break;
                            }
                            Console.WriteLine("Enter license plate of vehicles:");
                            Console.Write(">> ");
                            var licensePlate = Console.ReadLine();
                            if (string.IsNullOrEmpty(licensePlate)) continue;

                         ParkSystemService.findSlotNumberByLicensePlate(licensePlate, parkingLot);
                            break;

                        case "exit":
                            return;
                        default:
                            Console.WriteLine("Wrong instruction!");
                            break;

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