using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class GameAct
{
    static GameBase gb = new GameBase();
    public static void Main(string[] args) //входная точка программы
    {
        gb.DisplayMenu();

    }
}
