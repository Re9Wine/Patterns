namespace Builder.Builders;

// Класс ToyotaBuilder следуют интерфейсу ICarBuilder и предоставляют
// конкретные реализации шагов построения машины Toyota.
public class ToyotaBuilder : ICarBuilder
{
    private Car _car = new();
    
    public void Reset() => _car = new Car();

    public void BuildModel()
    {
        _car.Model = "Toyota Camry";
    }

    public void BuildSeats()
    {
        _car.Seats = 5;
    }

    public void BuildEngine()
    {
        _car.Engine = "4.0L";
    }

    public void BuildTripComputer()
    {
        _car.TripComputer = true;
    }

    public void BuildGPS()
    {
        _car.GPS = true;
    }

    public Car GetCar() => _car;
}