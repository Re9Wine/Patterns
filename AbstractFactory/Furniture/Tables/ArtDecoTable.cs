namespace AbstractFactory.Furniture.Tables;

// Класс стол в стиле ар-деко, одна из реализаций
// интерфейса ITable. Создается фабрикой ArtDecoFactory
public class ArtDecoTable : ITable
{
    public string GetTable() => "Стол в тиле ар-деко";
}