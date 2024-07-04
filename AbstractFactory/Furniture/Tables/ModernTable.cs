namespace AbstractFactory.Furniture.Tables;

// Класс стол в стиле модерн, одна из реализаций
// интерфейса ITable. Создается фабрикой ModerFactory
public class ModernTable : ITable
{
    public string GetTable() => "Стол в стиле модерн";
}