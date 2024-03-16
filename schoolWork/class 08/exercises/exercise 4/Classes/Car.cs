namespace exercise_4.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Car(string model, int speed) 
        {
            Model = model;
            Speed = speed;
        }
        
        //  Navigational Property
        public Driver Driver { get; set; }

        public int CalculateSpeed(Driver driver)
        {
            return driver.Level * Speed;
        }

    }
    
}
