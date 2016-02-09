using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    class Map : Coordinates
    {
        internal char[,] map;
        private static char wall = '#';
        private static char player = '@';
        private static char monster = 'm';
        internal int mapY;
        internal int mapX;
        private int xForLoop = 0;
        internal bool gameOn = false;
        internal Player miuku;
        internal Monster morko;
        internal bool gameOver = false;

        private void CreateMap(int y, int x)
        {
            map = new char[y, x];
            mapY = y;
            mapX = x;

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (i == 0 || i == x - 1)
                    {
                        map[i, j] = wall;
                    }
                    else if (j == 0 || j == mapX - 1)
                    {
                        map[i, j] = wall;
                    }
                    else { map[i, j] = ' '; }
                }
            }
        }

        public void CreateGame()
        {
            CreateMap(20, 20);
            miuku = new Player();
            morko = new Monster();
            MapSize();
            map[1, 1] = player;
            map[mapY - 2, mapX - 2] = monster;
            FindPlayer();
            FindMonster();

        }

        public void PrintMap()
        {
            xForLoop = 0;
            while (xForLoop < mapX)
            {
                for (int i = 0; i < mapY; i++)
                {
                    Console.Write(map[i, xForLoop] + " ");

                }
                Console.Write("\n");
                xForLoop++;
            }
        }

        public void StartGame()
        {
            gameOn = true;
            Console.WriteLine("Welcome\nTry to keep away from monster!\nUse arrow keys to move!\n\nPress Enter key to start!\n");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)) { }
            miuku.Move(this);
            if (gameOver == true) { GameOver(); }
        }

        internal void MovePlayer(int x, int y)
        {
            map[playerLocation[0], playerLocation[1]] = ' ';
            map[y, x] = player;
        }

        internal void MoveMonster(int y, int x)
        {
            map[monsterLocation[0], monsterLocation[1]] = ' ';
            map[y, x] = monster;
        }

        private void MapSize()
        {
            mapSize = mapX * mapY;
        }

        internal int[] FindPlayer()
        {
            for (int i = 0; i < mapY; i++)
            {
                for (int j = 0; j < mapX; j++)
                {
                    if (map[i, j] == '@')
                    {
                        playerLocation[0] = i;
                        playerLocation[1] = j;
                    }
                }
            }
            return playerLocation;
        }

        internal int[] FindMonster()
        {
            for (int i = 0; i < mapY; i++)
            {
                for (int j = 0; j < mapX; j++)
                {
                    if (map[i, j] == 'm')
                    {
                        monsterLocation[0] = i;
                        monsterLocation[1] = j;
                    }
                }
            }
            return monsterLocation;
        }

        private void GameOver()
        {
            Console.WriteLine(@"                                                         ,--,  ,.-.     ");
            Console.WriteLine(@"                ,                   \,       '-,-`,' -.' | ._ '         ");           
            Console.WriteLine(@"                /|           \    ,   |\         }  )/  / `-,',         ");
            Console.WriteLine(@"               [ '          |\  /|   | |        /  \|  |/`  ,`          ");
            Console.WriteLine(@"               | |       ,.`  `,` `, | |  _,...((_',                    ");
            Console.WriteLine(@"                 \  \  __, -` `  ,  , `/ |, '      Y     (   \_L\       ");
            Console.WriteLine(@"                \  \_\,``,   ` , ,  /  |         )         _,/          ");
            Console.WriteLine(@"                 \  '  `  ,_ _`_,-,<._.<        /         /             ");
            Console.WriteLine(@"                  ', `>.,`  `  `   ,., |_      |         /              ");
            Console.WriteLine(@"                    \/`  `,   `   ,`  | /__,.-`    _,   `\              ");
            Console.WriteLine(@"                -,-..\  _  \  `  /  ,  / `._) _,-\`       \             ");
            Console.WriteLine(@"                 \_,,.) /\    ` /  / ) (-,, ``    ,        |            ");
            Console.WriteLine(@"                ,` )  | \_\       '-`  |  `(               \            ");
            Console.WriteLine(@"               /  /```(   , --, ,' \   |`<`    ,            |           ");
            Console.WriteLine(@"              /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)           ");
            Console.WriteLine(@"        , -, ,`   `   (_,\ \    |   /) / __/  /   `----`                ");
            Console.WriteLine(@"       (-, \           ) \ ('_.-._)/ /,`    /                           ");
            Console.WriteLine(@"       | /  `          `/ \\ V   V, /`     /                            ");
            Console.WriteLine(@"    , --\(        ,     <_/`\\     ||      /                            ");
            Console.WriteLine(@"   (   ,``-     \/|         \-A.A-`|     /                              ");
            Console.WriteLine(@"  ,>, _ )_,..()\          -,, _-`  _--`                                 ");
            Console.WriteLine(@" (_ \|`   _,/_  /  \_,--`                                               ");
            Console.WriteLine(@"  \( `   <.,../`     `-.._   _,-`                                       ");
            Console.WriteLine(@"   `                      ```                                           ");
            Console.WriteLine("\nGAME OVER\n");
            Console.WriteLine("\nPress ESC to quit");

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)) { }
        }
    }
}
