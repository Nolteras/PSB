using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public abstract class Weapon
    {
        public string name;
        public int armorPenetrat;
        public int weaponWeight;
        public int weaponLeght;
        protected int damage;
        public int typeOfWeapon; // 0 - Короткий меч, 1 - Длинный меч


        public void GetDescr()
        {
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            if (typeOfWeapon == 0)
            {
                weaponWeight = 10;
                weaponLeght = 3;
                damage = 20;
                armorPenetrat = 15;
                getDescr0();
            }
            else if (typeOfWeapon == 1)
            {
                getDescr1();
            }
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
        }



        private void getDescr0()
        {
            Console.WriteLine("Короткий меч");
            Console.WriteLine("Урон - {0}", damage);
        }

        private void getDescr1()
        {
            Console.WriteLine("Длинный меч");
            Console.WriteLine("Урон - {0}", damage);
        }

    }
}
