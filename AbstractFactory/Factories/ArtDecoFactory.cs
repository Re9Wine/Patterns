using AbstractFactory.Furniture.Armchairs;
using AbstractFactory.Furniture.Sofas;
using AbstractFactory.Furniture.Tables;

namespace AbstractFactory.Factories;

// Фабрика ар-деко производит мебель данного стиля. Фабрика гарантирует
// совместимость полученной мебели. Нужно обратить внимание на то, что
// метод возвращает абстракнуюю мебель, при этом он создает экземпляр
// конкретной мебели.
public class ArtDecoFactory : IFurnitureFactory
{
    public IArmchair CreateArmchair() => new ArtDecoArmchair();

    public ISofa CreateSofa() => new ArtDecoSofa();

    public ITable CreateTable() => new ArtDecoTable();
}