using Models;

namespace Class5HomeworkRevision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(RacingSimulator());
        }
        public static bool RacingSimulator()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the racing game!");

                Car car1 = GetCar("Pick your first car");
                Driver driver1 = GetDriver("Pick your first driver");
                car1.Driver = driver1;

                Car car2 = GetCar("Pick your second car");
                Driver driver2 = GetDriver("Pick your second driver");
                car2.Driver = driver2;

                RaceCars(car1, car2);

                Console.WriteLine("Would you like to play again? Y / N: ");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "y":
                        continue;
                    case "n":
                        Console.WriteLine("Thanks for playing!");
                        break;
                    default:
                        Console.WriteLine("That wasn't one of the options!");
                        break;
                }
                return false;
            }
        }
        public static void DisplayDrivers()
        {
            int driverCount = 1;
            foreach (var driver in StaticDB.Drivers)
            {
                Console.WriteLine($"{driverCount}) {driver.Name}");
                driverCount++;
            }
        }
        public static void DisplayCars()
        {
            int carCount = 1;
            foreach (Car car in StaticDB.Cars)
            {
                Console.WriteLine($"{carCount}) {car.Model}");
                carCount++;
            }
        }
        public static Driver GetDriver(string input)
        {
            while (true)
            {
                DisplayDrivers();
                int driverNumber = GetNumber("Pick the number corresponding to the driver!");
                if (driverNumber > StaticDB.Drivers.Count || driverNumber < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Please pick between the numbers corresponding to the cars!");
                    continue;
                }
                var driver = StaticDB.Drivers[driverNumber - 1];
                StaticDB.Drivers.Remove(driver);
                return driver; 

            }
        }
        public static Car GetCar(string input)
        {
            while (true) 
            {
                DisplayCars();
                int carNumber = GetNumber("Pick the number corresponding to the car model!");
                if (carNumber > StaticDB.Cars.Count || carNumber < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Please pick between the numbers corresponding to the cars!");
                    continue;
                }
                var car = StaticDB.Cars[carNumber - 1];
                StaticDB.Cars.Remove(car);
                return car;
            }
        }
        public static int GetNumber(string input)
        {
            while (true)
            {
                Console.Write(input);
                bool isNumber = int.TryParse(Console.ReadLine(), out int result);
                if (!isNumber) 
                { 
                    Console.Clear();
                    continue;
                }
                return result;
            }
        }
        public static void RaceCars(Car car1, Car car2)
        {
            int car1TopSpeed = car1.CalculateSpeed();
            int car2TopSpeed = car2.CalculateSpeed();
            if (car1TopSpeed > car2TopSpeed)
            {
                Console.WriteLine($"{car1.Model} wins this race with a top speed of {car1TopSpeed}");
            }
            else
            {
                Console.WriteLine($"{car2.Model} wins this race with a top speed of {car2TopSpeed}");
            }
        }
    }
}
