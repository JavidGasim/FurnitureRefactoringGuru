namespace AbstratcDesignPattern_Task;

public class Client
{
    private AbstractFactory factory;

    public Client(AbstractFactory factory)
    {
        this.factory = factory;
    }

    public void someOperation()
    {
        ProductA pa = factory.createProductA();
    }
}
