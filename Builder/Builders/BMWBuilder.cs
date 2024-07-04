namespace Builder.Builders;

// Класс BMWBuilderя следуют интерфейсу ICarBuilder и предоставляют
// конкретные реализации шагов построения машины BMW.
public class BMWBuilder : ICarBuilder
{
    private Car _car = new();
    
    public void Reset() => _car = new Car();

    public void BuildModel()
    {
        _car.Model = "BMW X5";
    }

    public void BuildSeats()
    {
        _car.Seats = 7;
    }

    public void BuildEngine()
    {
        _car.Engine = "3.0L";
    }

    public void BuildTripComputer()
    {
        _car.TripComputer = true;
    }

    public void BuildGPS()
    {
        _car.GPS = false;
    }

    public Car GetCar() => _car;
}