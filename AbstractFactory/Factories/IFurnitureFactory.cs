using AbstractFactory.Furniture.Armchairs;
using AbstractFactory.Furniture.Sofas;
using AbstractFactory.Furniture.Tables;

namespace AbstractFactory.Factories;

public interface IFurnitureFactory
{
    IArmchair CreateArmchair();
    ISofa CreateSofa();
    ITable CreateTable();
}