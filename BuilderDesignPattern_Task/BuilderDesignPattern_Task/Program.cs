namespace BuilderDesignPattern_Task;

public class Program
{
    public interface Builder
    {
        public void reset();
        public void setSeats(int number);
        public void setEngine(SportEngine engine);
        public void setTripComputer();
        public void setGPS();
    }

    public class CarBuilder : Builder
    {
        private Car car;

        public void reset()
        {
            this.car = new Car();
        }

        public void setGPS()
        {
            Console.WriteLine("Set GPS");
        }

        public void setTripComputer()
        {
            Console.WriteLine("Automatic car trip");
        }

        public Car getResult()
        {
            return this.car;
        }

        public void setSeats(int number)
        {
            Console.WriteLine($"Count of seats: {number}");
        }

        public void setEngine(SportEngine engine)
        {
            Console.WriteLine($"Engine name: {engine}");
        }
    }

    public class CarManualBuilder : Builder
    {
        private Manual manual;
        public void reset()
        {
            this.manual = new Manual();
        }

        public void setGPS()
        {
            Console.WriteLine("Set GPS");
        }

        public void setTripComputer()
        {
            Console.WriteLine("Manual car trip");
        }

        public Manual getResult()
        {
            return this.manual;
        }

        public void setSeats(int number)
        {
            Console.WriteLine($"Count of seats: {number}");
        }

        public void setEngine(SportEngine engine)
        {
            Console.WriteLine($"Engine name: {engine}");
        }
    }

    public class Car
    {

    }

    public class Manual
    {

    }

    public class SportEngine
    {
        public string engine { get; set; }

        public SportEngine()
        {
            
        }

        public SportEngine(string engine)
        {
            this.engine = engine;
        }
    }

    public class Director
    {
        public void makeSUV() { }
        public void makeSportsCar(CarBuilder builder)
        {
            builder.reset();
            builder.setSeats(2);
            builder.setEngine(new SportEngine());
            builder.setTripComputer();
            builder.setGPS();
        }
    }

    static void Main(string[] args)
    {
        Director director = new Director();
        CarBuilder builder = new CarBuilder();
        director.makeSportsCar(builder);
        Car car = builder.getResult();
    }
}
