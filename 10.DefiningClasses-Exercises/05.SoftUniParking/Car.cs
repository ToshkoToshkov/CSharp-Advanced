namespace _05.SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }


        public string Model { get; set; }


        public int HorsePower { get; set; }


        public string RegistrationNumber { get; set; }


        public override string ToString()
        {
            string result = $"Make: {this.Make}" + Environment.NewLine;

            result += $"Model: {this.Model}" + Environment.NewLine;

            result += $"HorsePower: {this.HorsePower}" + Environment.NewLine;

            result += $"RegistrationNumber: {this.RegistrationNumber}" + Environment.NewLine;

            return result;
        }
    }
}
