using AbstractFactory.Furniture.Sofas;
using AbstractFactory.Furniture.Tables;

namespace AbstractFactory.Furniture.Armchairs;

// Класс кресла в стиле ар-деко, одна из реализаций
// интерфейса IArmchair. Создается фабрикой ArtDecoFactory
public class ArtDecoArmchair : IArmchair
{
    public string GetArmchair() => "Кресло в стиле ар-деко";

    public string GetArmchairCollaborateWithSofa(ISofa collaborator) =>
        $"Кресло в стиле ар-деко вместе с {collaborator.GetSofa()}";
    

    public string GetArmchairCollaborateWithTable(ITable collaborator) =>
        $"Кресло в стиле ар-деко вместе с {collaborator.GetTable()}";
}