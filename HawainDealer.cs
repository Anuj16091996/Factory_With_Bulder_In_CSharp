using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class HawainDealer : AbstractFactory
    {
        public override Pizza CreatePizza()
        {
            PizzaBuilder hawinpizza = new HawainPizzaBuilder();
            PizzaWaitress waitress = new PizzaWaitress(hawinpizza);

            waitress.ConstructPizza();

            return waitress.GetPizza();

        }

        public override Sandwhich CreateSandwhich()
        {
            SandwhichBuilder hawinpizza = new HawainSandWhichBuilder();
            SandWhichWaitress waitress = new SandWhichWaitress(hawinpizza);

            waitress.ConStructSandWhich();

            return waitress.GetSandwhich();
        }
    }
}
