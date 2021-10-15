using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{ 
    class Program
    {
        static void Main(string[] args)
        {

            AbstractFactory factory = AbstractFactory.GetFactory(Client.Hawain);
            Sandwhich sandwhich = factory.CreateSandwhich();
            sandwhich.ToDisplay();

        }
    }
}
