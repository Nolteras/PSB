using Portania_strikes_back;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//~ public class SmallSword : Weapon
//~ {
//~ //Не может отрубать конечности

//~ public SmallSword()
//~ {
//~ damage = 15;
//~ typeOfWeapon = 0;
//~ }
//~ }


//~ public class BigSword : Weapon
//~ {

//~ //Может отрубить голову

//~ public BigSword()
//~ {
//~ damage = 40;
//~ typeOfWeapon = 1;
//~ }
//~ }







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
        Console.WriteLine("Молодой оруженосец по имени " + NameGG + " только-только выпустился из оружейной академии Барона Керонча."); //Все это к херам переделать nconc: да вроде и так нормально
        MainCharacter.Name = NameGG;
        Console.ReadKey();
    }

    public static void AboutWorld()
    {
        Console.Clear();
        Console.WriteLine("Ну в общем сначала был Крац");
        Console.WriteLine("А потом злой Матрац");
        Console.WriteLine("И теперь тебе придется это разгребать");
        Console.ReadKey();
        DisplayMenu();
    }

    public static void AboutUs()
    {
        Console.Clear();
        Console.WriteLine("Сценарист - ???(Ушел в порно-индустрию)");
        Console.WriteLine("Автор мира - Markela");
        Console.WriteLine("Глав. Гад - Нолтерасс А.К.А Нолт А.К.А Террррррновое Вино А.К.А Noltras"); //
        Console.WriteLine("Соавтор - Солнцеликий Nconc");
        Console.ReadKey();
        DisplayMenu();

    }

    public static void TestStuff()
    {
        Console.Clear();
        Weapon sword = new Weapon(0);
        Dragenhof dragenhof = new Dragenhof();
        dragenhof.DefVillAct();
        FightModule fight = new FightModule();
        fight.GetEnemy("Human", 8, 50, 20, 10, 0, 0);
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
        string choice;
        Console.Write("Введите число [1-5]: "); // постоянное меню
        choice = Console.ReadLine(); // ввод меню
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
                StartThisShit();
                break;
            case "2":
                AboutWorld();
                break;
            case "3":
                AboutUs();
                break;
            case "4":
                TestStuff();
                break;
            case "5":
                CloseAllThisShit();
                break;
            default:
                Console.Write("Давай по новой, Миша, все хуйня: ");
                choice = Console.ReadLine();
                goto case "dew";
        }
    }
}