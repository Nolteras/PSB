using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameAct
{

    public static void Main(string[] args)
    {
        GameBase start = new GameBase();
        start.DisplayMenu();
        Console.Clear();
        Dragenhof village1 = new Dragenhof();
        village1.DefVillAct();
        Console.ReadKey();

    }
}
