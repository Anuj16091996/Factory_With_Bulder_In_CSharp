using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
   public class SandWhichWaitress
    {
        private SandwhichBuilder sandwhichBuilder;


        public  SandWhichWaitress(SandwhichBuilder sandwhichBuilder)
        {
            this.sandwhichBuilder = sandwhichBuilder;
        }

        public void ConStructSandWhich()
        {
            this.sandwhichBuilder.BuildBread();
            this.sandwhichBuilder.BuildSalade();
            this.sandwhichBuilder.BuildTopping();
            this.sandwhichBuilder.Price();
        }

        public Sandwhich GetSandwhich()
        {
            return this.sandwhichBuilder.GetSandwhich();
        }
    }
}
