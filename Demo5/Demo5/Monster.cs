using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    class Monster
    {
        private int targetX;
        private int targetY;
        private int monsterX;
        private int monsterY;
        private int xDiff;
        private int yDiff;

        internal void Move(Map game)
        {
            game.FindMonster();
            game.FindPlayer();
            targetX = game.playerLocation[1];
            targetY = game.playerLocation[0];
            monsterX = game.monsterLocation[1];
            monsterY = game.monsterLocation[0];
            bool monxBigger;
            bool monyBigger;

            if (monsterX > targetX) { xDiff = monsterX - targetX; monxBigger = true; }
            else { xDiff = targetX - monsterX; monxBigger = false; }
            if (monsterY > targetY) { yDiff = monsterY - targetY; monyBigger = true; }
            else { yDiff = targetY - monsterY; monyBigger = false; }

            if (xDiff > yDiff)
            {
                if(monxBigger == true) { game.MoveMonster(monsterY, monsterX - 1); }
                else { game.MoveMonster(monsterY, monsterX + 1); }
            }
            else
            {
                if(monyBigger == true) { game.MoveMonster(monsterY - 1, monsterX); }
                else { game.MoveMonster(monsterY + 1, monsterX); }
            }
        }
    }
}
