using PortfolioFactoryMethod.Factories;

Creator creatorA = new ConcreteCreatorA();
Creator creatorB = new ConcreteCreatorB();

Console.WriteLine("Factory Method Demo");
Console.WriteLine("-------------------");
Console.WriteLine($"Creator A: {creatorA.SomeOperation()}");
Console.WriteLine($"Creator B: {creatorB.SomeOperation()}");
