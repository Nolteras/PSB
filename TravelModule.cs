using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    class TravelModule
    {
        Random rnd = new Random();

        public VillageDef TravelTo()
        {
            VillageDef vil = new VillageDef(rnd.Next(1, 500), rnd.Next(11, 344), rnd.Next(0,3));
            return vil;
        }
    }
}
