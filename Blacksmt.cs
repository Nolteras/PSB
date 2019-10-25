using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Blacksmt : Business
    {
        public Blacksmt(int popul, int prosp)
        {
            Pop = popul;
            Pros = prosp;
            Name = "Кузня";
        }

        //кузница для покупки оружий

        public void GoToBlacksmt()
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine(new string('#', 80));
                Console.WriteLine("Вы захождите в К У У У З Н Ю.");
                switch (Pros) //проверка на богатство кузни
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
                Console.WriteLine("1 - Показать список оружия.");
                Console.WriteLine("2 - Уйти");
                string choice;
                Console.Write("Введите цифру: "); //нужно провести общую оптимизацию с букв на цифры
                choice = Console.ReadLine();
                bool done2 = false;
                while (!done2)
                {
                    switch (choice)
                    {
                        case "1":
                            BlacksmtListWeapons();
                            done2 = true;
                            break;
                        case "2":
                            done = true;
                            done2 = true; 
                            break;
                        default:
                            Console.Write("Давай по новой, Миша, все хуйня: ");
                            choice = Console.ReadLine();
                            break;
                    }
                }
            }
            
        }


        void BlacksmtListWeapons()
        {
            Console.Clear();
            List<Weapon> weapons = new List<Weapon>(); //инициализация списка оружий для продажи
            if (weapons.Count < 10) //TODO проверить значимость этого блока
            {
                for (int i = 0; i < 10; i++)
                {
                    weapons.Add(new Weapon("Weapon", random.Next(1, 5)));
                }
            }
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("Вы заходите в кузницу");
            Console.WriteLine("У кузнеца есть:");
            Console.WriteLine();
            foreach (Weapon weap in weapons) //выводим список оружия
            {
                weap.getDescr(); //добавить вывод описания оружия, см класс Weapon
            }
            Console.ReadKey();
        }

    }
}
