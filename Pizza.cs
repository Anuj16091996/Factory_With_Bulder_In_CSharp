using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
   public class Pizza
    {
        public string dough { get; set; }

        public string sauce { get; set; }

        public string topping { get; set; }

        public void ToDisplay()
        {
            Console.WriteLine(" Dough is {0} Sauce is {1} , Topping is {1}", this.dough, this.sauce, this.topping);
        }
    }
}
