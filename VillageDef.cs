using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portania_strikes_back.Places;
using System.IO;

namespace Portania_strikes_back
{
    public class VillageDef
    {
        Random rnd = new Random();
        public static bool doneAll = false;
        public string Name { get; set; }
        public int Buildings { get; set; }
        public int Pops { get; set; }
        public int Prosp { get; set; }

        protected Business[] places = new Business[6];


        public VillageDef(int buildings, int pops, int prosp)
        {
            Name = Names.GetName();
            Buildings = buildings;
            Pops = pops;
            Prosp = prosp;
            Tavrn tavern = new Tavrn(Pops, Prosp);
            Church church = new Church(Pops, Prosp);
            Blacksmt blacksmith = new Blacksmt(Pops, Prosp);
            Markt market = new Markt(Pops, Prosp);
            Arena arena = new Arena();
            TravelCoach trav = new TravelCoach(Pops, Prosp);
            places[0] = tavern;
            places[1] = church;
            places[2] = blacksmith;
            places[3] = market;
            places[4] = arena;
            places[5] = trav;
        }
        public VillageDef(string name, int buildings, int pops, int prosp)
        {
            Name = name;
            Buildings = buildings;
            Pops = pops;
            Prosp = prosp;
            Tavrn tavern = new Tavrn(Pops, Prosp);
            Church church = new Church(Pops, Prosp);
            Blacksmt blacksmith = new Blacksmt(Pops, Prosp);
            Markt market = new Markt(Pops, Prosp);
            Arena arena = new Arena();
            TravelCoach trav = new TravelCoach(Pops, Prosp);
            places[0] = tavern;
            places[1] = church;
            places[2] = blacksmith;
            places[3] = market;
            places[4] = arena;
            places[5] = trav;
        }



        public void DefVillAct()
        {
            while (!doneAll)
            {
                Console.Clear();
                Console.WriteLine(new string('#', 80));
                //Обстановка, начало
                //15 - маленькая деревня, 35 - средняя деревня, 60 - небольшой город
                string name = Name; // 0 - нищие, 1 - бедные, 2 - зажиточные, 3 - богатые
                                    // Описание пункта
                if (Buildings >= 0 && Buildings < 10)
                {
                    Console.WriteLine($"Вы находитесь в гиблой деревне {name}.");
                }
                else if (Buildings >= 10 && Buildings < 20)
                {
                    Console.WriteLine($"Вы находитесь в маленькой деревне {name}.");
                }
                else if (Buildings >= 20 && Buildings < 50)
                {
                    Console.WriteLine($"Вы находитесь в средней деревне {name}.");
                }
                else if (Buildings >= 50 && Buildings < 70)
                {
                    Console.WriteLine($"Вы находитесь в небольшом городе {name}.");
                }
                else if (Buildings >= 70)
                {
                    Console.WriteLine($"Вы находитесь в большом городе {name}.");
                }

                if (Pops == 0)
                {
                    Console.WriteLine("Население этой деревни вымерло");
                }
                else if (Pops > 0 && Pops < 35)
                {
                    Console.WriteLine("На ваш взгляд, тут проживает около 25-ти человек.");
                    switch (Prosp)
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

                if (Pops >= 35 && Pops < 75)
                {
                    Console.WriteLine("На ваш взгляд, тут проживает около 50-ти человек.");
                    switch (Prosp)
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

                if (Pops >= 75 && Pops < 345 && Buildings < 50)
                {
                    Console.WriteLine("На ваш взгляд, тут проживает около 200-та человек.");
                    switch (Prosp)
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
                if (Pops >= 75 && Pops < 345 && Buildings > 50)
                {
                    Console.WriteLine("На ваш взгляд, тут проживает около 200-та человек.");
                    switch (Prosp)
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
                            Console.WriteLine("Город явно процветает; Местные люди живут богато...");
                            break;
                    }
                }
                //Постройки
                Console.WriteLine("В " + name + " есть:");
                for (int i = 0; i < places.Length; i++)
                {
                    if (places[i] != null)
                    {
                        Console.WriteLine($"{i + 1} - {places[i].Name}");
                    }
                }
                string choice;
                int c;
                Console.Write("Введите цифру: ");
                choice = Console.ReadLine();
                bool done = false;
                while (!done)
                {
                    if (choice != null && choice != "" && int.TryParse(choice, out c) && c >= 0 && c <= places.Length)
                    {
                        done = true;
                        int ch = c - 1;
                        if (ch == 5)
                        {
                            string tempName = Names.GetName();
                            while (tempName == Name)
                            {
                                tempName = Names.GetName();
                            }
                            Name = tempName;
                                Buildings = rnd.Next(1, 100);
                            Pops = rnd.Next(1, 100);
                            Prosp = rnd.Next(0, 4);
                        }
                        else
                        {
                            places[ch].GoTo();
                        }
                    }
                    else
                    {
                        Console.Write("Давай по новой, Миша, все хуйня: ");
                        choice = Console.ReadLine();
                    }
                }
            }
        }
    }
}
