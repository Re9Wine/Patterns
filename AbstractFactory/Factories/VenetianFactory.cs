using AbstractFactory.Furniture.Armchairs;
using AbstractFactory.Furniture.Sofas;
using AbstractFactory.Furniture.Tables;

namespace AbstractFactory.Factories;

// Венецианская фабрика производит мебель данного стиля. Фабрика гарантирует
// совместимость полученной мебели. Нужно обратить внимание на то, что
// метод возвращает абстракнуюю мебель, при этом он создает экземпляр
// конкретной мебели.
public class VenetianFactory : IFurnitureFactory
{
    public IArmchair CreateArmchair() => new VenetianArmchair();

    public ISofa CreateSofa() => new VenetianSofa();

    public ITable CreateTable() => new VenetianTable();
}