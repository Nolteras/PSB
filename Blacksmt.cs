using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Blacksmt
    {
        Random random = new Random(0);
        //кузница для покупки оружий

        public void GoToBlacksmt(int blackProsp)
        {
            Console.Clear();
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("Вы захождите в К У У У З Н Ю.");
            switch (blackProsp)
            {
                case 0:
                    Console.WriteLine("Кузня Процветание 0");
                    break;
                case 1:
                    Console.WriteLine("Кузня Процветание 1");
                    break;
                case 2:
                    Console.WriteLine("Кузня Процветание 2");
                    break;
                case 3:
                    Console.WriteLine("Кузня Процветание 3");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine("[L] - Показать список оружия.");
            string choice;
            Console.Write("Введите букву(Регистр важен): ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    if (choice == "L")
                    {
                        goto case "L";
                    }
                    else
                    {
                        goto default;
                    }
                case "L":
                    BlacksmtListWeapons();
                    break;
                default:
                    Console.Write("Давай по новой, Миша, все хуйня: ");
                    choice = Console.ReadLine();
                    goto case "1";
            }
        }


        void BlacksmtListWeapons()
        {
            Console.Clear();
            List<Weapon> weapons = new List<Weapon>(); //инициализация списка оружий для продажи
            if (weapons.Count < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    weapons.Add(new Weapon(random.Next(0, 2)));
                }
            }
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("Вы заходите в кузницу");
            Console.WriteLine("У кузнеца есть:");
            Console.WriteLine("");
            foreach (Weapon weap in weapons)
            {
                int iType = weap.typeOfWeapon;
                weap.getDescr(); //добавить вывод описания оружия, см класс Weapon
            }
            Console.ReadKey();
        }

    }
}
