using PortfolioFactoryMethod.Domain;

namespace PortfolioFactoryMethod.Factories;

/// <summary>
/// Concrete creator that produces ConcreteProductA.
/// </summary>
public class ConcreteCreatorA : Creator
{
    protected override IProduct FactoryMethod() => new ConcreteProductA();
}
