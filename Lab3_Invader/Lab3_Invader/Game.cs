using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Lab3_Invader
{
    class Game
    {
        private int score = 0;
        private int livesLeft = 3;
        private int currentInvaderWave = 0;
        private int framesSkipped = 0;
        private int framesToSkip = 7;
        private int maxNumberOfWaves = 3;

        private Rectangle boundaries;
        private Random random;

        private Point playerShipStartingLocation;
        private Direction invaderDirection;
        private List<Invader> invaders;

        private PlayerShip playerShip;
        private List<Shot> playerShots;
        private List<Shot> invaderShots;

        private List<Bitmap> livesLeftDisplay;

        private Stars stars;

        public event EventHandler GameOver;

        public Game(Rectangle boundaries, Random random)
        {
            this.boundaries = boundaries;
            this.random = random;
            this.playerShipStartingLocation = new Point(boundaries.Right - 100, boundaries.Bottom - 50);
            this.playerShip = new PlayerShip(playerShipStartingLocation);
            this.playerShots = new List<Shot>();
            this.invaderShots = new List<Shot>();
            this.invaders = new List<Invader>();
            this.livesLeftDisplay = new List<Bitmap>();
            this.stars = new Stars(boundaries, random);
            for (int i = 0; i < livesLeft; i++)
                livesLeftDisplay.Add(playerShip.GetLivesLeftImage());
            NextWave();
        } 

        public void OnGameOver(EventArgs e)
        {
            EventHandler gameOver = GameOver;
            if (gameOver != null)
                gameOver(this, e);
        } 

        public void FirePlayerShot()
        {

            if (playerShots.Count < 2)
            {
                Shot newPlayerShot = new Shot(playerShip.TopMiddle, Direction.Up, boundaries);
                playerShots.Add(newPlayerShot);
            }
        } 

        public void Twinkle()
        {
            stars.Twinkle();
        } 

        public void Go()
        {
            if (!playerShip.Alive) return;

            MovePlayerShots();
            MoveInvaderShots();

            MoveInvaders();
            ReturnFire();

            CheckForInvaderCollisions();
            CheckForPlayerCollisions();
            CheckForInvadersAtBottomOfScreen();

            if (invaders.Count == 0) NextWave();
        }

        private void MoveInvaderShots()
        {
            for (int i = invaderShots.Count - 1; i >= 0; i--)
                if (!invaderShots[i].Move(Direction.Down))
                    invaderShots.Remove(invaderShots[i]);
        }

        private void MovePlayerShots()
        {
            for (int i = playerShots.Count - 1; i >= 0; i--)
                if (!playerShots[i].Move(Direction.Up))
                    playerShots.Remove(playerShots[i]);
        }

        public void MovePlayer(Direction directionToMove)
        {
            if (playerShip.Alive)
            {
                if (!WillTouchBorder(playerShip.Area, directionToMove, 10))
                    playerShip.Move(directionToMove);
            }
        }

        public void Draw(Graphics g, int animationCell)
        {
            g.FillRectangle(Brushes.Black, 0, 0, boundaries.Width, boundaries.Height);
            stars.Draw(g);

            foreach (Invader invader in invaders)
                invader.Draw(g, animationCell);

            playerShip.Draw(g);

            foreach (Shot shot in playerShots)
                shot.Draw(g);

            foreach (Shot shot in invaderShots)
                shot.Draw(g);

            DrawScoreAndWaveProgress(g);
            DrawLivesLeft(g);
        } 

        private void DrawScoreAndWaveProgress(Graphics g)
        {
            string scoreString = "WAVE " +
                (currentInvaderWave > maxNumberOfWaves ?
                maxNumberOfWaves.ToString() : currentInvaderWave.ToString()) +
                "/" + maxNumberOfWaves.ToString() + Environment.NewLine
            + "SCORE:" + Environment.NewLine + score.ToString();
            Font scoreFont = new Font("Arial", 12, FontStyle.Bold);
            Point scorePoint = new Point(25, 25);
            g.DrawString(scoreString, scoreFont, Brushes.Red, scorePoint);
        }

        private void DrawLivesLeft(Graphics g)
        {
            Point drawPoint = new Point(boundaries.Right - (livesLeft * playerShip.Area.Width), boundaries.Top + 10);
            int xSkip = playerShip.Area.Width;
            foreach (Bitmap shipToDraw in livesLeftDisplay)
            {
                g.DrawImage(shipToDraw, drawPoint);
                Point newLifePoint = new Point(drawPoint.X + xSkip, drawPoint.Y);
                drawPoint = newLifePoint;
            }
        }

        private void NextWave()
        {
            if (++currentInvaderWave > maxNumberOfWaves)
            {
                OnGameOver(new EventArgs());
                return;
            }
            framesToSkip--;
            invaders = new List<Invader>();
            invaderDirection = Direction.Right;
            invaderShots = new List<Shot>();
            playerShots = new List<Shot>();
            int xMove = 85;
            int yMove = 50;
            int yPosition = 50;
            int xPosition = 50;
            yPosition = AddInvaderRow(ShipType.Satellite, 50, xMove, yMove, xPosition, yPosition);
            yPosition = AddInvaderRow(ShipType.Bug, 40, xMove, yMove, xPosition, yPosition);
            yPosition = AddInvaderRow(ShipType.Saucer, 30, xMove, yMove, xPosition, yPosition);
            yPosition = AddInvaderRow(ShipType.Spaceship, 20, xMove, yMove, xPosition, yPosition);
            yPosition = AddInvaderRow(ShipType.Star, 10, xMove, yMove, xPosition, yPosition);
        }

        private int AddInvaderRow(ShipType invaderType, int score, int xMove, int yMove, int xPosition, int yPosition)
        {
            for (int j = 1; j <= 6; j++)
            {
                Invader newInvader = new Invader(invaderType, new Point(xPosition, yPosition), score);
                invaders.Add(newInvader);
                xPosition += xMove;
            }
            yPosition += yMove;
            return yPosition;
        } 

        private void MoveInvaders()
        {
            if (++framesSkipped < framesToSkip)
                return;
            else
            {
                var invadersOnBorder =
                      from invader in invaders
                      where WillTouchBorder(invader.Area, invaderDirection, 100)
                      select invader;
                if (invadersOnBorder.Count() > 0)
                {
                    foreach (Invader invader in invaders)
                        invader.Move(Direction.Down);
                    invaderDirection = (invaderDirection == Direction.Left ? Direction.Right : Direction.Left);
                }
                else
                    foreach (Invader invader in invaders)
                        invader.Move(invaderDirection);
                framesSkipped = 0;
            }

        }

       private bool WillTouchBorder(Rectangle area, Direction direction, int pixelBoundary)
        {
            if (((direction == Direction.Right) &&
                (area.Right + pixelBoundary > boundaries.Right)) ||
                ((direction == Direction.Left) &&
                (area.Left - pixelBoundary < boundaries.Left))) return true;
            else return false;
        }

        private void ReturnFire()
        {
            if (invaderShots.Count >= currentInvaderWave + 1) return;
            else if (random.Next(10) < (10 - currentInvaderWave)) return;
            else
            {
                var invaderLocationGroups =
                    from bottomInvader in invaders
                    orderby bottomInvader.Location.Y descending
                    group bottomInvader by bottomInvader.Location.X
                    into invaderLocationGroup
                    select invaderLocationGroup;
                int randomInvaderNumber = random.Next(invaderLocationGroups.Count());
                Invader shooter = invaderLocationGroups.ElementAt(randomInvaderNumber).First();
                Shot newShot = new Shot(shooter.BottomMiddle, Direction.Up, boundaries);
                invaderShots.Add(newShot);
            }
        }

        private void CheckForPlayerCollisions()
        {
            for (int i = invaderShots.Count - 1; i >= 0; i--)
            {
                if (playerShip.Area.Contains(invaderShots[i].Location))
                {
                    playerShip.Alive = false;
                    invaderShots.Remove(invaderShots[i]);
                    if (--livesLeft < 0)
                        OnGameOver(new EventArgs());
                    else
                    {
                        int shipPictureToRemove = livesLeftDisplay.Count - 1;
                        livesLeftDisplay.Remove(livesLeftDisplay[shipPictureToRemove]);
                    }
                }
            }
        }

        private void CheckForInvaderCollisions()
        {
            for (int i = playerShots.Count - 1; i >= 0; i--)
            {
                Point shotLocation = playerShots[i].Location;
                var invaderCollisions =
                    from hitInvader in invaders
                    where hitInvader.Area.Contains(shotLocation)
                    select hitInvader;

                if (invaderCollisions.Count() > 0)
                {
                    playerShots.Remove(playerShots[i]);
                    List<Invader> deadInvaders = new List<Invader>();
                    foreach (var deadInvader in invaderCollisions)
                        deadInvaders.Add(deadInvader);
                    foreach (Invader deadInvader in deadInvaders)
                    {
                        score += deadInvader.Score;
                        invaders.Remove(deadInvader);
                    }
                }
            }
        }

        private void CheckForInvadersAtBottomOfScreen()
        {
            var invadersAtBottom =
                    from bottomInvader in invaders
                    where bottomInvader.Area.Bottom >= playerShip.Area.Bottom
                    select bottomInvader;

            if (invadersAtBottom.Count() > 0) { OnGameOver(new EventArgs()); }
        }

        private void CheckCollisions()
        {
            CheckForInvaderCollisions();
            CheckForPlayerCollisions();
            CheckForInvadersAtBottomOfScreen();
        }
    }
}
