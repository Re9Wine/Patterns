using Builder.Builders;

namespace Builder;

// Director отвечает только за выполнение шагов построения в определённой
// последовательности. Это полезно при производстве продуктов в определённом
// порядке или особой конфигурации. Строго говоря, класс Director
// необязателен, так как клиент может напрямую управлять строителями.
public class Director
{
    private ICarBuilder? _carBuilder;

    public ICarBuilder SetBuilder
    {
        set => _carBuilder = value;
    }
        
    // Director может строить несколько вариаций продукта, используя
    // одинаковые шаги построения.
    public void BuildMinimalViableCar()
    {
        if (!BuildIsExist()) return;
        
        _carBuilder.BuildModel();
        _carBuilder.BuildSeats();
        _carBuilder.BuildEngine();
    }
        
    public void BuildFullFeaturedCar()
    {
        if (!BuildIsExist()) return;
        
        _carBuilder.BuildModel();
        _carBuilder.BuildSeats();
        _carBuilder.BuildEngine();
        _carBuilder.BuildTripComputer();
        _carBuilder.BuildGPS();
    }

    private bool BuildIsExist()
    {
        if (_carBuilder is not null) return true;
        
        Console.WriteLine("Строитель отсутствует\n");

        return false;

    }
}