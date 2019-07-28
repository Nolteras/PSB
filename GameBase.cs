using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public abstract class Enemy : IEnemy
    {
        public string TypeOfEnemy { get; set; } //Undead, Human
        public int AttackSkill { get; set; }   //Навык защиты
        public int DefenceSkill { get; set; } //Навык атаки
        public int Strength { get; set; } //Сила
        public string Special { get; set; } //Особенности
        public int HP { get; set; }
        public string Armor { get; set; } // Тип брони, одетый на тело
        public int ArmorInt { get; set; } // Очки брони
        public int HatId { get; set; }  // Шапка
        public string Hat { get; set; }  // Название шапки
        public int TypeOfWeapon { get; set; } //Тип оружия, через которое получаем BaseDamage
        public int BaseDamageWeapon { get; set; }    // Базовый урон оружия
        public int ArmorPenetr { get; set; }  // Пробитие брони
        public int WeaponLengh { get; set; } // Длина оружия
        public bool HasTrauma { get; set; } // Если есть - тру; Если тру - проверяем, что за травма через массив
        public int[] Traumas { get; set; } // Список травм для каждого типа противника уникален, инициализировать в конструкторе
        public virtual int GetStat()
        {
            return 0;
        }
        public virtual void Act()
        {

        }
    }


    public class Undead : Enemy
    {
        Random random = new Random();


        public override void Act()
        {
            int result;
            result = random.Next(1, 10);
        }

        public override int GetStat() // На данный момент алгоритм действует так: Раса, навык защиты, навык атаки, броня, шляпа, оружие
        {
            switch (TypeOfWeapon) // 0 - Кулаки, 1 - Короткий меч, 2 - Длинный меч
            {
                case 0:
                    return BaseDamageWeapon = 5;
                case 1:
                    return BaseDamageWeapon = 15;
                case 2:
                    return BaseDamageWeapon = 40;
            }
            return this.GetStat();
        }

    }


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

    public interface IEnemy
    {
        string TypeOfEnemy { get; set; } //Undead, Human
        int AttackSkill { get; set; }   //Навык защиты
        int DefenceSkill { get; set; } //Навык атаки
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
        int[] Traumas { get; set; }
        int GetStat();
        void Act();
    }



    public class FightModule
    {
        public IEnemy EnemyF1 { get; set; }
        public void GetEnemy(string typeOfEnemy, int strength, int attackSkill, int defenceSkill, int typeOfArmor, int typeOfHat, int typeofWeapon)
        {
            if (typeOfEnemy == "Human")
            {
                EnemyF1 = new Human
                {
                    Traumas = new int[5],
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






    public abstract class Weapon
    {
        public string name;
        public int armorPenetrat;
        public int weaponWeight;
        public int weaponLeght;
        protected int damage;
        public int typeOfWeapon; // 0 - Короткий меч, 1 - Длинный меч


        public void GetDescr()
        {
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            if (typeOfWeapon == 0)
            {
                weaponWeight = 10;
                weaponLeght = 3;
                damage = 20;
                armorPenetrat = 15;
                getDescr0();
            }
            else if (typeOfWeapon == 1)
            {
                getDescr1();
            }
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
        }



        private void getDescr0()
        {
            Console.WriteLine("Короткий меч");
            Console.WriteLine("Урон - {0}", damage);
        }

        private void getDescr1()
        {
            Console.WriteLine("Длинный меч");
            Console.WriteLine("Урон - {0}", damage);
        }

    }


    public class SmallSword : Weapon
    {
        //Не может отрубать конечности

        public SmallSword()
        {
            damage = 15;
            typeOfWeapon = 0;
        }
    }


    public class BigSword : Weapon
    {

        //Может отрубить голову

        public BigSword()
        {
            damage = 40;
            typeOfWeapon = 1;
        }
    }





    public static class MainCharacter //Инвентарь, задания, прочее, связанное с ГГ
    {
        static public int Plot = 0; // "Число сюжета"
        static public string Name; // Имя ГГ
        static public int Money = 100;
        static public int MT = 100;
        static public int MCArmorHead;
        static public int MCArmorBody;
        static public string MCHead;
        static public string MCBody;
        static public int MCWeapon;
        static public int Skills = 1;// 0 - плохо, 1 - нормально
        static public string DoNow;
        static public int HP = 100;
        static public int BeliveLev = 0;
        static public int damage = 25;

        static List<Weapon> weaponsInv = new List<Weapon>();

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
                DoBattle();
                break;
            case "R":
                break;
            case "P":
                break;
        }
    }

     static void DoBattle()
     {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine(new string('#', 80));
        Console.WriteLine("");
        Console.WriteLine("Куда нанести удар:");

    }


        static public int AddMoney(int value)
        {
            Money = value + Money;

            return Money;
        }

        static public int RemoveMoney(int value)
        {
            Money = Money - value;

            if (Money < 0)
            {
                Money = 0;
            }

            return Money;
        }

        static public int RemoveMT(int value)
        {
            MT = MT - value;

            if (MT < 1)
            {
                GameAct.DeadByMind();
            }

            return MT;
        }

        static public int RemoveHP(int value)
        {
            HP = HP - value;

            if (HP < 1)
            {
                GameAct.DeadByPhysic();
            }

            return HP;
        }

        static public int AddMT(int value)
        {
            MT = value + MT;

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

    public static class GameBase
    {
        static public void StartThisShit()
        {

            string NameGG;

            Console.Clear();
            Console.WriteLine("Крац снова требует жертв, третий раз за этот месяц...");
            Console.WriteLine("Группа Портанийских наемников была отправлена на восток.");
            Console.WriteLine("Они точно не знали задачу их похода, но никто не сомневался,");
            Console.WriteLine("что после этих событий их жизни изменятся...");
            Console.WriteLine("...В худшую или лучшую сторону.");
            Console.Write("Молодой оруженосец по имени ");
            NameGG = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Молодой оруженосец по имени " + NameGG + " только-только выпустился из оружейной академии Барона Керонча."); //Все это к херам переделать
            MainCharacter.Name = NameGG;
            Console.ReadKey();
        }

        public static void AboutWorld()
        {
            Console.Clear();
            Console.WriteLine("Лор");
            Console.WriteLine("Лор");
            Console.WriteLine("Лор");
            Console.ReadKey();
            DisplayMenu();
        }

        public static void AboutUs()
        {
            Console.Clear();
            Console.WriteLine("Сценарист - ???(Ушел в порно-индустрию)");
            Console.WriteLine("Автор мира - Markela");
            Console.WriteLine("Глав. Гад - Нолтерасс А.К.А Нолт А.К.А Террррррновое Вино А.К.А Noltras");
            Console.ReadKey();
            DisplayMenu();

        }

        public static void TestStuff()
        {
            Console.Clear();
            SmallSword sword = new SmallSword();
            Dragenhof dragenhof = new Dragenhof();
            dragenhof.DefVillAct();
            FightModule fight = new FightModule();
            fight.GetEnemy("Human", 8, 5, 5, 10, 0, 0);
            Console.ReadKey();
            DisplayMenu();


        }

        public static void CloseAllThisShit()
        {

        }


        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("       Portania Strikes Back    ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("            ");
            }
            Console.WriteLine("1. Начать");
            Console.WriteLine("2. О Мире");
            Console.WriteLine("3. Разработчики");
            Console.WriteLine("4. Тест всякой шняги");
            Console.WriteLine("5. Выход");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("            ");
            }
            int choice;
            do
            {
                Console.Write("Введите число [1-5]: "); // постоянное меню
                choice = Convert.ToInt32(Console.ReadLine()); // ввод меню
            } while (choice < 1 || choice > 5);
            switch (choice)
            {
                case 1:
                    StartThisShit();
                    break;
                case 2:
                    AboutWorld();
                    break;
                case 3:
                    AboutUs();
                    break;
                case 4:
                    TestStuff();
                    break;
                case 5:
                    CloseAllThisShit();
                    break;
            }
        }



    }

    //Постройки и их функции

    class Churh
    {
        Random rnd = new Random();
        public int PopChurch;
        int darkKrac;
        int noDarkKrac;
        public int ProsChurch;
        int religiousZeal;
        bool canGetBless = true;
        // Описание и возможности

        public int GetReligiousZeal(int pros)
        {
            switch (pros)
            {
                case 0:
                    return religiousZeal = 30;
                case 1:
                    return religiousZeal = 20;
                case 2:
                    return religiousZeal = 10;
                case 3:
                    return religiousZeal = 0;
            }

            return religiousZeal;
        }


        public void GoToChurch(int popchurh, int proschurh)
        {
            PopChurch = popchurh;
            ProsChurch = proschurh;
            Console.Clear();
            GetReligiousZeal(proschurh);
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("Вы захождите в церковь.");
            switch (proschurh)
            {
                case 0:
                    Console.WriteLine("Хотя населенный пункт является очень бедным, церковь выглядит неплохо.");
                    break;
                case 1:
                    Console.WriteLine("Церковь хорошо выглядит. Видно, бедность не так сильно затронула это место."); // Переделать
                    break;
                case 2:
                    Console.WriteLine("Церковь выглядит отлично. Похоже, это одно из самых богатых построек в городе.");
                    break;
                case 3:
                    Console.WriteLine("Церковь выглядит роскошно и богато. Похоже, это одно из самых богатых построек в городе.");
                    break;
            }
            Console.WriteLine("Подойдя к алтарю пожертвований, вы видите, что:");
            Console.WriteLine("");
            getDarkKrac(PopChurch);
            Console.WriteLine("Последователей  'Темного Краца' - " + darkKrac + "");
            getNoDarkKrac(PopChurch);
            Console.WriteLine("Последователей  'Не Темного Краца' - " + noDarkKrac + "");
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine("Вы можете:");
            Console.WriteLine("[1] - Попросить благословение.");
            Console.WriteLine("[2] - Покинуть церковь.");

            string choice;
            Console.Write("Введите букву(Регистр важен): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "check":
                    if (choice == "1")
                    {
                        goto case "1";
                    }
                    if (choice == "2")
                    {
                        goto case "2";
                    }
                    else
                    {
                        goto default;
                    }
                case "1":
                    if (canGetBless)
                    {
                        getBless();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine(new string('#', 80));
                        Console.WriteLine("");
                        Console.WriteLine("В этом месте вы уже обращались к Крацу.");
                        Console.WriteLine("");
                        Console.WriteLine(new string('#', 80));
                        Console.WriteLine("");
                        Console.ReadKey();
                        GoToChurch(PopChurch, ProsChurch);
                    }
                    break;
                case "2":
                    break;
                default:
                    Console.Write("Давай по новой, Миша, все хуйня: ");
                    choice = Console.ReadLine();
                    goto case "check";
            }
        }



        int getDarkKrac(int alldudes)
        {
            darkKrac = (alldudes / 4) + religiousZeal + 15;
            return darkKrac;
        }

        int getNoDarkKrac(int alldudes)
        {
            noDarkKrac = alldudes - darkKrac;
            return noDarkKrac;
        }

        void getBless()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine("Вы усердно молитесь...");
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            canGetBless = false;
            int iGotBless = rnd.Next(0, 3);
            Console.ReadKey();
            switch (iGotBless)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.WriteLine("Вам кажется, что ничего не поменялось.");
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.ReadKey();
                    GoToChurch(PopChurch, ProsChurch);
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.WriteLine("Вы чувствуете, как энергия проходит сквозь вас.");
                    MainCharacter.BeliveLev = MainCharacter.BeliveLev + 1;
                    MainCharacter.AddHP(5);
                    MainCharacter.AddMT(5);
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.ReadKey();
                    GoToChurch(PopChurch, ProsChurch);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.WriteLine("Вы чувствуете, как у вас начинают трястись руки.");
                    MainCharacter.BeliveLev = MainCharacter.BeliveLev + 3;
                    MainCharacter.RemoveMT(10);
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.ReadKey();
                    GoToChurch(PopChurch, ProsChurch);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.WriteLine("Вы чувствуете, как у вас начинает болеть голова.");
                    MainCharacter.BeliveLev = MainCharacter.BeliveLev + 3;
                    MainCharacter.RemoveHP(10);
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.ReadKey();
                    GoToChurch(PopChurch, ProsChurch);
                    break;
            }
        }

    }


    public class Markt
    {
        int popMarket;
        int prosMarket;
        // Описание и возможности
        public void GoToMarket(int popmarket, int prosmarket)
        {
            popMarket = popmarket;
            prosMarket = prosmarket;
            Console.Clear();
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("Вы приходите на рынок.");
            if (popmarket > 10 && popmarket < 35)
            {
                Console.WriteLine("Рынок выглядит пустым.");
            }
            else if (popmarket > 35 && popmarket < 75)
            {
                Console.WriteLine("Рынок, не смотря на маленькое население, живет своей жизнью.");
            }
            else if (popmarket > 75 && popmarket < 345)
            {
                Console.WriteLine("Рынок выглядит оживленно.");
            }

            switch (prosmarket)
            {
                case 0:
                    Console.WriteLine("Но не смотря на это, торговцев почти нет, а те, кто есть, завышают цены до небес.");
                    break;
                case 1:
                    Console.WriteLine("Но не смотря на это, торговля в этом поселении умирает от высоких цен и сравнительно небольшого кол-ва товаров.");
                    break;
                case 2:
                    Console.WriteLine("Но не смотря на это, рынок не выглядит бедным; То тут, то там видны разные торговцы, а их товары имеют приемлемую цену.");
                    break;
                case 3:
                    Console.WriteLine("Но не смотря на это, рынок полон торговцами и разными товарами; Торговля процветает и такое положение дел положительно влияет на местные цены.");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
        }
    }

        class Blacksmt
        {

        }
    


        public class Tavrn
        {
            Random rnd = new Random();
            public int PopTavrn;
            public int ProsTavrn;
            // Описание и возможности
            public void GoToTavern(int poptavrn, int prosptavrn)
            {
                PopTavrn = poptavrn;
                ProsTavrn = prosptavrn;
                Console.Clear();
                Console.WriteLine(new string('#', 80));
                Console.WriteLine("Вы захождите в таверну.");
                if (poptavrn > 10 && poptavrn < 35)
                {
                    Console.WriteLine("Таверна выглядит очень пустой.");
                }
                else if (poptavrn > 35 && poptavrn < 75)
                {
                    Console.WriteLine("Таверна выглядит запустелой.");
                }
                else if (poptavrn > 75 && poptavrn < 345)
                {
                    Console.WriteLine("Таверна выглядит НЕ запустелой.");
                }

                switch (prosptavrn)
                {
                    case 0:
                        Console.WriteLine("Состояние ужасное.");
                        break;
                    case 1:
                        Console.WriteLine("Состояние терпимое.");
                        break;
                    case 2:
                        Console.WriteLine("Состояние хорошее.");
                        break;
                    case 3:
                        Console.WriteLine("Состояние отличное.");
                        break;
                }
                //Конец описания
                Console.WriteLine("");
                Console.WriteLine(new string('#', 80));
                Console.WriteLine("");
                Console.WriteLine("Вы можете:");
                Console.WriteLine("[1] - Подойти к барной стойке.");
                Console.WriteLine("[2] - Сесть за стол и перекусить.");
                Console.WriteLine("[3] - Покинуть таверну.");

                string choice;
                Console.Write("Введите букву(Регистр важен): ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "dew":
                        if (choice == "1")
                        {
                            goto case "1";
                        }
                        else if (choice == "2")
                        {
                            goto case "2";
                        }
                        else if (choice == "3")
                        {
                            goto case "3";
                        }
                        else
                        {
                            goto default;
                        }
                    case "1":
                        GoToBar();
                        break;
                    case "2":
                        EatMeal(MainCharacter.HP, MainCharacter.MT, MainCharacter.Money);
                        break;
                    case "3":
                        break;
                    default:
                        Console.Write("Давай по новой, Миша, все хуйня: ");
                        choice = Console.ReadLine();
                        goto case "dew";

                }

                void EatMeal(int gghp, int ggmp, int moneys)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.WriteLine("Вы садитесь за свободный стол.");
                    Console.WriteLine("Спустя какое-то время к вам подходит официантка(???)."); // Официантки вообще были тогда?
                    if (moneys >= 15)
                    {
                        Console.WriteLine("Вы можете заказать:");
                        Console.WriteLine("[1] - Запеченные овощи(15)"); // Нет
                        if (moneys >= 50)
                        {
                            Console.WriteLine("[2] - Суп(50)"); // Нет, пожалуйста
                            if (moneys >= 100)
                            {
                                Console.WriteLine("[3] - Свиной окорок(100)"); // Черт
                            }
                        }

                        Console.WriteLine("");
                        Console.WriteLine(new string('#', 80));
                        Console.WriteLine("");

                        string choiceEat;
                        Console.Write("Введите букву(Регистр важен): ");
                        choiceEat = Console.ReadLine();
                        switch (choiceEat)
                        {
                            case "check":
                                if (choiceEat == "1")
                                {
                                    goto case "1";
                                }
                                else if (choiceEat == "2")
                                {
                                    goto case "2";
                                }
                                else if (choiceEat == "3")
                                {
                                    goto case "3";
                                }
                                else
                                {
                                    goto default;
                                }
                            case "1":
                                Console.Clear();
                                if (moneys >= 15)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(new string('#', 80));
                                    Console.WriteLine("");
                                    Console.WriteLine("Вы заказываете самое дешевое блюдо.");
                                    MainCharacter.RemoveMoney(15);
                                    Console.WriteLine("После того, как вы поели, вам стало чуть-чуть лучше.");
                                    MainCharacter.AddHP(10);
                                    MainCharacter.AddMT(5);
                                    Console.WriteLine("");
                                    Console.WriteLine(new string('#', 80));
                                    Console.WriteLine("");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("У вас нет денег на это.");
                                }

                                break;
                            case "2":
                                Console.Clear();
                                if (moneys >= 50)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(new string('#', 80));
                                    Console.WriteLine("");
                                    Console.WriteLine("Вы заказываете овощи.");
                                    MainCharacter.RemoveMoney(50);
                                    Console.WriteLine("После того, как вы поели, вам стало лучше.");
                                    MainCharacter.AddHP(20);
                                    MainCharacter.AddMT(10);
                                    Console.WriteLine("");
                                    Console.WriteLine(new string('#', 80));
                                    Console.WriteLine("");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("У вас нет денег на это.");
                                }
                                break;
                            case "3":
                                Console.Clear();
                                if (moneys >= 100)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(new string('#', 80));
                                    Console.WriteLine("");
                                    Console.WriteLine("Вы заказываете большой сытный окорок.");
                                    MainCharacter.RemoveMoney(100);
                                    Console.WriteLine("После того, как вы его съели, вам стало очень хорошо.");//Править меню
                                    MainCharacter.AddHP(25);
                                    MainCharacter.AddMT(15);
                                    Console.WriteLine("");
                                    Console.WriteLine(new string('#', 80));
                                    Console.WriteLine("");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("У вас нет денег на это.");
                                    Console.WriteLine("");
                                    Console.WriteLine(new string('#', 80));
                                    Console.WriteLine("");
                                    Console.ReadKey();
                                }
                                break;
                            default:
                                Console.Write("Давай по новой, Миша, все хуйня: ");
                                choiceEat = Console.ReadLine();
                                goto case "check";

                        }
                    }

                    else
                    {
                        Console.WriteLine("У вас нет денег, чтобы что-нибудь заказать.");
                        Console.WriteLine("");
                        Console.WriteLine(new string('#', 80));
                        Console.WriteLine("");
                        Console.ReadKey();
                    }

                    GoToTavern(PopTavrn, ProsTavrn);
                }

                void GoToBar()
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.WriteLine("Вы подходите к барной стойке");
                    Console.WriteLine("Нужно что-нибудь еще написать...");
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.WriteLine("Вы можете:");
                    Console.WriteLine("[1] - Спросить о слухах.");
                    Console.WriteLine("[2] - Выпить.");
                    Console.WriteLine("[3] - Отойти.");

                    string choice2;
                    Console.Write("Введите букву(Регистр важен): ");
                    choice2 = Console.ReadLine();
                    switch (choice2)
                    {
                        case "dew":
                            if (choice2 == "1")
                            {
                                goto case "1";
                            }
                            else if (choice2 == "2")
                            {
                                goto case "2";
                            }
                            else if (choice2 == "3")
                            {
                                goto case "3";
                            }
                            else
                            {
                                goto default;
                            }
                        case "1":
                            TalkBarman();
                            break;
                        case "2":
                            DrinkBarman(MainCharacter.HP, MainCharacter.MT, MainCharacter.Money);
                            break;
                        case "3":
                            GoToTavern(PopTavrn, ProsTavrn);
                            break;
                        default:
                            Console.Write("Давай по новой, Миша, все хуйня: ");
                            choice2 = Console.ReadLine();
                            goto case "dew";

                    }


                }

                void DrinkBarman(int gghp, int ggmp, int moneys)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    if (moneys < 5)
                    {
                        Console.WriteLine("У вас нет денег, чтобы выпить.");
                        Console.WriteLine("");
                        Console.WriteLine(new string('#', 80));
                        Console.WriteLine("");
                        Console.ReadKey();
                        GoToBar();
                    }
                    Console.WriteLine("Вы заказываете себе выпить.");
                    Console.WriteLine("Ваше моральное состояние улучшилось.");
                    MainCharacter.RemoveMoney(5);
                    MainCharacter.RemoveHP(2);
                    MainCharacter.AddMT(25);
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.ReadKey();
                    GoToBar();

                }



                void TalkBarman()
                {
                    // Генератор для слухов
                    int value = rnd.Next(1, 10);
                    int value2 = rnd.Next(1, 10);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.WriteLine("Вы спрашиваете у владельца таверны, слышал ли он что-либо.");
                    switch (value2) // "Бармен перед слухами"
                    {
                        case 1:
                            Console.WriteLine("Владелец таверны нервно оглядывается и произносит:");
                            break;
                        case 2:
                            Console.WriteLine("Владелец таверны, раздумывая пару секунд, говорит:");
                            break;
                        case 3:
                            Console.WriteLine("Владелец таверны, сплюнув на пол, говорит:");
                            break;
                        case 4:
                            Console.WriteLine("Владелец таверны, наливая еще один стакан посетителю, произносит:");
                            break;
                        case 5:
                            Console.WriteLine("Владелец таверны, убрав грязные стаканы, произносит:");
                            break;
                        case 6:
                            Console.WriteLine("Владелец таверны, посмотрев на вас, говорит:");
                            break;
                        case 7:
                            Console.WriteLine("Владелец таверны что-то делает и произносит:");
                            break;
                        case 8:
                            Console.WriteLine("Владелец таверны... Говорит:");
                            break;
                        case 9:
                            Console.WriteLine("Владелец таверны... Произносит:");
                            break;
                        case 10:
                            Console.WriteLine("Владелец таверны говорит:");
                            break;

                    }
                    switch (value) // Сами слухи
                    {
                        case 1:
                            Console.WriteLine("'Сохраняй спокойствие'");
                            break;
                        case 2:
                            Console.WriteLine("'Будь готов к чему угодно'");
                            break;
                        case 3:
                            Console.WriteLine("'Помни о возможности осмотреться'");
                            break;
                        case 4:
                            Console.WriteLine("'Обрати внимание на то, где ты останавливаешься'");
                            break;
                        case 5:
                            Console.WriteLine("'Помни о дальности зрения каждого противника'");
                            break;
                        case 6:
                            Console.WriteLine("'Шуми'");
                            break;
                        case 7:
                            Console.WriteLine("'Привлечение внимания требует времени'");
                            break;
                        case 8:
                            Console.WriteLine("'Обращай внимание на окна'");
                            break;
                        case 9:
                            Console.WriteLine("'Открывай двери используя свое оружие'");
                            break;
                        case 10:
                            Console.WriteLine("'Не упусти дверь в зону миссии'");
                            break;

                    }
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    // Конец генератора
                    Console.ReadKey();
                    GoToBar();
                }


            }

        }
    

        public abstract class VillageDef
        {

            public string Name { get; set; }
            public int Buildings { get; set; }
            public int Pops { get; set; }
            public int Prosp { get; set; }
            protected bool Tavern { get; set; }
            protected bool Blacksmith { get; set; }
            protected bool Market { get; set; }
            protected bool Church { get; set; }
            Tavrn tavern = new Tavrn();
            Churh church = new Churh();

            public virtual void PlotVill()
            {
            }

            public void DefVillAct()
            {
                int a = 0;
                string[] arr = new string[5];
                Console.WriteLine(new string('#', 80));
                //Обстановка, начало
                int bulds = Buildings; //15 - маленькая деревня, 35 - средняя деревня, 60 - небольшой город
                string name = Name;
                int pop = Pops;
                int pros = Prosp; // 0 - нищие, 1 - бедные, 2 - зажиточные, 3 - богатые
                                  // Описание пункта
                if (bulds > 10 && bulds < 20)
                {
                    Console.WriteLine("Вы находитесь в маленькой деревне " + name + ".");
                }
                else if (bulds > 20 && bulds < 50)
                {
                    Console.WriteLine("Вы находитесь в средней деревне " + name + ".");
                }
                else if (bulds > 50 && bulds < 70)
                {
                    Console.WriteLine("Вы находитесь в небольшом городе " + name + ".");
                }

                if (pop > 10 && pop < 35)
                {
                    Console.WriteLine("На ваш взгляд, тут проживает около 25-ти человек.");
                    switch (pros)
                    {
                        case 0:
                            Console.WriteLine("Местные жители явно бедствуют.");
                            break;
                        case 1:
                            Console.WriteLine("Местные жители кое-как сводят концы с концами.");
                            break;
                        case 2:
                            Console.WriteLine("Местных жителей не назовешь богатыми, но они и не бедствуют.");
                            break;
                        case 3:
                            Console.WriteLine("Местные жители живут довольно-таки богато.");
                            break;

                    }
                }

                if (pop > 35 && pop < 75)
                {
                    Console.WriteLine("На ваш взгляд, тут проживает около 50-ти человек.");
                    switch (pros)
                    {
                        case 0:
                            Console.WriteLine("Население данной деревни явно бедствует.");
                            break;
                        case 1:
                            Console.WriteLine("Население данной деревни кое-как сводит концы с концами.");
                            break;
                        case 2:
                            Console.WriteLine("Население данной деревни не назовешь богатым, но и не бедным.");
                            break;
                        case 3:
                            Console.WriteLine("Население данной деревни живет довольно-таки богато.");
                            break;

                    }
                }

                if (pop > 75 && pop < 345 && bulds < 50)
                {
                    Console.WriteLine("На ваш взгляд, тут проживает около 200-та человек.");
                    switch (pros)
                    {
                        case 0:
                            Console.WriteLine("Хоть в деревне проживает много людей, обстановка среди них плачевная.");
                            break;
                        case 1:
                            Console.WriteLine("Хоть в деревне проживает много людей, подавляющая часть из них живет в бедных условиях.");
                            break;
                        case 2:
                            Console.WriteLine("Почти одна вторая часть населения живет в хороших условиях и имеют собственные усадьбы.");
                            break;
                        case 3:
                            Console.WriteLine("Почти вся деревня не испытывает проблем и успешно развивается.");
                            break;
                    }

                }
                if (pop > 75 && pop < 345 && bulds > 50)
                {
                    Console.WriteLine("На ваш взгляд, тут проживает около 200-та человек.");
                    switch (pros)
                    {
                        case 0:
                            Console.WriteLine("Город в очень плачевном состоянии; Торговцев и ремесленников почти нет и люди пытаются покинуть это место.");
                            break;
                        case 1:
                            Console.WriteLine("Население города живет бедно; Торговля идет плохо и все чаще люди задумываются о том, чтобы покинуть это место.");
                            break;
                        case 2:
                            Console.WriteLine("Город в более-менее хорошем состоянии; Бедняков имеют собственный районы...");
                            break;
                        case 3:
                            Console.WriteLine("Город явно процветает; Местные люди живкт богато...");
                            break;
                    }
                }
                //Постройки
                Console.WriteLine("В " + name + " есть:");
                if (Tavern)
                {
                    a++;
                    arr[a] = $"{a}.Таверна";
                    Console.WriteLine(arr[a]);
                }
                if (Blacksmith)
                {
                    a++;
                    arr[a] = $"{a}.Кузня(???)";
                    Console.WriteLine(arr[a]);
                }
                if (Market)
                {
                    a++;
                    arr[a] = $"{a}.Рынок";
                    Console.WriteLine(arr[a]);
                }
                if (Church)
                {
                    a++;
                    arr[a] = $"{a}.Церковь";
                    Console.WriteLine(arr[a]);
                }

                //Конец построек

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("            ");
                }

                Console.WriteLine(new string('#', 80));

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("            ");
                }
                //Конец описания
                Console.WriteLine("Вы можете:");
                if (Tavern)
                {
                    Console.WriteLine("[T] - Таверна");
                }
                if (Blacksmith)
                {
                    Console.WriteLine("[B] - Кузня(???)");
                }
                if (Market)
                {
                    Console.WriteLine("[M] - Рынок");
                }
                if (Church)
                {
                    Console.WriteLine("[C] - Церковь");
                }
                string choice;
                Console.Write("Введите букву(Регистр важен): ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        if (choice == "T")
                        {
                            goto case "T";
                        }
                        else if (choice == "B")
                        {
                            goto case "B";
                        }
                        else if (choice == "M")
                        {
                            goto case "M";
                        }
                        else if (choice == "C")
                        {
                            goto case "C";
                        }
                        else
                        {
                            goto default;
                        }
                    case "T":
                        tavern.GoToTavern(pop, pros); //Переход к классу "Таверна"
                        Console.Clear();
                        DefVillAct();
                        break;
                    case "B":
                        Console.WriteLine("Black");
                        break;
                    case "M":
                        Console.WriteLine("Market");
                        break;
                    case "C":
                        church.GoToChurch(pop, pros); //Переход к классу "Церковь"
                        Console.Clear();
                        DefVillAct();
                        break;
                    default:
                        Console.Write("Давай по новой, Миша, все хуйня: ");
                        choice = Console.ReadLine();
                        goto case "1";
                }

            }

        }
    



    public class Dragenhof : VillageDef
    {
        public Dragenhof()
        {
            Name = "Драгенхоф";
            Buildings = 57;
            Pops = 325;
            Prosp = 1;
            Tavern = true;
            Church = true;

        }


    }




