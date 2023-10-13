namespace Pizza_topping {
	internal class Program {
		static void Main() {
			Pizza PlainPizza = new PlainPizza(50);
			Pizza Margerita = new Extracheese(PlainPizza);
			Pizza Mushrooms = new Mushroom(PlainPizza);
			Pizza Capricossa = new Ham(PlainPizza);
			Pizza Mexican = new Jalapeno(PlainPizza);
			Pizza Procuittoefungi = new Mushroom(Capricossa);


			PrintPizzaInfo(PlainPizza, PlainPizza.Name);
			PrintPizzaInfo(Margerita, "Margerita extra cheese");
			PrintPizzaInfo(Capricossa, "Capricossa");
			PrintPizzaInfo(Mexican, "Mexican");
			PrintPizzaInfo(Mushrooms, "Mushrooms");
			PrintPizzaInfo(Procuittoefungi, "Procuittoefungi e fungi"); 
		}

		private static void PrintPizzaInfo(Pizza pizza, String pizzaName) {
			Console.WriteLine($"{pizzaName}");
			Console.WriteLine($"Toppings: {pizza.GetDescription()}");
			Console.WriteLine($"Price: {pizza.GetPrice()}");
		}
	}
}