using AbstractFactory.Furniture.Sofas;
using AbstractFactory.Furniture.Tables;

namespace AbstractFactory.Furniture.Armchairs;

// Класс кресла в венецианском стиле, одна из реализаций
// интерфейса IArmchair. Создается фабрикой VenetianFactory
public class VenetianArmchair : IArmchair
{
    public string GetArmchair() => "Кресл в венецианском стиле";

    public string GetArmchairCollaborateWithSofa(ISofa collaborator) =>
        $"Кресл в венецианском стиле вместе с {collaborator.GetSofa()}";

    public string GetArmchairCollaborateWithTable(ITable collaborator) =>
        $"Кресл в венецианском стиле вместе с {collaborator.GetTable()}";
}