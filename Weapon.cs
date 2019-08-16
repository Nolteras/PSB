using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Weapon
    {
        public string name;
        public int armorPenetrat;
        public int weaponWeight;
        public int weaponLeght;
        protected int damage;
        public int typeOfWeapon; // 0 - Короткий меч, 1 - Длинный меч


        public Weapon(int _type)
        {
            
            if (_type == 0)
            {
                weaponWeight = 10;
                weaponLeght = 3;
                damage = 20;
                armorPenetrat = 15;
                //getDescr(typeOfWeapon);
            }
            else if (_type == 1)
            {
                weaponWeight = 20;
                weaponLeght = 5;
                damage = 30;
                armorPenetrat = 30;
                //getDescr(typeOfWeapon);
            }
            typeOfWeapon = _type;
          
        }


        //private void getDescr0()
        //{
            //Console.WriteLine("Короткий меч");
            //Console.WriteLine("Урон - {0}", damage);
        //}

        //private void getDescr1()
        //{
            //Console.WriteLine("Длинный меч");
            //Console.WriteLine("Урон - {0}", damage);
        //}
        public void getDescr()
        {
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            if(typeOfWeapon == 0)
            {
                Console.WriteLine("Короткий меч");
                Console.WriteLine("Урон - {0}", damage);
            }
            else
            {
                Console.WriteLine("Длинный меч");
                Console.WriteLine("Урон - {0}", damage);
            }
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");

        }
    }
}
