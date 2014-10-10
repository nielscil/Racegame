using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame
{
    public partial class Form1 : Form
    {
        Bitmap Backbuffer;
        Bitmap racetrack = new Bitmap(RaceGame.Properties.Resources.racetrack);
        float angle = 76.54f;
        float speed = 0;
        int i = 0;
        PointF BallPos = new PointF(287f, 383f);
        PointF BallSpeed = new PointF(0, 0);
        const int BallSize = 10;
        Timer GameTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);            
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);
            GameTimer.Start();
            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_keyUp);
        }

        void ESC()
        {
            if (i == 0)
            {
                GameTimer.Stop();
                panel1.Visible = true;
                i++;
            }
            else
            {
                panel1.Visible = false;
                GameTimer.Start();
                i = 0;
            }
           
        }

        void Form1_keyUp(object sender, KeyEventArgs e)// wanneer toets losgelaten wordt, gebeurt dit
        {
            if (e.KeyCode == Keys.Up)
            {

            }
            else if (e.KeyCode == Keys.Down)
            {

            }
        } 

        void Form1_KeyDown(object sender, KeyEventArgs e)// wanneer toets ingedrukt wordt, gebeurt dit
        {
            if (e.KeyCode == Keys.Left)
            {
                angle -= 0.5f;
            }
            else if (e.KeyCode == Keys.Right)
            {
                angle += 0.5f;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if(speed > -3)
                speed -= 0.5f;

            }
            else if (e.KeyCode == Keys.Down)
            {
                if(speed < 3)
                speed += 0.5f;
            }
            
            else if (e.KeyCode == Keys.Space)
            {
                angle = 0;
                speed = 0;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                    ESC();
            }
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Backbuffer != null)
            {
                e.Graphics.DrawImageUnscaled(Backbuffer, Point.Empty);
            }
        }

        void Form1_CreateBackBuffer(object sender, EventArgs e)
        {
            if (Backbuffer != null)
                Backbuffer.Dispose();

            Backbuffer = new Bitmap(1024, 768);
        }

        void Draw()
        {
            if (Backbuffer != null)
            {
                using (var g = Graphics.FromImage(Backbuffer))
                {
                    g.DrawImage(racetrack,0,0,1024,768);
                    g.FillEllipse(Brushes.Red, BallPos.X - BallSize / 2, BallPos.Y - BallSize / 2, BallSize, BallSize);
                }

                Invalidate();
            }
        }

        void GameTimer_Tick(object sender, EventArgs e)
        {
            BallSpeed.X = (float)(speed * Math.Cos(angle));
            BallSpeed.Y = (float)(speed * Math.Sin(angle));
            BallPos.X += BallSpeed.X;
            BallPos.Y += BallSpeed.Y;
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();            
        }
    }
}