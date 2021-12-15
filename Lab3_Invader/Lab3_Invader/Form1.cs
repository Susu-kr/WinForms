using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3_Invader
{
    public partial class Form1 : Form
    {
        int animationCounter;
        bool reverseInvaderAnimation;
        bool gameOver;
        Game game;
        Random random = new Random();
        List<Keys> keysPressed = new List<Keys>();

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }
        void StartNewGame()
        {
            game = new Game(this.ClientRectangle, random);
            game.GameOver += new EventHandler(game_GameOver);
            gameOver = false;
            reverseInvaderAnimation = false;
            animationCounter = 0;
            animationTimer.Enabled = true;
            gameTimer.Enabled = true;
        }

        void game_GameOver(object sender, EventArgs e)
        {
            gameTimer.Stop();
            gameOver = true;
            Invalidate();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (animationCounter == 3) reverseInvaderAnimation = true;
            else if (animationCounter == 0) reverseInvaderAnimation = false;

            if (reverseInvaderAnimation) animationCounter--;
            else animationCounter++;
            game.Twinkle();
            Refresh();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.Go();

            foreach (Keys key in keysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    return;
                }

                else if (key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                    return;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Draw(g, animationCounter);

            if (gameOver)
            {
                string playAgain = "Press S to start a new game or Q to quit";
                Font playAgainFont = new Font("Arial", 12);
                Font gameOverTopFont = new Font("Arial", 30, FontStyle.Bold);
                Point gameOverPoint = new Point((ClientRectangle.Width / 3), (ClientRectangle.Height / 2));
                Point playAgainPoint = new Point(ClientRectangle.Width / 2, (int)((double)(ClientRectangle.Height * .9)));
                g.DrawString("GAME OVER!", gameOverTopFont, Brushes.Yellow, gameOverPoint);
                g.DrawString(playAgain, playAgainFont, Brushes.Yellow, playAgainPoint);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();

            if (gameOver)
            {
                if (e.KeyCode == Keys.S)
                {
                    StartNewGame();
                    return;
                }
            }

            if (e.KeyCode == Keys.Space)
                game.FirePlayerShot();

            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);

            keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
