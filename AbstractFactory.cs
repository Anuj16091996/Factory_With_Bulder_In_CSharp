using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public abstract class AbstractFactory
    {
        private static VeggyDealer veggyDealer = new VeggyDealer();

        private static HawainDealer hawainDealer = new HawainDealer();


        public static AbstractFactory GetFactory(Client cl)
        {
            AbstractFactory factory = null;

            switch(cl)
            {
                case Client.Hawain:
                    factory = hawainDealer;
                    break;

                case Client.Veggy:
                    factory = veggyDealer;
                    break;
            }

            return factory;
        }

        public abstract Pizza CreatePizza();

        public abstract Sandwhich CreateSandwhich();
    }
}
