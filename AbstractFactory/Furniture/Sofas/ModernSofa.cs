namespace AbstractFactory.Furniture.Sofas;

// Класс диван в стиле модерн, одна из реализаций
// интерфейса ISofa. Создается фабрикой ModerFactory
public class ModernSofa : ISofa
{
    public string GetSofa() => "Диван в стиле модерн";
}