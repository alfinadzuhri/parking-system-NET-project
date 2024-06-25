# PARKING SYSTEM WITH .NET

## How to run the program

1.  Open this project through the terminal
2.  Then change the directory to the TestProject folder/package
3.  Then run the commands:
    - dotnet build
    - dotnet run

    ## How the Program Works
- When the program runs successfully, it will display a menu of parking system instructions.
- The console will then prompt the user to provide an instruction or exit the program.
- You can give instructions in two ways:
    - First, you can choose a number from the menu list (1 to 10). The console will then prompt you to input the required data.
    - Second, you can give an instruction using this format: 
     <br>→ **instruction_name value**
     <br> Note: Choose an instruction name from the menu list but replace spaces with underscores.
     <br> Example: **create_parking_lot 1**
- If the instruction is correct, an output message indicating successful data input will appear. If there is an issue with the user input, an error message will appear (this program uses exception handling).

## Classes

### `ParkingLot`
This class represents a parking lot.

#### Properties
- **`private int capacity;`**: Represents the capacity of the parking lot.
- **`private List<Slot> slots`**: Represents the number of slots in the parking lot.

#### Methods
- **`public ParkingLot(int capacity)`**: Constructor that initializes a parking lot with specified attributes.
- **`public ParkingLot()`**: Constructor that initializes a parking lot with empty attributes.
- **`public int Capacity`**: For accessing and modifying the `Capacity` property.
- **`public List<Slot> Slots`**: For accessing and modifying the `Slots` property.

### `Slot`
This class represents a slot in a parking lot.

#### Properties
- **`private int slotNumber;`**: Represents the number of the slot in the parking lot.
- **`private Vehicle? vehicle;`**: Represents the vehicle in the slot at the parking lot.

#### Methods
- **`public Slot(int slotNumber, Vehicle vehicle)`**: Constructor that initializes a slot with specified attributes.
- **`public Slot()`**: Constructor that initializes a slot with empty attributes.
- **`public int SlotNumber { get; set; }`**: For accessing and modifying the `slotNumber` property.
- **`public Vehicle? Vehicle { get; set; }`**: For accessing and modifying the `vehicle` property.

### `Vehicle`
This class represents a vehicle parked in the parking lot.

#### Properties
- `private string? type`: The type of vehicle in the lot.
- `private string? licensePlate`: The registration number of the vehicle in the lot.
- `private string? color`: The color of the vehicle in the lot.

#### Methods
- **`public Vehicle(string type, string licensePlate, string color)`**: Constructor that initializes a vehicle in the lot with specified attributes.
- **`public Vehicle()`**: Constructor that initializes a vehicle in the lot with empty attributes.
- **`public string? Type`**: For accessing and modifying the `Type` property.
- **`public string? LicensePlate`**: For accessing and modifying the `LicensePlate` property.
- **`public string? Color`**: For accessing and modifying the `Color` property.

### `ParkSystem`
This class handles requests and responses for the user.

#### Methods
- **`public static void run()`**: This method runs the whole program. It is inside a try-catch block, so any exceptions that occur are already handled.

### `ParkSystemService`
This class handles any services in the parking system.

#### Methods
- **`public static ParkingLot createParkingLot(int capacity, ParkingLot parkingLot)`**: This method handles creating the slots in the parking lot.
- **`public static ParkingLot getIn(Vehicle vehicle, ParkingLot parkingLot)`**: This method handles a vehicle wanting to park in the lot.
- **`public static ParkingLot getOut(int slotNumber, ParkingLot parkingLot)`**: This method handles a vehicle wanting to leave the lot.
- **`public static void status(ParkingLot parkingLot)`**: Retrieves all data of vehicles parked.
- **`public static void typeOfVehicles(string type, ParkingLot parkingLot)`**: Counts vehicles by type in the parking lot.
- **`public static void findOddLicensePlate(ParkingLot parkingLot)`**: Retrieves all vehicles with odd license numbers.
- **`public static void findEvenLicensePlate(ParkingLot parkingLot)`**: Retrieves all vehicles with even license numbers.
- **`public static void findLicensePlateByColour(string colour, ParkingLot parkingLot)`**: Finds license numbers of vehicles by color.
- **`public static void findSlotNumberByColour(string colour, ParkingLot parkingLot)`**: Finds slots of vehicles by color.
- **`public static void findSlotNumberByLicensePlate(string licensePlate, ParkingLot parkingLot)`**: Finds slots of vehicles by license number.

## Main Program (`Program` class)
The `Program` class contains the `Main` method, which serves as the entry point for the application. It calls the `run` method from the `ParkSystem` class and prints the menu to the console.