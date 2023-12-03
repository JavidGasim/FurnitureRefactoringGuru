namespace AbstratcDesignPattern_Task;

public interface AbstractFactory
{
    public ProductA createProductA();
    public ProductB createProductB();
}

public class ConcreteFactory1 : AbstractFactory
{
    public ProductA createProductA()
    {
        return new ConcreteProductA1();
    }

    public ProductB createProductB()
    {
        return new ConcreteProductB1();
    }
}

public class ConcreteFactory2 : AbstractFactory
{
    public ProductA createProductA()
    {
        return new ConcreteProductA2();
    }

    public ProductB createProductB()
    {
        return new ConcreteProductB2();
    }
}