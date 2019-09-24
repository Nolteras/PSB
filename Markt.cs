using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Markt
    {
        int popMarket;
        int prosMarket;
        // Описание и возможности
        public void GoToMarket(int popmarket, int prosmarket)
        {
            popMarket = popmarket;
            prosMarket = prosmarket;
            Console.Clear();
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("Вы приходите на рынок.");
            if (popmarket > 10 && popmarket < 35)
            {
                Console.WriteLine("Рынок выглядит пустым.");
            }
            else if (popmarket > 35 && popmarket < 75)
            {
                Console.WriteLine("Рынок, не смотря на маленькое население, живет своей жизнью.");
            }
            else if (popmarket > 75 && popmarket < 345)
            {
                Console.WriteLine("Рынок выглядит оживленно.");
            }

            switch (prosmarket)
            {
                case 0:
                    Console.WriteLine("Но не смотря на это, торговцев почти нет, а те, кто есть, завышают цены до небес.");
                    break;
                case 1:
                    Console.WriteLine("Но не смотря на это, торговля в этом поселении умирает от высоких цен и сравнительно небольшого кол-ва товаров.");
                    break;
                case 2:
                    Console.WriteLine("Но не смотря на это, рынок не выглядит бедным; То тут, то там видны разные торговцы, а их товары имеют приемлемую цену.");
                    break;
                case 3:
                    Console.WriteLine("Но не смотря на это, рынок полон торговцами и разными товарами; Торговля процветает и такое положение дел положительно влияет на местные цены.");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
        }
    }
}
