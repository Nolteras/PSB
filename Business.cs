using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Business
    {
        public int Pros { get; set; }//богатство данного заведения
        public int Pop { get; set; }//популярность/заполненность бизнеса
        public string Name { get; set; }

        public virtual void GoTo()
        {
            Console.WriteLine("Error");
        }

    }
}
