using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portania_strikes_back
{
    public class Undead : Enemy
    {
        Random random = new Random();


        public override void Act()
        {
            int result;
            result = random.Next(1, 10);
        }

        public override int GetStat() // На данный момент алгоритм действует так: Раса, навык защиты, навык атаки, броня, шляпа, оружие
        {
            switch (TypeOfWeapon) // 0 - Кулаки, 1 - Короткий меч, 2 - Длинный меч
            {
                case 0:
                    return BaseDamageWeapon = 5;
                case 1:
                    return BaseDamageWeapon = 15;
                case 2:
                    return BaseDamageWeapon = 40;
            }
            return this.GetStat();
        }

    }
}
