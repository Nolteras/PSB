﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameBase
{
    public string Name { get; set; }
    public int Plot = 0;
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
        Console.WriteLine("Молодой оруженосец по имени " + NameGG + " только-только выпустился из оружейной академии Барона Керонча.");
        Name = NameGG;
        Console.ReadKey();
    }

    public void AboutWorld()
    {

    }

    public void AboutUs()
    {
        Console.Clear();
        Console.WriteLine("Сценарист - ???(Ушел в порно-индустрию)");
        Console.WriteLine("Автор мира - Markela");
        Console.WriteLine("Глав. Гад - Нолтерасс А.К.А Нолт А.К.А Террррррновое Вино А.К.А Noltras");
        Console.ReadKey();
        DisplayMenu();

    }

    public void Menu()
    {
        Dragenhof dragenhof = new Dragenhof();
        dragenhof.DefVillAct();
        Console.ReadKey();


    }

    public void CloseAllThisShit()
    {
    }


    public void DisplayMenu()
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
                Menu();
                break;
            case 5:
                CloseAllThisShit();
                break;
        }
    }



}



public class VillageDef
{

    public string Name { get; set; }
    public int Buildings { get; set; }
    public int Pops { get; set; }
    public int Prosp { get; set; }
    protected bool Tavern { get; set; }
    protected bool Dorms { get; set; }
    protected bool Armory { get; set; }
    protected bool Market { get; set; }
    protected bool Church { get; set; }

    public void DefVillAct()
    {
        //Обстановка, начало
        int bulds = Buildings;
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

        if ( pop > 75 && pop < 345 && bulds < 50)
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
        if(pop > 75 && pop < 345 && bulds > 50)
        {
            Console.WriteLine("На ваш взгляд, тут проживает около 200-та человек.");
            switch (pros)
            {
                case 0:
                    Console.WriteLine("Город в очень плачевном состоянии; Торговцев и ремесленников почти нет и люди пытаются покинуть это место.");
                    break;
            }
        }




    }
}





public class Dragenhof : VillageDef
{
    public Dragenhof()
    {
        Name = "Дракенхоф";
        Buildings = 72;
        Pops = 325;
        Prosp = 0;
        Tavern = true;
        Dorms = true;    
    }

}