using AbstractFactory.Factories;

namespace AbstractFactory;

// Клиентский код работает с фабриками и продуктами только через абстрактные
// типы. Это позволяет передавать любой подкласс фабрики или продукта
// клиентскому коду, не нарушая его.
public class Client
{
    public void Main()
    {
        // Клиентский код может работать с любым конкретным классом фабрики.
        Console.WriteLine("Клиент: Тестирование клиентского кода с фабрикой модерн...");
        ClientMethod(new ModernFactory());
        Console.WriteLine();

        Console.WriteLine("Клиент: Тестирование клиентского кода с фабрикой ар-деко...");
        ClientMethod(new ArtDecoFactory());
        Console.WriteLine();
        
        Console.WriteLine("Клиент: Тестирование клиентского кода с венецианской фабриокй...");
        ClientMethod(new VenetianFactory());
    }

    private static void ClientMethod(IFurnitureFactory factory)
    {
        var armchair = factory.CreateArmchair();
        var sofa = factory.CreateSofa();
        var table = factory.CreateTable();

        Console.WriteLine(armchair.GetArmchair());
        Console.WriteLine(armchair.GetArmchairCollaborateWithSofa(sofa));
        Console.WriteLine(armchair.GetArmchairCollaborateWithTable(table));
        Console.WriteLine(sofa.GetSofa());
        Console.WriteLine(table.GetTable());
    }
}