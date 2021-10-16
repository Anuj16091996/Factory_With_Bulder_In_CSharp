using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class MeatDealer : AbstractFactory
    {
        public override Pizza CreatePizza()
        {
            PizzaBuilder MeatPizza = new MeatPizzaBuilder();
            PizzaWaitress waitress = new PizzaWaitress(MeatPizza);
            waitress.ConstructPizza();

            return waitress.GetPizza();
        }

        public override Sandwhich CreateSandwhich(string type)
        {
            SandwhichBuilder MeatSandwhich = new MeatSandwhichBuilder();
            SandWhichWaitress waitress = new SandWhichWaitress(MeatSandwhich);

            waitress.ConStructSandWhich();

            return waitress.GetSandwhich();
        }
    }
}
