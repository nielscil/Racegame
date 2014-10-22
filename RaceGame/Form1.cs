﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Data;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows;

namespace RaceGame
{
    public partial class Form1 : Form
    {
        Bitmap Backbuffer;
        Bitmap auto = new Bitmap(RaceGame.Properties.Resources.AutoVierkantBlauw,30,30);
        Bitmap racetrack = new Bitmap(RaceGame.Properties.Resources.racetrack);
        Bitmap paused = new Bitmap(RaceGame.Properties.Resources.text_paused_resized);
        float angle = 0;
        float speed = 0;
        bool r,l = false;
        int i = 0;
        PointF BallPos = new PointF(545f, 515f);        
        PointF BallSpeed = new PointF(0, 0);        
        int fuel = 100;
        double distance = 0;
        double countDownTimer = 5;
        System.Windows.Forms.Timer GameTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerFuel = new System.Windows.Forms.Timer();
        TimeSpan stopwatch = new TimeSpan();
        bool noFuel = false;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);            
            KeyPreview = true;
            timerFuel.Interval = 5;
            timerFuel.Tick += new EventHandler(timerFuel_Tick_1);
            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Form1_keyUp);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        void ESC()
        {
            if (i == 0)
            {
                GameTimer.Stop();
                timerFuel.Stop();
                panel1.Visible = true;
                fuelBar.Visible = false;
                fuelLabel.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
                i++;
            }
            else
            {
                panel1.Visible = false;
                GameTimer.Start();
                timerFuel.Start();
                fuelBar.Visible = true;
                fuelLabel.Visible = true;
                label2.Visible = true;
                label1.Visible = true;
                label4.Visible = true;
                i = 0;
            }
           
        }
        void Form1_keyUp(object sender, System.Windows.Forms.KeyEventArgs e)// wanneer toets losgelaten wordt, gebeurt dit
        {
            if (e.KeyCode == Keys.Left)
            {
                l = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                r = false;
            }
        }
        void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)// wanneer toets ingedrukt wordt, gebeurt dit
        {
            if(noFuel == false)
            {
                switch(e.KeyCode)
                {
                case Keys.Left:
                        if (speed != 0)
                         l = true;
                    break;
                case Keys.Right:
                    if (speed != 0)
                        r = true;
                    break;
                case Keys.Up:
                    if(speed > -2)
                        speed -= 0.5f;
                    break;
                case Keys.Down:
                    if(speed < 2)
                        speed += 0.5f;
                    break;
                }
            }
            if (e.KeyCode == Keys.Escape)
                ESC();                  
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

        Bitmap rotateCenter(Image b, float angle)
        {
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height + 1);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            g.RotateTransform(angle * (float)(57.1));
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            g.DrawImage(b, b.Width / 2 - b.Height / 2, b.Height / 2 - b.Width / 2, b.Height, b.Width);

            return returnBitmap;
        }
        void Draw()
        {
            using (var g = Graphics.FromImage(Backbuffer))
            {
                if (Backbuffer != null)
                {
                    System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Brushes.Black);
                    g.DrawImage(racetrack, 0, 0, 1024, 768);
                    Invalidate();
                    g.DrawImage(rotateCenter(auto, angle), BallPos);
                }
            }
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            if (countDownTimer != 0)
            {
                timer1.Interval = 1000;
                countDownTimer = countDownTimer - 0.5;
                label4.Text = Convert.ToString(countDownTimer);
                label3.Text = "00:00:00:0000000";
            }
            if (countDownTimer < -0.3)
            {
                timer1.Stop();
                label4.Text = "";
                
            }
            if (countDownTimer == 0)
            {
               
                label4.Text = "GO!";
                
                
                GameTimer.Start();
                timerFuel.Start();

                countDownTimer--;
                
            }
            
        }
        
        void GameTimer_Tick(object sender, EventArgs e)
        {
            if(l == true)
            {
                angle -= 0.015f;
            }
            else if( r== true)
            {
                angle += 0.015f;
            }
            BallSpeed.X = (float)(speed * Math.Cos(angle));
            BallSpeed.Y = (float)(speed * Math.Sin(angle));
            BallPos.X += BallSpeed.X;
            BallPos.Y += BallSpeed.Y;
            stopwatch = stopwatch.Add(TimeSpan.FromMilliseconds(10));
            label3.Text =stopwatch.ToString();
            label1.Text = Convert.ToString(fuel);
            distance += Math.Sqrt(Math.Pow(BallSpeed.X, 2) + Math.Pow(BallSpeed.Y, 2));
            Draw();

        }

        void timerFuel_Tick_1(object sender, EventArgs e)         
        {
            
            if (distance >= Math.Sqrt(Math.Pow(50, 2) + Math.Pow(70, 2)))
            {
                fuel--;
                distance = 0;
            }
            if (fuel == 0)
            {
                speed = 0;
                noFuel = true;              
            }
            if( (BallPos.X + 25) > 425f && (BallPos.X + 25) < 650f && (BallPos.Y + 25) > 680 && (BallPos.Y + 25) < 750 && BallSpeed.X == 0 && BallSpeed.Y == 0)//checkt of balletje stil is in het aangegeven vak.
            {
                
                if (fuel < 100)
                {
                    fuel += 1;
                }

                /*else if (fuel == 99)
                {
                    fuel++;
                }*/
            }
            fuelBar.Value = fuel;
            fuelBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            fuelBar.BackColor = Color.Silver;
            fuelBar.ForeColor = Color.Green;
            if (fuel < 50 && fuel > 30)
            {
                fuelBar.ForeColor = Color.Orange;
            }
            else if(fuel <= 30 && fuel > 10)
            {
                fuelBar.ForeColor = Color.OrangeRed;
            }
            else if(fuel <=10)
            {
                fuelBar.ForeColor = Color.Red;
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
