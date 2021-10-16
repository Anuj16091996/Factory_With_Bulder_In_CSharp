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

        private static MeatDealer meatDealer = new MeatDealer();
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

                case Client.Meat:
                    factory = meatDealer;
                    break;
            }

            return factory;
        }

        public abstract Pizza CreatePizza();

        public abstract Sandwhich CreateSandwhich(string type);
    }
}
