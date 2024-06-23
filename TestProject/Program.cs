using System;
using ParkSystems;

namespace ParkingSystems
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("\nNote: ");
            Console.WriteLine("You can choose instruction by choose the number or use this format");
            Console.WriteLine("(create_parking_lot <value>)");
            Console.WriteLine("\n=================================================================================");
            
            //run the parking system
            ParkSystem.run();

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
