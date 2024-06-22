using Vehicles;

namespace Slots
{
    class Slot{
        private int slotNumber;
        private Vehicle? vehicle;

        public Slot(int slotNumber, Vehicle vehicle){
            this.slotNumber = slotNumber;
            this.vehicle = vehicle;
        }

        public Slot(int slotNumber){
            this.slotNumber=slotNumber;
            vehicle = null;
        }    

        public int getSlotNumber {
            get { return slotNumber; }
            set {slotNumber = value; }
        }

        public Vehicle? getVehicle{
            get { return vehicle; }
            set {vehicle = value; }
        }
    }
}