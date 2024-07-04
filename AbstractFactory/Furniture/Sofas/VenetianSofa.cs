namespace AbstractFactory.Furniture.Sofas;

// Класс диван в венецианском стиле, одна из реализаций
// интерфейса ISofa. Создается фабрикой VenetianFactory
public class VenetianSofa : ISofa
{
    public string GetSofa() => "Диван в венецианском стиле";
}