using PortfolioFactoryMethod.Domain;

namespace PortfolioFactoryMethod.Factories;

/// <summary>
/// Concrete creator that produces ConcreteProductB.
/// </summary>
public class ConcreteCreatorB : Creator
{
    protected override IProduct FactoryMethod() => new ConcreteProductB();
}
