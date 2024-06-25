using System.Data;
using ParkingLots;
using Vehicles;
using Slots;
namespace ParkSystemServices
{
    class ParkSystemService
    {
        public static ParkingLot createParkingLot(int capacity, ParkingLot parkingLot)
        {   
            if(parkingLot.Slots.Count > 0){
                int count = parkingLot.Slots.Count;
                for(int i=0; i < capacity; i++){
                    count++;
                    parkingLot.Slots.Add(new Slot(count));
                }
                parkingLot.Capacity += capacity;
                Console.WriteLine($"Created a parking lot with {capacity} slots");
                return parkingLot;
            }
            Console.WriteLine($"Created a parking lot with {capacity} slots"); 
            return new ParkingLot(capacity);
        }
        public static ParkingLot getIn(Vehicle vehicle, ParkingLot parkingLot)
        {

            if(vehicle.Type?.ToLower() != "motor" && vehicle.Type?.ToLower() != "mobil"){
                Console.WriteLine("That's vehicles cannot get in to this park area");
                return parkingLot;
            }

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
                         Console.WriteLine($"Slot number {parkingLot.Slots[i].getSlotNumber} is free");
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
            Console.WriteLine($"There's {count} vehicles");
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
            Console.WriteLine(result);
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
            Console.WriteLine(result);
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
                Console.WriteLine("There's no vehicles with color like that");
            }else{
                Console.WriteLine(result);
            }
        }
        public static void findSlotNumberByColour(string colour, ParkingLot parkingLot){
            int count = 0;
            string result = "";
            foreach(var data in parkingLot.Slots) {
                if (data?.getVehicle != null && data.getVehicle.Color?.Equals(colour, StringComparison.OrdinalIgnoreCase) == true) {
                    if(count > 0){
                        result += ", ";
                    }
                    result += data.getSlotNumber;
                    count++;
                }
            }
            if (count == 0) {
                Console.WriteLine("There's no vehicles with color like that");
            }else{
                Console.WriteLine(result);
            }
        }
        public static void findSlotNumberByLicensePlate(string licensePlate, ParkingLot parkingLot){
            int count = 0;
            string result = "";
            foreach(var data in parkingLot.Slots) {
                if (data?.getVehicle != null && data.getVehicle.LicensePlate?.Equals(licensePlate, StringComparison.OrdinalIgnoreCase) == true) {
                    if(count > 0){
                        result += ", ";
                    }
                    result += data.getSlotNumber;
                    count++;
                }
            }
            if (count == 0) {
                Console.WriteLine("There's no slot of vehicle with license plate like that");
            }else{
                Console.WriteLine(result);
            }
        }
    }
}