namespace AbstractFactory.Furniture.Tables;

// Класс стол в венецианском стиле, одна из реализаций
// интерфейса ITable. Создается фабрикой VenetianFactory
public class VenetianTable : ITable
{
    public string GetTable() => "Стол в венецианском стиле";
}