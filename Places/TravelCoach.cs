using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back.Places
{
    class TravelCoach : Business
    {
        //в данный момент класс забракован, требуется пересмотреть структуру деревень

        //    TravelModule trav = new TravelModule();
        //    VillageDef[] destin = new VillageDef[VillageDef.names.Length];
        public TravelCoach(int popul, int prosp)
        {
            Pop = popul;
            Pros = prosp;
            Name = "Извозчик";
        }

        public override void GoTo()
        {
        }
            //        bool doneAll = false;
            //        while (!doneAll)
            //        {
            //            Console.Clear();
            //            Console.WriteLine(new string('#', 80));
            //            Console.WriteLine("Вы подходите к извозчику и спрашиваете стоимость его услуг.");
            //            Console.WriteLine("Он перечисляет вам возможные пункты назначения");
            //            for (int i = 0; i < random.Next(1, 4); i++)
            //            {
            //                destin[i] = trav.TravelTo();
            //                Console.WriteLine(i + ": " + destin[i].Name);
            //            }
            //            Console.WriteLine("Путешествие в любой пункт будет стоить 100 монет");
            //            if(MainCharacter.Money >= 100)
            //            {
            //                bool done = false;
            //                while (!done) {
            //                    Console.WriteLine("Выберите пункт:");
            //                    string choice = Console.ReadLine();
            //                    int iChoice;
            //                    if (int.TryParse(choice, out iChoice))
            //                    {
            //                        done = true;
            //                        doneAll = true;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("У вас недостаточно денег для этого");
            //                doneAll = true;
            //            }
            //        }
            //    }
        }
}
