using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class HawainSandWhichBuilder : SandwhichBuilder
    {
        private Sandwhich sandwhich;

        public HawainSandWhichBuilder() 
        {
            this.sandwhich = new Sandwhich();
        }
        public void BuildBread()
        {
            this.sandwhich.Bread = "Itailian Bread";
        }

        public void BuildSalade()
        {
            this.sandwhich.salade = "Pineapple And Chichken";
        }

        public void BuildTopping()
        {
            this.sandwhich.topping = "Cheese And More Chesse with hawain touch";
        }

        public Sandwhich GetSandwhich()
        {
            return this.sandwhich;
        }
    }
}
