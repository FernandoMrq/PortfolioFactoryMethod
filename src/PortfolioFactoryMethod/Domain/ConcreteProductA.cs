namespace PortfolioFactoryMethod.Domain;

/// <summary>
/// Concrete implementation of IProduct for variant A.
/// </summary>
public class ConcreteProductA : IProduct
{
    public string Operation() => "Result of ConcreteProductA";
}
