using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    class Player
    {

        ConsoleKeyInfo command;
        private int x, y;

        internal void Move(Map game)
        {
                while ((command = Console.ReadKey(true)).Key != ConsoleKey.Escape && game.gameOn == true)
                {
                    game.PrintMap();
                    Console.WriteLine("Press escape to exit.");
                    Console.WriteLine("Map size: " + game.mapSize);
                    game.FindPlayer();
                    x = game.playerLocation[1];
                    y = game.playerLocation[0];
                    game.morko.Move(game);
                    switch (command.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (y > 1)
                            {
                                y--;
                                game.MovePlayer(x, y);
                            }
                            break;

                        case ConsoleKey.UpArrow:
                            if (x > 1)
                            {
                                x--;
                                game.MovePlayer(x, y);
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            if (y < game.mapY - 2)
                            {
                                y++;
                                game.MovePlayer(x, y);
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            if (x < game.mapX - 2)
                            {
                                x++;
                                game.MovePlayer(x, y);
                            }
                            break;




                    }
                game.FindMonster();
                game.FindPlayer();

                if (game.monsterLocation[1] == game.playerLocation[1])
                {
                    if(game.monsterLocation[0] - game.playerLocation[0] < 2 && game.monsterLocation[0] - game.playerLocation[0] > -1) { game.gameOn = false; game.gameOver = true; }
                    else if(game.playerLocation[0] - game.monsterLocation[0] < 2 && game.playerLocation[0] - game.monsterLocation[0] > -1) { game.gameOn = false; game.gameOver = true; }
                }
                
                else if(game.monsterLocation[0] == game.playerLocation[0])
                {
                    if (game.monsterLocation[1] - game.playerLocation[1] < 2 && game.monsterLocation[1] - game.playerLocation[1] > -1) { game.gameOn = false; game.gameOver = true; }
                    else if (game.playerLocation[1] - game.monsterLocation[1] < 2 && game.playerLocation[1] - game.monsterLocation[1] > -1) { game.gameOn = false; game.gameOver = true; }
                }  
                }             
            
        }
    }
}
