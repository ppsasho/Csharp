using exercise_4.Classes;
namespace exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region data
            Driver d1 = new Driver("Verstapen", 5);
            Driver d2 = new Driver("Verstapen", 5);
            Driver d3 = new Driver("Verstapen", 5);
            Driver d4 = new Driver("Verstapen", 5);

            Car c1 = new Car("Mercedes", 320);
            Car c2 = new Car("Red Bull", 375);
            Car c3 = new Car("Ferrarri", 290);
            Car c4 = new Car("Mustang", 160);

            Driver[] drivers = new Driver[] { d1, d2, d3, d4 };
            Car[] cars = new Car[] { c1, c2, c3, c4 };
            #endregion
            #region UI Logic
            bool gameEnd = true;
            do
            {
                Console.WriteLine($"Please select the first car: \n1.   {c1.Model}\n2.  {c2.Model}\n3.  {c3.Model}\n4.  {c3.Model}");
                bool canParseFirstCar = int.TryParse(Console.ReadLine(), out int firstCar);

                Console.WriteLine($"Please select the second car: \n1.   {c1.Model}\n2.  {c2.Model}\n3.  {c3.Model}\n4.  {c3.Model}");
                bool canParseSecondCar = int.TryParse(Console.ReadLine(), out int secondCar);

                Console.WriteLine($"Please select the first driver: \n1.   {d1.Name}\n2.  {d2.Name}\n3.  {d3.Name}\n4.  {d4.Name}");
                bool CanParseFirstDriver = int.TryParse(Console.ReadLine(), out int firstDriver);

                Console.WriteLine($"Please select the first driver: \n1.   {d1.Name}\n2.  {d2.Name}\n3.  {d3.Name}\n4.  {d4.Name}");
                bool CanParseSecondDriver = int.TryParse(Console.ReadLine(), out int secondDriver);

                if (canParseFirstCar && canParseSecondCar && CanParseFirstDriver && CanParseSecondDriver)
                {
                    Car firstSelectedCar = cars[firstCar - 1];
                    Car secondSelectedCar = cars[secondCar - 1];

                    Driver firstSelectedDriver = drivers[firstDriver - 1];
                    Driver secondSelectedDriver = drivers[secondDriver - 1];

                    firstSelectedCar.Driver = firstSelectedDriver;
                    secondSelectedCar.Driver = secondSelectedDriver;

                    RaceCars(firstSelectedCar, secondSelectedCar);

                    Console.WriteLine("Do you want to play again? Y  OR  Press X to exit");
                    if (char.TryParse(Console.ReadLine().ToUpper(), out char choice))
                    {
                        switch (choice)
                        {
                            case 'Y':
                                gameEnd = true;
                                break;
                            case 'X':
                            default:
                                gameEnd = false;
                                break;
                        }
                    }
                }
            } while (gameEnd == true);
            #endregion

        }
        #region RaceCar method
        static void RaceCars(Car car, Car secondCar)
        {
            if(car.CalculateSpeed(car.Driver) > secondCar.CalculateSpeed(secondCar.Driver))
            {
                Console.WriteLine($"In the race the winner was {car.Model}. It was driving at {car.Speed} km/h and the driver was {car.Driver.Name}");
            } else if(car.CalculateSpeed(car.Driver) < secondCar.CalculateSpeed(secondCar.Driver)) {
                Console.WriteLine($"In the race the winner was {secondCar.Model}. It was driving at {secondCar.Speed} km/h and the driver was {secondCar.Driver.Name}");
            } else
            {
                Console.WriteLine("It was a stalemate");
            }
        }
        #endregion
    }
}
