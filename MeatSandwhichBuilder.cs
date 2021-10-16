using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
   public class MeatSandwhichBuilder:SandwhichBuilder
    {
        private Sandwhich sandwhich;

        public MeatSandwhichBuilder()
        {
            this.sandwhich = new Sandwhich();
        }

        public void BuildBread()
        {
            sandwhich.Bread = "Chicken Italian Bread ";
        }

        public void BuildSalade()
        {
            sandwhich.salade = "Chciken With Sprouts";
        }

        public void BuildTopping()
        {
            sandwhich.topping = "Chicken Peices";
        }

        public Sandwhich GetSandwhich()
        {
            return sandwhich;
        }

        public void Price()
        {
            sandwhich.price = 12.90;
        }
    }
}
