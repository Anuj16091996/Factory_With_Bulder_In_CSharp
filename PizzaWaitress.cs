using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class PizzaWaitress
    {
        private PizzaBuilder pizzaBuilder;
        public PizzaWaitress(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }

        public void ConstructPizza()
        {
            this.pizzaBuilder.BuildDough();
            this.pizzaBuilder.BuildSauce();
            this.pizzaBuilder.BuildTopping();
        }

        public Pizza GetPizza()
        {
           return this.pizzaBuilder.GetPizza();
        }

    }


}
