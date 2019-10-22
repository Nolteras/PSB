using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class FightModule
    {
        private static Random random = new Random();
        private Enemy testEnemy = new Enemy(random.Next(1, 30), random.Next(1, 10));
        int reward;
        public FightModule()
        {

        }
        public void DoBattle()
        {
            bool doneAll = false;
            while (!doneAll)
            {
                if (!(testEnemy.HP <= 0))
                {
                    Console.Clear();
                    Console.WriteLine("Вы видите перед собой врага");
                    Console.WriteLine($"Судя по нему, у него осталось {testEnemy.HP} HP \n \n \n");
                    reward = testEnemy.HP;
                    Console.WriteLine($"У вас {MainCharacter.HP} HP и {MainCharacter.MT} MT");
                    string choice;
                    Console.WriteLine("Вы можете: \n [1] - Атаковать \n [2] - Блокировать");
                    bool done = false;
                    while (!done)
                    {
                        Console.Write("Введите цифру:");
                        choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                done = true;
                                int attack = DoAttack(MainCharacter.strength, MainCharacter.MCWeapon.dam);
                                Console.WriteLine($"Вы атакуете врага на {attack}");
                                testEnemy.HP -= attack;
                                Console.ReadKey();
                                attack = DoAttack(testEnemy.Strength, testEnemy.weapon.dam);
                                Console.WriteLine($"Вас атакуют на {attack}");
                                MainCharacter.HP -= attack;
                                Console.ReadKey();
                                break;
                            case "2":
                                done = true;
                                Console.WriteLine("Вы блокируете, поэтому вы не получили урона");
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Вы победили врага и заработали {reward} монет");
                    MainCharacter.Money += reward;
                    Console.ReadKey();
                    doneAll = true;
                }
            }
        }

        int DoAttack(int str, int wnDmg)
        {
            int dmg = random.Next(str, str + 10) + random.Next(wnDmg - 5, wnDmg + 5);
            return dmg;
        }
    }
}
