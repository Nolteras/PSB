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
        public int weaponLength;
        protected int damage;
        public int typeOfWeapon; // 0 - Короткий меч, 1 - Длинный меч


        public Weapon(int _type)
        {
            
            if (_type == 0)
            {
                weaponWeight = 10;
                weaponLength = 3;
                damage = 20;
                armorPenetrat = 15;
                typeOfWeapon = 0;
            }
            else if (_type == 1)
            {
                weaponWeight = 20;
                weaponLength = 5;
                damage = 30;
                armorPenetrat = 30;
                typeOfWeapon = 1;
            }
          
        }


        public void getDescr()
        {
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            if(typeOfWeapon == 0)
            {
                Console.WriteLine("Короткий меч");
                Console.WriteLine("Урон - {0}", damage);
                Console.WriteLine("Тяжесть - {0}", weaponWeight);
                Console.WriteLine("Длина - {0}", weaponLength);
                Console.WriteLine("Пробитие брони - {0}", armorPenetrat);
            }
            if (typeOfWeapon == 1) //Тестовый 
            {
                Console.WriteLine("Длинный меч");
                Console.WriteLine("Урон - {0}", damage);
                Console.WriteLine("Тяжесть - {0}", weaponWeight);
                Console.WriteLine("Длина - {0}", weaponLength);
                Console.WriteLine("Пробитие брони - {0}", armorPenetrat);
            }
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");

        }
    }
}
