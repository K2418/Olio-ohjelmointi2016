using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    abstract class Coordinates
    {
        internal int[] playerLocation = new int[2];
        internal int[] monsterLocation = new int[2];
        public int mapSize;

        private void MapSize(Map game)
        {
            mapSize = game.mapX * game.mapY;
        }

        internal int[] FindPlayer(Map game)
        {
            for(int i = 0; i < game.mapY; i++)
            {
                for (int j = 0; j < game.mapX; j++)
                {
                    if (game.map[i,j] == '@')
                    {
                        playerLocation[0] = i;
                        playerLocation[1] = j;
                    }
                }
            }
            return playerLocation;
        }

        internal int[] FindMonster(Map game)
        {
            for (int i = 0; i < game.mapY; i++)
            {
                for (int j = 0; j < game.mapX; j++)
                {
                    if (game.map[i, j] == 'm')
                    {
                        monsterLocation[0] = i;
                        monsterLocation[1] = j;
                    }
                }
            }
            return monsterLocation;
        }


    }
}
