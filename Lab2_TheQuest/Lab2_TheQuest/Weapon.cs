using System;
using System.Drawing;

namespace Lab2_TheQuest
{
    abstract class Weapon : Mover
    {
        private const int IMAGEWITDH = 40;
        private const int IMAGEHEIGHT = 40;

        public bool PickedUp { get; private set; }
        private Size OnMapPictureBoxSize = new Size(IMAGEWITDH, IMAGEHEIGHT);


        public Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() { PickedUp = true; }
        public abstract string Name { get; }
        public abstract void Attack(Direction direction, Random radom);
        protected bool DamageEnemy(Direction direction, int attack_radius, int damage, Random random)
        {
            Point playerLocation = game.PlayerLocation;
            foreach (Enemy enemy in game.Enemies)
            {
                if (!enemy.Dead && Nearby(direction, enemy.Location, playerLocation, attack_radius))
                {
                    enemy.Hit(damage, random);
                    return true;
                }
            }
            playerLocation = Move(direction, playerLocation, game.Boundaries);
            return false;
        }

        private bool Nearby(Direction direction, Point enemyLocation, Point playerLocation, int distance)
        {
            Rectangle enemyRect = new Rectangle(enemyLocation, OnMapPictureBoxSize);
            Rectangle playerAttackArea = new Rectangle();
            switch (direction)
            {
                case Direction.Up:
                    playerAttackArea.Location = new Point(playerLocation.X, playerLocation.Y - distance);
                    playerAttackArea.Width = IMAGEWITDH;
                    playerAttackArea.Height = distance;
                    break;
                case Direction.Down:
                    playerAttackArea.Location = new Point(playerLocation.X, playerLocation.Y + IMAGEHEIGHT);
                    playerAttackArea.Width = IMAGEWITDH;
                    playerAttackArea.Height = distance;
                    break;
                case Direction.Left:
                    playerAttackArea.Location = new Point(playerLocation.X - distance, playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = IMAGEHEIGHT;
                    break;
                case Direction.Right:
                    playerAttackArea.Location = new Point(playerLocation.X + IMAGEWITDH, playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = IMAGEHEIGHT;
                    break;
            }
            if (playerAttackArea.IntersectsWith(enemyRect))
                return true;
            return false;
        }

        private Point Move(Direction direction, Point playerLocation, Rectangle boundaries)
        {
            playerLocation = Move(direction, boundaries);
            return playerLocation;
        }

        protected Direction ClockwiseDirection(Direction direction)
        {
            Direction clockWiseDirection = direction;

            switch (direction)
            {
                case Direction.Up:
                    clockWiseDirection = Direction.Right;
                    break;
                case Direction.Right:
                    clockWiseDirection = Direction.Down;
                    break;
                case Direction.Down:
                    clockWiseDirection = Direction.Left;
                    break;
                case Direction.Left:
                    clockWiseDirection = Direction.Up;
                    break;
            }

            return clockWiseDirection;
        }

        protected Direction CounterClockwiseDirection(Direction direction)
        {
            Direction counterClockWiseDirection = direction;

            switch (direction)
            {
                case Direction.Up:
                    counterClockWiseDirection = Direction.Left;
                    break;
                case Direction.Left:
                    counterClockWiseDirection = Direction.Down;
                    break;
                case Direction.Down:
                    counterClockWiseDirection = Direction.Right;
                    break;
                case Direction.Right:
                    counterClockWiseDirection = Direction.Up;
                    break;
            }

            return counterClockWiseDirection;
        }

    }
}
