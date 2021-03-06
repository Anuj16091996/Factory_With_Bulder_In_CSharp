using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class VeggyDealer : AbstractFactory
    {
        public override Pizza CreatePizza()
        {
            PizzaBuilder VeggyPizza = new VeggyPizzaBuilder();
            PizzaWaitress waitress = new PizzaWaitress(VeggyPizza);
            waitress.ConstructPizza();

            return waitress.GetPizza();
        }

        public override Sandwhich CreateSandwhich(string type)
        {
            if (type == "Veggy")
            {

                SandwhichBuilder veggysadwhich = new VeggySandWhichBuilder();
                SandWhichWaitress waitress = new SandWhichWaitress(veggysadwhich);

                waitress.ConStructSandWhich();

                return waitress.GetSandwhich();
            }
            else
            {
                SandwhichBuilder healthysandwhich = new HealthSandwhichBuilder();
                SandWhichWaitress waitress = new SandWhichWaitress(healthysandwhich);

                waitress.ConStructSandWhich();

                return waitress.GetSandwhich();
            }



        }
    }
}
