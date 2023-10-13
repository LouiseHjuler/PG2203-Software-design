using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public	abstract class ToppingDecorator : Pizza {
	private readonly Pizza _original;

	protected ToppingDecorator(Pizza original) {
		_original = original;
	}

	public override string GetDescription() {
		return _original.GetDescription();
	}

	public override double GetPrice() {
		return _original.GetPrice();	
	}
	public override string GetName() {
		return Name;
	}
}

// BUT WHAT DOES IT MEAN?! 