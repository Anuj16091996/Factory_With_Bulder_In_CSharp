using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
   public interface PizzaBuilder
    {
         void BuildDough();

        void BuildSauce();

        void BuildTopping();

        void Price();

        Pizza GetPizza();
        
            

    }
}
