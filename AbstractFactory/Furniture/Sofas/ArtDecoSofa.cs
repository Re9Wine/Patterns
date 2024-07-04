namespace AbstractFactory.Furniture.Sofas;

// Класс диван в стиле ар-деко, одна из реализаций
// интерфейса ISofa. Создается фабрикой ArtDecoFactory
public class ArtDecoSofa : ISofa
{
    public string GetSofa() => "Диван в стиле ар-деко";
}