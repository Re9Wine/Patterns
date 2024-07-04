using AbstractFactory.Furniture.Sofas;
using AbstractFactory.Furniture.Tables;

namespace AbstractFactory.Furniture.Armchairs;

// Класс кресла в стиле модерн, одна из реализаций
// интерфейса IArmchair. Создается фабрикой ModerFactory
public class ModernArmchair : IArmchair
{
    public string GetArmchair() => "Кресло в стиле модер";
    
    public string GetArmchairCollaborateWithSofa(ISofa collaborator) =>
        $"Кресло в стиле модер вместе с {collaborator.GetSofa()}";

    public string GetArmchairCollaborateWithTable(ITable collaborator) =>
        $"Кресло в стиле модер вместе с {collaborator.GetTable()}";
}