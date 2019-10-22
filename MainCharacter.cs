using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public static class MainCharacter //Инвентарь, задания, прочее, связанное с ГГ
    {
        static public int Plot = 0; // "Число сюжета"
        static public string Name; // Имя ГГ
        static public int Money = 100; //Д Е Н Ь Г И
        static public int Fatigue = 0; //усталость
        static public int MT = 100; //Мораль ГГ
        static public int MCArmorHead;//Броня ГГ голова
        static public int MCArmorBody;//Броня ГГ тело
        static public string MCHead;//Название брони ГГ голова
        static public string MCBody;//Название брони ГГ тело
        static public Weapon MCWeapon = new Weapon("UBERSHWARD", 6);//Оружие
        static public int Skills = 1;// 0 - плохо, 1 - нормально
        static public string DoNow;//Что ГГ делаел в предыдущем действии во время боя
        static public int HP = 100;//Здоровье ГГ
        static public int BeliveLev = 0;//Уровень веры ГГ
        static public int strength = 5;//Прямой урон ГГ. По идее, он должен зависеть от оружия

        static List<Item> Inv = new List<Item>(); //инвентарь

       
        static public int AddMoney(int value)
        {
            Money += value;

            return Money;
        }

        static public int RemoveMoney(int value)
        {
            Money -= value;

            if (Money < 0)
            {
                Money = 0;
            }

            return Money;
        }

        static public int RemoveMT(int value)
        {
            MT -= value;

            if (MT < 1)
            {
                GameBase.Death(true);
            }

            return MT;
        }

        static public int RemoveHP(int value)
        {
            HP -= value;

            if (HP < 1)
            {
                GameBase.Death(false);
            }

            return HP;
        }

        static public int AddMT(int value)
        {
            MT += value;

            if (MT > 100)
            {
                MT = 100;
            }

            return MT;
        }

        static public int AddHP(int value)
        {
            HP = value + HP;

            if (HP > 100)
            {
                HP = 100;
            }

            return HP;
        }

    }
}
