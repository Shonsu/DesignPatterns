using Decorator;

var pizzaBase = new MediumPizza();

var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);
System.Console.WriteLine($"mediumPizzaWithCheese price: {mediumPizzaWithCheese.CalculatePrice()}");

var mediumPizzaWithCheeseHam = new HamPizzaDecorator(mediumPizzaWithCheese);

System.Console.WriteLine($"mediumPizzaWithCheeseHam price: {mediumPizzaWithCheeseHam.CalculatePrice()}");

var mediumPizzaWithCheese2Ham = new HamPizzaDecorator(mediumPizzaWithCheeseHam);

System.Console.WriteLine($"mediumPizzaWithCheeseDoubleHam price: {mediumPizzaWithCheese2Ham.CalculatePrice()}");
