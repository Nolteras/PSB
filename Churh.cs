using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    class Churh
    {
        //TODO  добавить описание переменным
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
}
