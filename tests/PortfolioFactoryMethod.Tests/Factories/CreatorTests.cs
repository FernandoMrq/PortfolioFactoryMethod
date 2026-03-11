using PortfolioFactoryMethod.Factories;

namespace PortfolioFactoryMethod.Tests.Factories;

public class CreatorTests
{
    [Fact]
    public void ConcreteCreatorA_SomeOperation_ReturnsConcreteProductAResult()
    {
        Creator creator = new ConcreteCreatorA();
        var result = creator.SomeOperation();

        Assert.Equal("Result of ConcreteProductA", result);
    }

    [Fact]
    public void ConcreteCreatorB_SomeOperation_ReturnsConcreteProductBResult()
    {
        Creator creator = new ConcreteCreatorB();
        var result = creator.SomeOperation();

        Assert.Equal("Result of ConcreteProductB", result);
    }

    [Fact]
    public void ConcreteCreatorA_ProducesConcreteProductAType()
    {
        Creator creator = new ConcreteCreatorA();
        var result = creator.SomeOperation();

        Assert.Contains("ConcreteProductA", result);
    }

    [Fact]
    public void ConcreteCreatorB_ProducesConcreteProductBType()
    {
        Creator creator = new ConcreteCreatorB();
        var result = creator.SomeOperation();

        Assert.Contains("ConcreteProductB", result);
    }
}
