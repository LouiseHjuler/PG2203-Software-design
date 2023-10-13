using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_topping
{

    class Extracheese : ToppingDecorator
    {

        private readonly Pizza _pizza;


        public Extracheese(Pizza original) : base(original)
        {  //base er super i java
            _pizza = original;
        }
		public override string GetName() {
			return "Cheesy";
		}


		//public Extracheese(Pizza.Extracheese) {}
		public override string GetDescription()
        {
            return base.GetDescription() + ", extra cheese";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;

        }


    }

}
