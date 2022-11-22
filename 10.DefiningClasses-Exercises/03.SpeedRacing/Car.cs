namespace _03.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TraveledDistance { get; set; }


        public bool Drive(double distanceTravelled)
        {
            double neededFuel = distanceTravelled * this.FuelConsumptionPerKilometer;

            if (neededFuel > this.FuelAmount)
            {
                return false;
            }

            this.TraveledDistance += distanceTravelled;
            this.FuelAmount -= neededFuel;

            return true;
        }
    }
}
