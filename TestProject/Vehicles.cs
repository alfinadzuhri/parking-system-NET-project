namespace Vehicles
{
    class Vehicle
    {
        private string? type;
        private string? licensePlate;
        private string? color;

        public Vehicle(string type, string licensePlate, string color){
            this.type = type;
            this.licensePlate = licensePlate;
            this.color = color;
        }

        public Vehicle(){
            type=null;
            licensePlate=null;
            color=null;
        } 

        public string? Type {
            get { return type; }
            set { type = value; }
        }

        public string? LicensePlate {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        public string? Color {
            get { return color; }
            set { color = value; }
        }
    }
}