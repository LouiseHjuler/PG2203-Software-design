using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_topping
{

    class Ham : ToppingDecorator
    {

        private readonly Pizza _pizza;


        public Ham(Pizza original) : base(original)
        {
            _pizza = original;
        }

        public override string GetName() {
            return "Capricossa";
        }


        public override string GetDescription()
        {
            return base.GetDescription() + ", hammers";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 20;

        }


    }

}
