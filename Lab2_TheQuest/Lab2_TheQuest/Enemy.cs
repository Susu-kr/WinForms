using System;
using System.Drawing;

namespace Lab2_TheQuest
{
    abstract class Enemy : Mover
    {
        private const int NEAR_PLAYER_DISTANCE = 25;
        private const int FIND_PLAYER_DISTANCE = 10;

        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }
        public bool Dead
        {
            get
            {
                if (hitPoints <= 0) return true;
                else return false;
            }
        }

        public Enemy(Game game, Point location, int hitPoints)
            : base(game, location) { this.hitPoints = hitPoints; }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NEAR_PLAYER_DISTANCE));
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + FIND_PLAYER_DISTANCE)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - FIND_PLAYER_DISTANCE)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - FIND_PLAYER_DISTANCE)
                directionToMove = Direction.Up;
            else directionToMove = Direction.Down;

            return directionToMove;
        }
    }
}
