using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Human : Enemy // Травмы: 0 - голова, 1 - левая рука, 2 - правая рука, 3 - левая нога, 4 - правая нога.
    {
        Random random = new Random();

        public override void Act()
        {


            //Вывод результата
            string name = "null";
            if (TypeOfEnemy == "Human")
            {
                name = "Человек";
            }
            else if (TypeOfEnemy == "Undead")
            {
                name = "Чумной";
            }
            int result;
            result = random.Next(1, 10);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine(name + " бьет вас на " + result + " ед. урона!");
            MainCharacter.RemoveHP(result);
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.ReadKey();
        }

        public override int GetStat()
        {
            // На данный момент алгоритм действует так: Раса, сила, навык защиты, навык атаки, броня, шляпа, оружие
            // Оружие: 0 - Кулаки, 1 - Короткий меч, 2 - Длинный меч
            // Броня: 0 - отсутствует, 10 - Обычная броня
            // Сила влияет на урон и на то, может ли оружие пробить броню
            // Длина оружия влияет на то, можно ли парировать удар

            if (Special != null)
            {


            }

            switch (TypeOfWeapon)
            {
                case 0:
                    WeaponLengh = 0;
                    BaseDamageWeapon = 5;
                    ArmorPenetr = 0;
                    return 0;
                case 1:
                    WeaponLengh = 3;
                    BaseDamageWeapon = 20;
                    ArmorPenetr = 15;
                    return 1;
                case 2:
                    WeaponLengh = 5;
                    BaseDamageWeapon = 40;
                    ArmorPenetr = 17;
                    return 2;
            }

            if (Strength < 10 && Strength > 5)
            {
                if (TypeOfWeapon == 0)
                {
                    return Strength;
                }

                if (TypeOfWeapon == 2 || TypeOfWeapon == 1)
                {
                    BaseDamageWeapon = BaseDamageWeapon - 5;
                    ArmorPenetr = ArmorPenetr - 3;
                    return Strength;
                }

            }

            if (ArmorInt > 8 && ArmorInt < 13)
            {
                Armor = "Обычная одежда";
            }

            if (HatId != 0)
            {

            }
            else
            {
                Hat = "Ничего";
            }


            return this.GetStat();
        }

    }
}
