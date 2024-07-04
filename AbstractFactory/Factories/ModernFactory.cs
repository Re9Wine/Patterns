using AbstractFactory.Furniture.Armchairs;
using AbstractFactory.Furniture.Sofas;
using AbstractFactory.Furniture.Tables;

namespace AbstractFactory.Factories;

// Фабрика модерн производит мебель данного стиля. Фабрика гарантирует
// совместимость полученной мебели. Нужно обратить внимание на то, что
// метод возвращает абстракнуюю мебель, при этом он создает экземпляр
// конкретной мебели.
public class ModernFactory : IFurnitureFactory
{
    public IArmchair CreateArmchair() => new ModernArmchair();

    public ISofa CreateSofa() => new ModernSofa();

    public ITable CreateTable() => new ModernTable();
}