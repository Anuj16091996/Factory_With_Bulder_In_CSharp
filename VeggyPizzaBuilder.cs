using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class VeggyPizzaBuilder : PizzaBuilder
    {
        Pizza Pizza;
        public VeggyPizzaBuilder()
        {
            this.Pizza = new Pizza();
        }

        public void BuildDough()
        {
            Pizza.dough = "Pan Crust";
        }

        public void BuildSauce()
        {
            Pizza.sauce = "Tomato Sauce";
        }

        public void BuildTopping()
        {
            Pizza.topping = "Cheese With Vegetables of Three Kind";
        }

        public Pizza GetPizza()
        {
            return this.Pizza;
        }
    }
}
