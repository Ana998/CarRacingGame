using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gameOverLbl.Visible = false;
            restartbtn.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gameSpeed);
            policeCar(gameSpeed);
            gameOver();
            coin(gameSpeed);
            collectingCoins();
        }

        Random r = new Random();
        int x, y;
        void policeCar(int speed)
        {
            if(police1.Top >= 400)
            {
                x = r.Next(0, 100);
                police1.Location = new Point(x, 0);
            }
            else
            {
                police1.Top += speed;
            }

            if (police2.Top >= 400)
            {
                x = r.Next(100, 200);
                police2.Location = new Point(x, 0);
            }
            else
            {
                police2.Top += speed;
            }

            if (police3.Top >= 400)
            {
                x = r.Next(200, 300);
                police3.Location = new Point(x, 0);
            }
            else
            {
                police3.Top += speed;
            }
        }

            void coin(int speed)
        {
            if (coin1.Top >= 400)
            {
                x = r.Next(0, 100);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 400)
            {
                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 400)
            {
                x = r.Next(50, 200);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 400)
            {
                x = r.Next(100, 250);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }

        void gameOver()
        {
            if (car.Bounds.IntersectsWith(police1.Bounds))
            {
                timer1.Enabled = false;
                gameOverLbl.Visible = true;
                restartbtn.Visible = true;
            }
            if (car.Bounds.IntersectsWith(police2.Bounds))
            {
                timer1.Enabled = false;
                gameOverLbl.Visible = true;
                restartbtn.Visible = true;
            }
            if (car.Bounds.IntersectsWith(police3.Bounds))
            {
                timer1.Enabled = false;
                gameOverLbl.Visible = true;
                restartbtn.Visible = true;
            }
        }

        void moveLine(int speed)
        {
            if(line1.Top >= 400)
            {
                line1.Top = 0;
            }
            else
            {
                line1.Top += speed;
            }

            if (line2.Top >= 400)
            {
                line2.Top = 0;
            }
            else
            {
                line2.Top += speed;
            }

            if (line3.Top >= 400)
            {
                line3.Top = 0;
            }
            else
            {
                line3.Top += speed;
            }

            if (line4.Top >= 400)
            {
                line4.Top = 0;
            }
            else
            {
                line4.Top += speed;
            }

            if (line5.Top >= 400)
            {
                line5.Top = 0;
            }
            else
            {
                line5.Top += speed;
            }
        }

        int collectedCoins = 0;
        void collectingCoins()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoins++;
                coinsLbl.Text = "Coins=" + collectedCoins.ToString();

                x = r.Next(59, 300);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoins++;
                coinsLbl.Text = "Coins=" + collectedCoins.ToString();

                x = r.Next(59, 300);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoins++;
                coinsLbl.Text = "Coins=" + collectedCoins.ToString();

                x = r.Next(59, 300);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedCoins++;
                coinsLbl.Text = "Coins=" + collectedCoins.ToString();

                x = r.Next(59, 300);
                coin4.Location = new Point(x, 0);
            }
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int gameSpeed = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void gameOverLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(car.Left > 0)
                car.Left += -8;
            }
            if(e.KeyCode == Keys.Right)
            {
                if(car.Right < 290)
                car.Left += 8;
            }
            if(e.KeyCode == Keys.Up)
            {
                if(gameSpeed < 14)
                    gameSpeed++;
            }
            if(e.KeyCode == Keys.Down)
            {
                if(gameSpeed > 0)
                    gameSpeed--;
            }
        }
    }
}
