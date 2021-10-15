using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class HawainPizzaBuilder : PizzaBuilder
    {
        private Pizza pizza;

        public HawainPizzaBuilder()
        {
            this.pizza = new Pizza();
        }
        public void BuildDough()
        {
            pizza.dough = "Thin crust";
        }

        public void BuildSauce()
        {
            pizza.sauce = "Indian Butter";
        }

        public void BuildTopping()
        {
            pizza.topping = "Less Cheese And More Meat";
        }

        public Pizza GetPizza()
        {
            return this.pizza;
        }
    }
}
