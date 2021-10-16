using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
   public class Pizza:Object
    {
        public string dough { get; set; }

        public string sauce { get; set; }

        public string topping { get; set; }

        public Double price { get; set; }

        public void ToDisplay()
        {
            Console.WriteLine("Bread is {0}, Sauce is {1} , Topping is {2}" +
                " ,Price is {3}" , this.dough, this.sauce, this.topping,this.price);
        }

        public override string  ToString()
        {
            return string.Format("Bread is {0}, Sauce is {1} , Topping is {2}" +
                " ,Price is {3}", this.dough, this.sauce, this.topping,Convert.ToString(this.price));
        }

       
    }
}
