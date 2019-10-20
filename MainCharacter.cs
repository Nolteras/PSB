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
        static public int MCWeapon;//Название... Я... А черт его знает, что это
        static public int Skills = 1;// 0 - плохо, 1 - нормально
        static public string DoNow;//Что ГГ делаел в предыдущем действии во время боя
        static public int HP = 100;//Здоровье ГГ
        static public int BeliveLev = 0;//Уровень веры ГГ
        static public int damage = 25;//Прямой урон ГГ. По идее, он должен зависеть от оружия

        static List<Weapon> weaponsInv = new List<Weapon>(); //инвентарь

        static public void DoNothingBM()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine("Вы ничего не делаете.");
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.ReadKey();
        }

        static public void AttackChar(this IEnemy enemy)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine("A - Нанести удар");
            if (Skills > 0)
            {
                Console.WriteLine("R - Встать в стойку для ответного удара");
            }
            if (Skills > 1)
            {
                Console.WriteLine("P - Приготовиться паррировать удар");
            }

            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            string choice;
            do
            {
                Console.Write("Введите букаву: "); // постоянное меню
                choice = Console.ReadLine(); // ввод меню
            } while (choice == "A" || choice == "R" || choice == "P");
            switch (choice)
            {
                case "A":
                    DoBattle(enemy);
                    break;
                case "R":
                    break;
                case "P":
                    break;
            }
        }

        static void DoBattle(this IEnemy enemy)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine("Куда нанести удар:");
            Console.WriteLine("[T] - тело");
            if (Skills > 0)
            {
                Console.WriteLine("[A] - ass");
            }
            if (enemy.HasTrauma)
            {
                if (enemy.Traumas[0])
                {
                    Console.WriteLine("[LA] - левая рука(травм)");
                }
                else
                {
                    Console.WriteLine("[LA] - левая рука");
                }
                if (enemy.Traumas[1])
                {
                    Console.WriteLine("[RA] - правая рука(травм)");
                }
                else
                {
                    Console.WriteLine("[RA] - правая рука");
                }
                if (enemy.Traumas[2])
                {
                    Console.WriteLine("[LL] - левая нога(травм)");
                }
                else
                {
                    Console.WriteLine("[LL] - левая нога");
                }
                if (enemy.Traumas[3])
                {
                    Console.WriteLine("[RL] - правая нога(травм)");
                }
                else
                {
                    Console.WriteLine("[RL] - правая нога");
                }
            }
            Console.Write("Введите буквы(Регистр важен): ");
            string choice;
            choice = Console.ReadLine();
            bool done = false;
            while (!done)
            {
                switch (choice)
                {
                    case "T":
                        AttackLimb("Chest");
                        break;
                    case "A":
                        if (Skills > 0)
                        {
                            AttackLimb("ASS");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка");
                            goto default;
                        }
                        break;
                    case "LA":
                        AttackLimb("LeftArm");
                        break;
                    case "RA":
                        AttackLimb("RightArm");
                        break;
                    case "LL":
                        AttackLimb("LeftLeg");
                        break;
                    case "RL":
                        AttackLimb("RightLeg");
                        break;
                    default:
                        choice = Console.ReadLine();
                        break;

                }
            }
            void AttackLimb(string Chast_tela)
            {
                int ParrySuc = 0;
                int ParryDam = 0;
                Random rnd = new Random();
                switch (Chast_tela)
                {
                    case "Chest":
                        if (enemy.DoNow == "par")
                        {
                            int ParryChange = enemy.AttackSkill + enemy.DefenceSkill;
                            ParryChange = 100 - ParryChange;
                            if (ParryChange > 0)
                            {

                                ParrySuc = 2;
                                ParryDam = (enemy.Strength + enemy.ArmorPenetr) - MCArmorBody;
                                if (ParryDam <= 0)
                                {
                                    ParryDam = ParryDam * -1;
                                }
                                break;
                            }
                            if (ParryChange <= 0)
                            {
                                ParryChange = ParryChange * -1;
                            }
                            int ParryChangeRandom = rnd.Next(ParryChange);
                            if (ParryChangeRandom > (ParryChange - enemy.AttackSkill))
                            {
                                ParrySuc = 2;
                                ParryDam = (enemy.Strength + enemy.ArmorPenetr) - MCArmorBody;
                                if (ParryDam <= 0)
                                {
                                    ParryDam = ParryDam * -1;
                                }
                                break;
                            }
                            else
                            {
                                ParrySuc = 1;
                            }
                        }
                        if (enemy.DoNow == "def")
                        {
                            int defResult;
                            int DefChange = enemy.DefenceSkill + enemy.WeaponLengh;
                            if (Skills == 0)
                            {
                                DefChange = DefChange + 5;
                            }
                            if (Skills == 1)
                            {
                                DefChange = DefChange - 10;
                            }

                            if (Fatigue > 50)
                            {
                                DefChange = DefChange + 10;
                            }

                            rnd.Next(DefChange);
                            if (DefChange > (enemy.DefenceSkill + enemy.WeaponLengh))
                            {
                                defResult = 1;
                            }
                            else
                            {
                                defResult = 0;
                            }
                        }

                        if (enemy.DoNow == "noth")
                        {
                            enemy.HP = enemy.HP - damage;
                        }
                        break;
                }


                void Output(int parry, int parryDam, int def)
                {

                }


            }


        }


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
