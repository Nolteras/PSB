using Portania_strikes_back;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameBase
{

    Random rnd = new Random();


    public void StartThisShit()
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
        TestStuff();
    }

    public void AboutWorld()
    {
        Console.Clear();
        Console.WriteLine("To be added in the future builds");
        //Console.WriteLine("Ну в общем сначала был Крац");
        //Console.WriteLine("А потом злой Матрац");
        //Console.WriteLine("И теперь тебе придется это разгребать");
        Console.ReadKey();
        DisplayMenu();
    }

    public void AboutUs()
    {
        Console.Clear();
        Console.WriteLine("Сценарист - ???(Ушел в порно-индустрию)");
        Console.WriteLine("Автор мира - Markela");
        Console.WriteLine("Бывший глав. Гад - [DELETED]");//Нолтерасс А.К.А Нолт А.К.А Террррррновое Вино А.К.А Noltras"); 
        Console.WriteLine("Главный Глав. Гад - Солнцеликий Nconc");
        Console.ReadKey();
        DisplayMenu();

    }

    public void TestStuff()
    {
        Console.Clear();
        new VillageDef("Dragenhof", rnd.Next(1, 100), rnd.Next(1, 344), rnd.Next(0, 4)).DefVillAct();
        while (true)
        {
            new VillageDef(rnd.Next(1, 100), rnd.Next(1, 344), rnd.Next(0, 4)).DefVillAct();
        }
    }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("       Portania Strikes Back    ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("");
        }
        Console.WriteLine("1. Начать");
        Console.WriteLine("2. О Мире");
        Console.WriteLine("3. Разработчики");
        Console.WriteLine("4. Тест всякой шняги");
        Console.WriteLine("5. Выход");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("");
        }
        string choice;
        Console.Write("Введите число: "); // постоянное меню
        bool done = false;
        while (!done)
        {
                choice = Console.ReadLine();
            switch (choice)
            { 
                case "1":
                    done = true;
                    StartThisShit();
                    break;
                case "2":
                    done = true;
                    AboutWorld();
                    break;
                case "3":
                    done = true;
                    AboutUs();
                    break;
                case "4":
                    //done = true;
                    //TestStuff();
                    break;
                case "5":
                    done = true;
                    Environment.Exit(0);
                    break;
                default:

                    Console.Write("Давай по новой, Миша, все хуйня: ");
                    break;
            }
        }
    }

    public static void Death(bool cause)
    {
        Console.Clear();
        if (cause)
        {
            Console.WriteLine("Death by mind");
        }
        else
        {
            Console.WriteLine("Your body is dead");
        }
        Console.ReadKey();
        Environment.Exit(0);
    } 

}