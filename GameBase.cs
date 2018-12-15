using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





public static class GGInventory //Инвентарь, задания, прочее, связанное с ГГ
{
    static public int PlotInGG = GameBase.Plot;
    static public string NameGG = GameBase.Name;
    static public int SuplSupply = 0;


}

public static class GameBase
{

   static public string Name { get; set; }
    static public int Plot = 0;
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
        Console.WriteLine("Молодой оруженосец по имени " + NameGG + " только-только выпустился из оружейной академии Барона Керонча.");
        Name = NameGG;
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

}

class Markt
{

}

class Weapn
{

}

class Armor
{

}

public class Tavrn
{
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
            Console.WriteLine("Таверна выглядит запустелой.");
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
                break;
            case "3":
                break;
            default:
                Console.Write("Давай по новой, Миша, все хуйня: ");
                choice = Console.ReadLine();
                goto case "dew";

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
                    break;
                case "2":
                    break;
                case "3":
                    GoToTavern(PopTavrn, ProsTavrn);
                    break;
                default:
                    Console.Write("Давай по новой, Миша, все хуйня: ");
                    choice = Console.ReadLine();
                    goto case "dew";

            }

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
    protected bool Armory { get; set; }
    protected bool Weapns { get; set; }
    protected bool Market { get; set; }
    protected bool Church { get; set; }
    Tavrn tavern = new Tavrn();

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
        if (Armory)
        {
            a++;
            arr[a] = $"{a}.Бронница";
            Console.WriteLine(arr[a]);
        }
        if (Weapns)
        {
            a++;
            arr[a] = $"{a}.Оружейник(???)";
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
        if (Armory)
        {
            Console.WriteLine("[A] - Бронница");
        }
        if (Weapns)
        {
            Console.WriteLine("[W] - Оружейная");
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
                else if (choice == "A")
                {
                    goto case "A";
                }
                else if (choice == "W")
                {
                    goto case "W";
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
                tavern.GoToTavern(pop, pros);
                Console.Clear();
                DefVillAct();
                break;
            case "A":
                Console.WriteLine("Armory");
                break;
            case "W":
                Console.WriteLine("Weapon");
                break;
            case "M":
                Console.WriteLine("Market");
                break;
            case "C":
                Console.WriteLine("Cerkov");
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
        Name = "Дракенхоф";
        Buildings = 57;
        Pops = 325;
        Prosp = 0;
        Tavern = true;
        Church = true;   

    }

}