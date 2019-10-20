using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Weapon : Item
    {
        public int armorPen; //пробитие
        public int wnLength; //длина
        public int dam; //урон
        Random random = new Random();

        public Weapon(string name, int weight)
        {
            Name = name;
            Weight = weight;
            Type = 1;
            armorPen = random.Next(weight, weight + 5);
            wnLength = random.Next(armorPen, armorPen + 4);
            dam = random.Next(weight, wnLength);
        }


        public void getDescr()
        {
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");
            Console.WriteLine($"Короткий меч");
            Console.WriteLine($"Урон - {dam}");
            Console.WriteLine($"Тяжесть - {Weight}");
            Console.WriteLine($"Длина - {wnLength}");
            Console.WriteLine($"Пробитие брони - {armorPen}");
            Console.WriteLine("");
            Console.WriteLine(new string('#', 80));
            Console.WriteLine("");

        }
    }
}
