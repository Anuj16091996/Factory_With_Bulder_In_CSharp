using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class MeatPizzaBuilder : PizzaBuilder
    {
        private Pizza pizza;

        public MeatPizzaBuilder()
        {
            pizza = new Pizza();
        }
        public void BuildDough()
        {
            pizza.dough = "Pan Thin Crust";
        }

        public void BuildSauce()
        {
            pizza.sauce = "Chicken Sauce";
        }

        public void BuildTopping()
        {
            pizza.topping = "Chicken With Olives";
        }

        public Pizza GetPizza()
        {
            return this.pizza;
        }

        public void Price()
        {
            pizza.price = 34.90;
        }
    }
}
