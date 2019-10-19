using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Church : Business
    {
        int darkKrac; //последователи темного краца
        int noDarkKrac; //не последователи темного краца
        int religiousZeal; //???
        bool canGetBless = true; //можно ли О Б М А З А Т Ь С Я  Б Л А Г О С Л О В Е Н И Е М

        public Church(int popul, int prosp)
        {
            Pop = popul;
            Pros = prosp;
            Name = "Церковь";
        }

        // Описание и возможности

        public int GetReligiousZeal()
        {
            switch (Pros)
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


        public void GoToChurch() //основной метод церкви
        {
            Console.Clear();
            GetReligiousZeal();
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("Вы захождите в церковь.");
            switch (Pros)
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
            getDarkKrac();
            Console.WriteLine("Последователей  'Темного Краца' - " + darkKrac + "");
            getNoDarkKrac();
            Console.WriteLine("Последователей  'Не Темного Краца' - " + noDarkKrac + "");
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine("Вы можете:");
            Console.WriteLine("[1] - Попросить благословение.");
            Console.WriteLine("[2] - Покинуть церковь.");

            string choice;
            Console.Write("Введите цифру: ");
            choice = Console.ReadLine();
            bool done = false;
            while (!done)
            {
                switch (choice)
                {
                    case "1":
                        done = true;
                        if (canGetBless) //если можно О Б М А З А Т Ь С Я
                        {
                            getBless();//обмазываемся
                        }
                        else //иначе не обмазываемся
                        {
                            Console.Clear();
                            Console.WriteLine('\n' + new string('#', 80) + '\n');
                            Console.WriteLine("В этом месте вы уже обращались к Крацу.");
                            Console.WriteLine("");
                            Console.WriteLine(new string('#', 80));
                            Console.WriteLine("");
                            Console.ReadKey();
                            GoToChurch(); //возвращаемся в основной метод
                        }
                        break;
                    case "2":
                        break;
                    default:
                        Console.Write("Давай по новой, Миша, все хуйня: ");
                        choice = Console.ReadLine();
                        break;
                }
            }
        }



        int getDarkKrac() //вычисляем кол-во последователей
        {
            darkKrac = (Pop / 4) + religiousZeal + 15; //делим всех посетителей церкви на 4, прибавляем (что-то) и 15
            return darkKrac;
        }

        int getNoDarkKrac() //остальные - не последователи
        {
            noDarkKrac = Pop - darkKrac;
            return noDarkKrac;
        }

        void getBless() //молимся и О Б М А З Ы В А Е М С Я  Б Л А Г О С Л О В Е Н И Е М
        {
            Console.Clear();
            Console.WriteLine('\n' + new string('#', 80) + '\n');
            Console.WriteLine("Вы усердно молитесь...");
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            canGetBless = false;
            int gotBless = random.Next(0, 3); //результат молитвы
            Console.ReadKey();
            switch (gotBless) //вычисляем последствия молитвы
            {
                case 0: //очень плохо помолились
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.WriteLine("Вам кажется, что ничего не поменялось.");
                    Console.WriteLine("");
                    Console.WriteLine(new string('#', 80));
                    Console.WriteLine("");
                    Console.ReadKey();
                    GoToChurch();
                    break;
                case 1: //хорошо помолились
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
                    GoToChurch();
                    break;
                case 2: //слишком хорошо помолились
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
                    GoToChurch();
                    break;
                case 3: //О Т Д А Й  С В О Ю  Д У Ш У
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
                    GoToChurch();
                    break;
            }
        }

    }
}
