using Slots;

namespace ParkingLots
{
    class ParkingLot
    {
        private int capacity;
        private List<Slot> slots;

        public ParkingLot(int capacity)
        {
            this.capacity = capacity;
            slots = new List<Slot>();
            for (int i = 1; i <= capacity; i++)
            {
                slots.Add(new Slot(i));
            }
        }

        public ParkingLot()
        {
            capacity = 0;
            slots = new List<Slot>();
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public List<Slot> Slots{
            get{return slots;}
            set{slots=value;}
        }
    }
}