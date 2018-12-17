using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





public static class GGInventory //Инвентарь, задания, прочее, связанное с ГГ
{
    static public int Plot = 0; // "Число сюжета"
    static public string Name; // Имя ГГ
    static public int Money = 100;
    static public int MT = 100;
    static public int HP = 100;
    static public int BeliveLev = 0;

    static private bool[] AllStatEffects = new bool[4];
    static public bool BadThoughts = AllStatEffects[0];
    static public bool Bleed = AllStatEffects[1];
    static public bool StatEffect3 = AllStatEffects[2];
    static public bool StatEffect4 = AllStatEffects[3];

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
        GGInventory.Name = NameGG;
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
        Dragenhof dragenhof = new Dragenhof();
        dragenhof.DefVillAct();

       Console.ReadKey();


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
    public int PopChurch;
    int darkKrac;
    int noDarkKrac;
    public int ProsChurch;
    int religiousZeal;
    // Описание и возможности

    public int GetReligiousZeal(int pros)
    {
        switch (pros)
        {
            case 0:
                return religiousZeal = 3;
            case 1:
                return religiousZeal = 2;
            case 2:
                return religiousZeal = 1;
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
        Console.WriteLine("Последователей  'Темного Краца' - " + darkKrac +"");
        getNoDarkKrac(PopChurch);
        Console.WriteLine("Последователей  'Не Темного Краца' - " + noDarkKrac + "");
        Console.ReadKey();
    }



    int getDarkKrac(int alldudes) //Переделать, использовать "Рвение" в качестве айди
    {
        darkKrac = (alldudes / 2) - religiousZeal * 2;
        return darkKrac;
    }

    int getNoDarkKrac(int alldudes)
    {
        noDarkKrac = (alldudes - darkKrac) + religiousZeal * 2;
        return noDarkKrac;
    }

}


class Markt
{

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
        } else if(poptavrn > 35 && poptavrn < 75)
        {
            Console.WriteLine("Таверна выглядит запустелой.");
        } else if(poptavrn > 75 && poptavrn < 345)
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
                EatMeal(GGInventory.HP, GGInventory.MT, GGInventory.Money);
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
                Console.WriteLine("[1] - ДОХОДНЫЙ ЧАЙ(15)"); // Нет
                if (moneys >= 50)
                {
                    Console.WriteLine("[2] - ЧАЙ(50)"); // Нет, пожалуйста
                    if(moneys >= 100)
                    {
                        Console.WriteLine("[3] - ДОРОГОЙ ЧАЙ(100)"); // Черт
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
                            Console.WriteLine("Вы заказываете самый дешевый чай.");
                            GGInventory.RemoveMoney(15);
                            Console.WriteLine("После того, как вы его выпили, вам стало чуть-чуть лучше.");
                            GGInventory.AddHP(10);
                            GGInventory.AddMT(5);
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
                            Console.WriteLine("Вы заказываете чай.");
                            GGInventory.RemoveMoney(50);
                            Console.WriteLine("После того, как вы его выпили, вам стало лучше.");
                            GGInventory.AddHP(20);
                            GGInventory.AddMT(10);
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
                            Console.WriteLine("Вы заказываете ПРЯМ ХОРОШИЙ чай.");
                            GGInventory.RemoveMoney(100);
                            Console.WriteLine("После того, как вы его выпили, вам стало ХОРОШО.");
                            GGInventory.AddHP(25);
                            GGInventory.AddMT(15);
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
                    DrinkBarman(GGInventory.HP, GGInventory.MT, GGInventory.Money);
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
            if(moneys < 5)
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
            GGInventory.RemoveMoney(5);
            GGInventory.RemoveHP(2);
            GGInventory.AddMT(25);
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
                church.GoToChurch(pop, pros); //Переход к классу "Таверна"
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

public  class Dragenhof : VillageDef
{
    public Dragenhof()
    {
        Name = "Драгенхоф";
        Buildings = 57;
        Pops = 325;
        Prosp = 3;
        Tavern = true;
        Church = true;   

    }

}