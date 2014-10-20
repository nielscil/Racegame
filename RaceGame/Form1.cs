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
using System.Windows.Media;
using System.Windows;

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
        const int BallSize = 20;

        RectangleF r = new RectangleF();
        RotateTransform rt1 = new RotateTransform();
 
        int fuel = 100;
        double distance = 0;
        Timer GameTimer = new Timer();
  //      ProgressBar progressBar1 = new  ProgressBar();
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Form1_keyUp);
            r.Height = 10;
            r.Width = 5;        
        }
        int Fuel()
        {
            
            return fuel;

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

        void Form1_keyUp(object sender, System.Windows.Forms.KeyEventArgs e)// wanneer toets losgelaten wordt, gebeurt dit
        {
            if (e.KeyCode == Keys.Up)
            {

            }
            else if (e.KeyCode == Keys.Down)
            {

            }
        } 

        void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)// wanneer toets ingedrukt wordt, gebeurt dit
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
                e.Graphics.DrawImageUnscaled(Backbuffer, System.Drawing.Point.Empty);
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
                    System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Brushes.Black);
                    g.DrawImage(racetrack,0,0,1024,768);
                    g.DrawRectangle(pen, 436.80f, 256.09f, 104f,33f);
                    //g.FillEllipse(Brushes.Red, BallPos.X - BallSize / 2, BallPos.Y - BallSize / 2, BallSize, BallSize);
                    g.FillRectangle(System.Drawing.Brushes.Red, r);
                    r.X = BallPos.X;
                    r.Y = BallPos.Y;
                    rt1.Angle = angle;
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

            distance += Math.Sqrt(Math.Pow(BallSpeed.X, 2) + Math.Pow(BallSpeed.Y, 2));
            if (distance >= Math.Sqrt(Math.Pow(54.654968, 2) + Math.Pow(134.750443, 2)))
            {
                fuel--;
                distance = 0;
            }

            
            if( BallPos.X > 436.80f && BallPos.X < 540f && BallPos.Y > 256.09 && BallPos.Y < 289 && BallSpeed.X == 0 && BallSpeed.Y == 0)//checkt of balletje stil is in het aangegeven vak.
            {
                
                if (fuel < 99)
                {
                    fuel += 2;
                }

                if (fuel == 99)
                {
                    fuel++;
                }
                
                //tankt code toevoegen
            }
            progressBar1.Value = fuel;
            progressBar1.CreateGraphics().DrawString(fuel.ToString(), new Font("Sitka Text", (float)24, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(progressBar1.Width / 2 - 30 , progressBar1.Height / 2 - 16 ));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();            
        }
        
    }
}
