# PortfolioFactoryMethod

A .NET 10 console application demonstrating the **Factory Method** design pattern.

## Overview

This project showcases the Factory Method pattern, which defines an interface for creating objects while letting subclasses decide which class to instantiate. It promotes loose coupling and extensibility (Open/Closed principle).

## Project Structure

```
PortfolioFactoryMethod/
├── src/
│   └── PortfolioFactoryMethod/
│       ├── Domain/           # Product interface and implementations
│       │   ├── IProduct.cs
│       │   ├── ConcreteProductA.cs
│       │   └── ConcreteProductB.cs
│       └── Factories/       # Creator and concrete creators
│           ├── Creator.cs
│           ├── ConcreteCreatorA.cs
│           └── ConcreteCreatorB.cs
└── tests/
    └── PortfolioFactoryMethod.Tests/
```

## Factory Method Pattern

- **Creator**: Abstract class with `FactoryMethod()` and `SomeOperation()` (template method)
- **ConcreteCreatorA / ConcreteCreatorB**: Override `FactoryMethod()` to return their specific product
- **IProduct**: Interface for products
- **ConcreteProductA / ConcreteProductB**: Product implementations

The client depends on the abstract `Creator` and `IProduct` abstractions, not concrete types.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Commands

```bash
# Build
dotnet build

# Run
dotnet run --project src/PortfolioFactoryMethod/PortfolioFactoryMethod.csproj

# Test
dotnet test
```

## Sample Output

```
Factory Method Demo
-------------------
Creator A: Result of ConcreteProductA
Creator B: Result of ConcreteProductB
```
