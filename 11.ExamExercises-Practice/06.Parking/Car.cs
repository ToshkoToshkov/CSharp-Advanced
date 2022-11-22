namespace _06.Parking
{
    public class Car
    {
        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;

            ToString();
        }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public override string ToString()
        {
            string result = $"{Manufacturer} {Model} ({Year})";
            return result.ToString();
        }
    }
}
