namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            HashSet<string> carsNumber = new HashSet<string>();

            while (command != "END")
            {
                string[] currInput = command.Split(", ");

                string currCommand = currInput[0];
                string number = currInput[1];

                if (currCommand == "IN")
                {
                    carsNumber.Add(number);
                }

                if (currCommand == "OUT")
                {
                    if (carsNumber.Contains(number))
                    {
                        carsNumber.Remove(number);
                    }
                }

                command = Console.ReadLine();
            }


            if (carsNumber.Count > 0)
            {
                foreach (var item in carsNumber)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
