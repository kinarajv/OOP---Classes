namespace TypeBasics
{
    public class Car
    {
        public string Make;
        public string _make;
        public string Model { get;  set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public void Start()
        {
            Console.WriteLine($"Starting the {Make} {Model}...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Corolla", 2022, "Blue");

            //Error?
            //Car yourCar = new Car() { Make = "Toyota", Model = "Corolla", Year = 2022, Color = "Blue"};

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model} in {myCar.Color} color.");
            myCar.Start();
        }
    }
}