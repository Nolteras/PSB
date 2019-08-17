using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
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
        Blacksmt blacksmith = new Blacksmt();

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
                   blacksmith.GoToBlacksmt(pros);
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
}
