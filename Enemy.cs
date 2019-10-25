using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Enemy
    {
        private static Random rnd = new Random();
        //public string TypeOfEnemy { get; set; } //Undead, Human
        //public int AttackSkill { get; set; }   //Навык защиты, 0 - 100
        //public int DefenceSkill { get; set; } //Навык атаки, 0 - 100
        public int Strength { get; set; } //Сила (1-100)
        public Weapon weapon;
        //public string Special { get; set; } //Особенности
        public int HP { get; set; }
        //public string Armor { get; set; } // Тип брони, одетый на тело
        //public int ArmorInt { get; set; } // Очки брони
        //public int HatId { get; set; }  // Шапка
        //public string Hat { get; set; }  // Название шапки
        //public int TypeOfWeapon { get; set; } //Тип оружия, через которое получаем BaseDamage
        //public int BaseDamageWeapon { get; set; }    // Базовый урон оружия
        //public int ArmorPenetr { get; set; }  // Пробитие брони
        //public int WeaponLengh { get; set; } // Длина оружия
        //public bool HasTrauma { get; set; } // Если есть - тру; Если тру - проверяем, что за травма через массив
        //public bool[] Traumas { get; set; } // 0 - левая рука, 1 - правая рука, 2 - левая нога, 3 - правая нога, 4 - голова
        //public string DoNow { get; set; } // def - защищается, par - паррирование, noth - ничего
        public Enemy(int hp, int str)
        {
            HP = hp;
            Strength = str;
            weapon = new Weapon("EnemyTestWeapon", rnd.Next(1, 10));
        }



    }
}
