using System.Data;
using ParkingLots;
using Vehicles;
namespace ParkSystems
{
    class ParkSystem
    {

        public static ParkingLot createParkingLot(int capacity)
        {
            Console.WriteLine($"Created a parking lot with {capacity} slots");
            return new ParkingLot(capacity);
        }
        public static ParkingLot getIn(Vehicle vehicle, ParkingLot parkingLot)
        {

            for (int i = 0; i < parkingLot.Capacity; i++)
            {
                if (parkingLot.Slots[i].getVehicle == null)
                {
                    parkingLot.Slots[i].getVehicle = vehicle;
                    Console.WriteLine($"Allocated slot number: {i + 1}");
                    return parkingLot;
                }
            }
            Console.WriteLine("Sorry parking lot is full");
            return parkingLot;
        }
        public static ParkingLot getOut(int slotNumber, ParkingLot parkingLot)
        {
            {
                for (int i = 0; i < parkingLot.Capacity; i++){
                    if (parkingLot.Slots[i].getSlotNumber == slotNumber){
                         parkingLot.Slots[i].getVehicle = null;
                         Console.WriteLine("test");
                         return parkingLot;
                    }
                }

                Console.WriteLine("There's no slot number like that");
                return parkingLot;
               
            }
        }
        public static void status(ParkingLot parkingLot){
            Console.WriteLine($"{"Slot No.",-10} {"Registration No",-15} {"Type",-10} {"Colour",-10}");
            foreach(var data in parkingLot.Slots){
                if (data.getVehicle != null) {
                    Console.WriteLine($"{data.getSlotNumber,-10} {data.getVehicle.LicensePlate,-15} {data.getVehicle.Type,-10} {data.getVehicle.Color,-10}");
                }
            };
        }

        public static void typeOfVehicles(string type,ParkingLot parkingLot){
            int count = 0;
            foreach(var data in parkingLot.Slots) {
                if (data?.getVehicle != null && data.getVehicle.Type?.Equals(type, StringComparison.OrdinalIgnoreCase) == true) {
                    count++;
                }
            }
            if (count == 0) {
                Console.WriteLine("There's no type of vehicle like that");
            }
            Console.WriteLine(count);
        }

        public static void findOddLicensePlate(ParkingLot parkingLot){
            int count = 0;
            string result = "";
            foreach(var data in parkingLot.Slots) {

                if (data?.getVehicle?.LicensePlate != null && int.Parse(data.getVehicle.LicensePlate.Split('-')[1]) % 2 != 0) {
                    if(count > 0){
                        result += ", ";
                    }
                    result += data.getVehicle.LicensePlate;
                    count++;
                }
            }
            if (count == 0) {
                Console.WriteLine("There's no type of vehicle with odd license plate");
            } else {
                Console.WriteLine(result);
            }
        }

        public static void findEvenLicensePlate(ParkingLot parkingLot){
            int count = 0;
            string result = "";
            foreach(var data in parkingLot.Slots) {
                if (data?.getVehicle?.LicensePlate != null && int.Parse(data.getVehicle.LicensePlate.Split('-')[1]) % 2 == 0) {
                    if(count > 0){
                        result += ", ";
                    }
                    result += data.getVehicle.LicensePlate;
                    count++;
                }
            }
            if (count == 0) {
                Console.WriteLine("There's no type of vehicle with even license plate");
            }else{
                Console.WriteLine(result);
            }
        }

        public static void findLicensePlateByColour(string colour, ParkingLot parkingLot){
            int count = 0;
            string result = "";
            foreach(var data in parkingLot.Slots) {
                if (data?.getVehicle != null && data.getVehicle.Color?.Equals(colour, StringComparison.OrdinalIgnoreCase) == true) {
                    if(count > 0){
                        result += ", ";
                    }
                    result += data.getVehicle.LicensePlate;
                    count++;
                }
            }
            if (count == 0) {
                Console.WriteLine("There's no colour of vehicle with even license plate");
            }else{
                Console.WriteLine(result);
            }
        }
    }
}