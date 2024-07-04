using Builder;
using Builder.Builders;

var director = new Director();
var bmwBuilder = new BMWBuilder();
var toyotaBuilder = new ToyotaBuilder();

Console.WriteLine("Создание машины без Строителя:");
director.BuildFullFeaturedCar();

director.SetBuilder = bmwBuilder;
            
Console.WriteLine("Создание машины BMW с базовой комплектацией:");
director.BuildMinimalViableCar();
Console.WriteLine(bmwBuilder.GetCar());

Console.WriteLine("Создание машины BMW с полной комплектацией:");
director.BuildFullFeaturedCar();
Console.WriteLine(bmwBuilder.GetCar());

director.SetBuilder = toyotaBuilder;

Console.WriteLine("Создание машины Toyota с базовой комплектацией:");
director.BuildMinimalViableCar();
Console.WriteLine(toyotaBuilder.GetCar());

Console.WriteLine("Создание машины Toyota с полной комплектацией:");
director.BuildFullFeaturedCar();
Console.WriteLine(toyotaBuilder.GetCar());

// Помните, что паттерн Строитель можно использовать без класса
// Директор.
Console.WriteLine("Произвольная комплектация BMW:");
bmwBuilder.Reset();
bmwBuilder.BuildModel();
bmwBuilder.BuildEngine();
Console.Write(bmwBuilder.GetCar());
