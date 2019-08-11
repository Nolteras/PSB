using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public interface IEnemy
    {
        string TypeOfEnemy { get; set; } //Undead, Human
        int AttackSkill { get; set; }   //Навык защиты, 0 - 100
        int DefenceSkill { get; set; } //Навык атаки, 0 - 100
        int Strength { get; set; } //Сила
        int HP { get; set; }
        string Special { get; set; } //Особенности
        string Armor { get; set; } // Тип брони, одетый на тело
        int ArmorInt { get; set; } // Очки брони
        int HatId { get; set; }  // Шапка
        string Hat { get; set; }  // Название шапки
        int TypeOfWeapon { get; set; } //Тип оружия, через которое получаем BaseDamage
        int BaseDamageWeapon { get; set; }    // Базовый урон оружия
        int ArmorPenetr { get; set; }  // Пробитие брони
        int WeaponLengh { get; set; } // Длина оружия
        bool HasTrauma { get; set; } // Если есть - тру; Если тру - проверяем, что за травма через массив
        bool[] Traumas { get; set; } // 0 - левая рука, 1 - правая рука, 2 - левая нога, 3 - правая нога, 4 - голова
        string DoNow { get; set; }
        int GetStat();
        void Act();
    }
}
