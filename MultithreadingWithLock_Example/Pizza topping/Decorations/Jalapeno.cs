using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_topping
{

    class Jalapeno : ToppingDecorator
    {

        private readonly Pizza _pizza;


        public Jalapeno(Pizza original) : base(original)
        {
            _pizza = original;
        }

		public override string GetName() {
			return "Mexican";
		}


		public override string GetDescription()
        {
            return base.GetDescription() + ", spicy";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;

        }


    }

}
