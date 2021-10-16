using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class HealthSandwhichBuilder : SandwhichBuilder
    {
        private Sandwhich sandwhich;

        public HealthSandwhichBuilder()
        {
            sandwhich = new Sandwhich();
        }
        public void BuildBread()
        {
            sandwhich.Bread = "Protein Bread";
        }

        public void BuildSalade()
        {
            sandwhich.salade = "Healthy Salad With Brocolli";
        }

        public void BuildTopping()
        {
            sandwhich.topping = "Olives and bracolio";
        }

        public Sandwhich GetSandwhich()
        {
            return this.sandwhich;
        }

        public void Price()
        {
            sandwhich.price = 32.90;
        }
    }
}
