using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Weight { get; protected set; }
        public int Type { get; protected set; } //0-броня, 1-оружие
        public int Price { get; set; } //цена
    }
}
