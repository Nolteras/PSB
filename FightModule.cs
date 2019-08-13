using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class FightModule
    {
        public IEnemy EnemyF1 { get; set; }
        public void GetEnemy(string typeOfEnemy, int strength, int attackSkill, int defenceSkill, int typeOfArmor, int typeOfHat, int typeofWeapon)
        {
            if (typeOfEnemy == "Human")
            {
                EnemyF1 = new Human
                {
                    Traumas = new bool[4],
                    HP = 100,
                    HasTrauma = false,
                    AttackSkill = attackSkill,
                    DefenceSkill = defenceSkill,
                    Strength = strength,
                    TypeOfWeapon = typeofWeapon,
                    ArmorInt = typeOfArmor,
                    HatId = typeOfHat,
                    TypeOfEnemy = typeOfEnemy
                };
                EnemyF1.GetStat();
                Battle(EnemyF1);
            }
            else if (typeOfEnemy == "Undead")
            {
                EnemyF1 = new Undead
                {
                    HP = 100,
                    HasTrauma = false,
                    TypeOfWeapon = typeofWeapon,
                    ArmorInt = typeOfArmor,
                    TypeOfEnemy = typeOfEnemy
                };
                EnemyF1.GetStat();
                Battle(EnemyF1);
            }

        }


        void Battle(IEnemy EnemyF)
        {
            do
            {

                GetDescr(EnemyF);

            }
            while (EnemyF.HP > 0);
        }

        void GetDescr(IEnemy EnemyF)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine("Перед вами:");
            switch (EnemyF.TypeOfEnemy)
            {
                case "Human":
                    Console.WriteLine("Человек");
                    break;
                case "Undead":
                    Console.WriteLine("Чумной");
                    break;
            }
            Console.WriteLine(" На вид он -");
            if (EnemyF.HP == 100)
            {
                Console.WriteLine("В полном порядке");
            }
            else if (EnemyF.HP < 100 && EnemyF.HP >= 75)
            {
                Console.WriteLine("Немного ранен");
            }
            else if (EnemyF.HP < 75 && EnemyF.HP >= 50)
            {
                Console.WriteLine("Ранен");
            }
            else if (EnemyF.HP < 50 && EnemyF.HP >= 35)
            {
                Console.WriteLine("Сильно ранен");
            }
            else if (EnemyF.HP < 35 && EnemyF.HP > 0)
            {
                Console.WriteLine("При смерти");
            }
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            DoMainChar();
            if (EnemyF.HP > 0)
            {
                EnemyF.Act();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(new string('#', 80));
                Console.WriteLine("");
                Console.WriteLine("Противник побежден!");
                Console.WriteLine("");
                Console.WriteLine(new string('#', 80));
                Console.WriteLine("");

            }
        }

        void DoMainChar()
        {
            int fightModuleDamage = MainCharacter.damage;
            int fightModuleDefenceHead = MainCharacter.MCArmorHead;
            int fightModuleDefenceBody = MainCharacter.MCArmorBody;
            int fightModuleWeapon = MainCharacter.MCWeapon;
            Console.WriteLine("У вас " + MainCharacter.HP + " очков здоровья.");
            if (MainCharacter.MT <= 100 && MainCharacter.MT > 50)
            {
                Console.WriteLine("Ваше МТ в полном порядке."); //Переписать.
            }
            else if (MainCharacter.MT <= 50 && MainCharacter.MT > 20)
            {
                Console.WriteLine("Вы чувствуете помутнение разума.");
            }
            else if (MainCharacter.MT <= 20 && MainCharacter.MT > 0)
            {
                Console.WriteLine("Вы вот-вот сойдете с ума.");
            }

            int choice;

            Console.WriteLine("Действия:");
            Console.WriteLine("1 - Атака.");
            Console.WriteLine("2 - Пропуск хода.");
            Console.Write("Выбор:");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    if (choice == 1)
                    {
                        goto case 1;
                    }
                    if (choice == 2)
                    {
                        goto case 2;
                    }
                    else
                    {
                        Console.Write("Давай по новой, Миша, все хуйня: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        goto case 0;
                    }

                case 1:
                    MainCharacter.AttackChar(EnemyF1);
                    return;
                case 2:
                    MainCharacter.DoNothingBM();
                    return;
                default:
                    goto case 0;
            }


        }




    }

}
