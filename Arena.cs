using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    class Arena : Business
    {
        FightModule fm = new FightModule();

        public Arena()
        {
            Name = "Арена";
        }

        public void GoToArena()
        {
            Console.Clear();
            Console.WriteLine($"Вы заходите на арену \n Вы можете: \n [1] - Поучавствовать в боях\n [2] - Уйти \n Ваше здоровье: {MainCharacter.HP}");
            string choice;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Введите цифру:");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        done = true;
                        fm.DoBattle();
                        Console.Clear();
                        break;
                    case "2":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
