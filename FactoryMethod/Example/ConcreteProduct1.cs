namespace FactoryMethod.Example;

// ConcreteProduct1 предоставляют различные реализации интерфейса IProduct.
public class ConcreteProduct1 : IProduct
{
    public string Operation()
    {
        return "{Результат ConcreteProduct1}";
    }
}