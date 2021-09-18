using System;
using System.Drawing;

namespace Lab2_TheQuest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10) { }

        public override void Move(Random random)
        {
            if ((random.Next(1, 3) == 1 || random.Next(1, 3) == 2) && HitPoints > 0)
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);

            if (NearPlayer())
                game.HitPlayer(4, random);
        }
    }
}
