using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_topping
{

    class Mushroom : ToppingDecorator
    {

        private readonly Pizza _pizza;


        public Mushroom(Pizza original) : base(original)
        {
            _pizza = original;
        }

		public override string GetName() {
			return "High there";
		}

		public override string GetDescription()
        {
            return base.GetDescription() + ", shroomies";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 12;

        }


    }

}
