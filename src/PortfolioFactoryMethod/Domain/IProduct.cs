namespace PortfolioFactoryMethod.Domain;

/// <summary>
/// Defines the interface for products created by the Factory Method pattern.
/// </summary>
public interface IProduct
{
    /// <summary>
    /// Performs the product-specific operation.
    /// </summary>
    /// <returns>A string describing the operation result.</returns>
    string Operation();
}
