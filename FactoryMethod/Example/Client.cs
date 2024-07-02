namespace FactoryMethod.Example;

public class Client
{
    public void Main()
    {
        Console.WriteLine("Приложение: запущено с помощью ConcreteCreator1.");
        ClientCode(new ConcreteCreator1());
            
        Console.WriteLine("");

        Console.WriteLine("Приложение: запущено с помощью ConcreteCreator2.");
        ClientCode(new ConcreteCreator2());
    }

    // Клиентский код работает с экземпляром конкретного создателя, хотя и
    // через его базовый интерфейс. Пока клиент продолжает работать с
    // создателем через базовый интерфейс, вы можете передать ему любой
    // подкласс создателя.
    public void ClientCode(Creator creator)
    {
        Console.WriteLine("Клиент: Я не знаю класса создателя, но он все еще работает.\n"
                          + creator.SomeOperation());
    }
}