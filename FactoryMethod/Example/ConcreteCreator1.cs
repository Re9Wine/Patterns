namespace FactoryMethod.Example;

// ConcreteCreator1 переопределяют фабричный метод для того, чтобы
// изменить тип результирующего продукта.
public class ConcreteCreator1 : Creator
{
    // Обратите внимание, что сигнатура метода по-прежнему использует тип
    // абстрактного продукта, хотя  фактически из метода возвращается
    // конкретный продукт. Таким образом, Creator может оставаться
    // независимым от конкретных классов продуктов.
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}