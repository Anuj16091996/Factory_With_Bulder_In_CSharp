using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public class Sandwhich
    {
            
        public string Bread { get; set; }

        public string salade { get; set; }

        public string topping { get; set; }

        public double price { get; set; }

        public void ToDisplay()
        {
            Console.WriteLine(" Bread is {0}, Salad is {1} , Topping is {2}," +
                " Price is {3}", this.Bread, this.salade, this.topping, this.price); 
        }


        public override string ToString()
        {
            return string.Format(" Bread is {0}, Salad is {1} , Topping is {2}," +
                " Price is {3}", this.Bread, this.salade, this.topping, this.price);
        }
    }
}
