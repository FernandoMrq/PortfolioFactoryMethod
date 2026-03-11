using PortfolioFactoryMethod.Domain;

namespace PortfolioFactoryMethod.Factories;

/// <summary>
/// Abstract creator that declares the factory method. Subclasses override it to produce specific products.
/// </summary>
public abstract class Creator
{
    /// <summary>
    /// Factory method - subclasses implement this to create their specific product.
    /// </summary>
    protected abstract IProduct FactoryMethod();

    /// <summary>
    /// Template method that uses the product created by the factory method.
    /// </summary>
    public string SomeOperation()
    {
        var product = FactoryMethod();
        return product.Operation();
    }
}
