using AbstractFactory.Furniture.Sofas;
using AbstractFactory.Furniture.Tables;

namespace AbstractFactory.Furniture.Armchairs;

// Интерфейс кресла, он может быть реализован как
// абстрактный класс при необходимости. Он содержит
// все методы (поля), присущие для кресла
public interface IArmchair
{
    // Кресло может работать самостоятельно...
    string GetArmchair();
    
    //А также взаимодействовать с диваном...
    string GetArmchairCollaborateWithSofa(ISofa collaborator);
    
    //Или столом
    string GetArmchairCollaborateWithTable(ITable collaborator);
}