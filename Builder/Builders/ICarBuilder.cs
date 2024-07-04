namespace Builder.Builders;

// Интерфейс ICarBuilder объявляет создающие методы для различных частей
// объектов Car.
public interface ICarBuilder
{
    void Reset();
    void BuildModel();
    void BuildSeats();
    void BuildEngine();
    void BuildTripComputer();
    void BuildGPS();
    Car GetCar();
}