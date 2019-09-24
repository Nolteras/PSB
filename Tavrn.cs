using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
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
                                Console.WriteLine("У вас нет денег на это."); //ГЫЫЫЫЯЫЫ ТЫ БОМЖ
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
                                Console.WriteLine("После того, как вы его съели, вам стало очень хорошо.");//Править меню nconc: В плане править? 
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
                Console.WriteLine("nconc: тут довольно оригинальный способ оставлять комментарии");
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
                    case "dew": //nconc: и снова вопрос: зачем нужен этот кейс? 
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
                int value = rnd.Next(1, 13);
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
                    case 11:
                        Console.WriteLine("'tovarish, mne nravitsya vash govnokod'");
                        break;
                    case 12:
                        Console.WriteLine("'tovarish, codit' c# na raspbian - eto pizdec'");
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
}
