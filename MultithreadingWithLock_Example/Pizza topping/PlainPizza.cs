public class PlainPizza : Pizza {
	public PlainPizza(double price) {
		Name = "Margherita";
		_description = "Tomato sauce, mozzarella, oregano";
		_price = price;
	}
	// This method returns the price of the pizza object with all toppings.
	public override double GetPrice() {
		return _price;
	}
	// This method returns the description of the pizza object with all toppings.
	public override string GetDescription() {
		return _description;
	}

	public override string GetName() {
		return Name;
	}
}
