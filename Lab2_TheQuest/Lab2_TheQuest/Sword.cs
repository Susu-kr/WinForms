using System;
using System.Drawing;

namespace Lab2_TheQuest
{
    class Sword : Weapon
    {
        private const int ATTACK_RADIUS = 20;
        private const int DAMAGE = 3;

        public Sword(Game game, Point location) : base(game, location) { }

        public override string Name{ get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, ATTACK_RADIUS, DAMAGE, random))
                if (!DamageEnemy(ClockwiseDirection(direction), ATTACK_RADIUS, DAMAGE, random))
                    DamageEnemy(CounterClockwiseDirection(direction), ATTACK_RADIUS, DAMAGE, random);
        }
    }
}
