using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2_TheQuest
{
    class Game
    {
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;

        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;
        public int Level { get { return level; } }

        // Map(Left,Top,Right,Bottom) = 80, 60, 480, 200
        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        public void Move(Direction directon, Random random)
        {
            player.Move(directon);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }
        
        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public bool IsWeaponEquipped(string weaponName)
        {
            return player.IsWeaponEquipped(weaponName);
        }

        public bool CheckPotionUsed(string potionName)
        {
            return player.CheckPotionUsed(potionName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(
                boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10
                );
        }

        public void NewLevel(Random random)
        {
            level++;
            if(level > 1)
                Enemies.Clear();

            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>() { new Bat(this, GetRandomLocation(random)) };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies = new List<Enemy>() { new Ghost(this, GetRandomLocation(random)) };
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>() { new Ghoul(this, GetRandomLocation(random)) };
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemy>() { new Bat(this, GetRandomLocation(random)), new Ghost(this, GetRandomLocation(random)) };
                    if (CheckPlayerInventory("Bow"))
                    {
                        if (!CheckPlayerInventory("Blue Potion") || (CheckPlayerInventory("Blue Potion") && player.CheckPotionUsed("Blue Potion")))
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    else
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 5:
                    Enemies = new List<Enemy>() { new Bat(this, GetRandomLocation(random)), new Ghoul(this, GetRandomLocation(random)) };
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies = new List<Enemy>() { new Ghost(this, GetRandomLocation(random)), new Ghoul(this, GetRandomLocation(random)) };
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies = new List<Enemy>() { new Bat(this, GetRandomLocation(random)), new Ghost(this, GetRandomLocation(random)), new Ghoul(this, GetRandomLocation(random)) };
                    WeaponInRoom = null;
                    if (CheckPlayerInventory("Mace"))
                    {
                        if (!CheckPlayerInventory("Red Potion") || (CheckPlayerInventory("Red Potion") && player.CheckPotionUsed("Red Potion")))
                            WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    }
                    else
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 8:
                    Application.Exit();
                    break;
            }
        }
    }
}
