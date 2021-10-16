using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class VeggySandWhichBuilder : SandwhichBuilder
    {
        Sandwhich sandwhich;

        public VeggySandWhichBuilder()
        {
            this.sandwhich = new Sandwhich();
        }
        public void BuildBread()
        {
            sandwhich.Bread = "American Breads";
        }

        public void BuildSalade()
        {
            sandwhich.salade = "Olives And Green Lectuse";
        }

        public void BuildTopping()
        {
            sandwhich.topping = "Cheese and Noodles";
        }

        public Sandwhich GetSandwhich()
        {
            return this.sandwhich;
        }

        public void Price()
        {
            sandwhich.price = 23.98;
        }
    }
}
