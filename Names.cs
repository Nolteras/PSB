using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    abstract class Names
    {

        static string[] names = new string[]
        {
            "Dragenhof",
            "Folkstown",
            "Radovantown",
            "John",
            "Morioh",
        };

        static Random rnd = new Random();

        public static string GetName()
        {
            string result = names[rnd.Next(0, names.Length - 1)];
            return result;
        }

    }
}
