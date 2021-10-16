using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public interface SandwhichBuilder
    {
        void BuildBread();

        void BuildSalade();

        void BuildTopping();

         void Price();

        Sandwhich GetSandwhich();
    }
}
