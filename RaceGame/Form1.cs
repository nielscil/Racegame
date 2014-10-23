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
    //Met commentaar heb ik even een todo lijst toegevoegd bij de code die miss verrandert kan worden.(Eelke/Wolfgang) :D
    //Of dat er iets mee gedaan moet worden.
    public partial class Form1 : Form
    {
        Player player1 = new Player();
        Player player2 = new Player();
        Track track = new Track();
        Bitmap Backbuffer;
        Bitmap paused = new Bitmap(RaceGame.Properties.Resources.text_paused_resized);
        int i = 0;
        double countDownTimer = 3;
        System.Windows.Forms.Timer GameTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerFuel = new System.Windows.Forms.Timer();
        TimeSpan total = new TimeSpan();
        bool noFuel = false; //Moet nog per player worden gedaan.
        string bestLab = ""; //Moet dit per persoon, of is dit beste rondetijd die speelbeurt?

        public Form1()
        {
            InitializeComponent();
            player1.carPos= new PointF(545f, 515f);
            player2.carPos = new PointF(545f, 535f);
            track.track = new Bitmap(RaceGame.Properties.Resources.racetrack);            
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
            timerFuel.Interval = 100;
            timerFuel.Tick += new EventHandler(timerFuel_Tick_1);
            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Form1_keyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(myForm_MouseClick);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        void ESC()
        {
            if (i == 0)
            {
                GameTimer.Stop();
                timerFuel.Stop();
                timer1.Stop();               
                panel1.Visible = true;
                fuelBar.Visible = false;
                fuelLabel.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                i++;
            }
            else
            {
                panel1.Visible = false;
                GameTimer.Start();
                timerFuel.Start();
                timer1.Start();
                fuelBar.Visible = true;
                fuelLabel.Visible = true;
                label2.Visible = true;
                label1.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                i = 0;
            }
           
        }
        void Form1_keyUp(object sender, System.Windows.Forms.KeyEventArgs e)// wanneer toets losgelaten wordt, gebeurt dit
        {
            player1.Key_up(sender, e,0);
            player2.Key_up(sender, e,1);
        }
        void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)// wanneer toets ingedrukt wordt, gebeurt dit
        {
            player1.Key_down(sender,e,0);
            player2.Key_down(sender,e,1);
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

        
        void Draw()
        {
            using (var g = Graphics.FromImage(Backbuffer))
            {
                if (Backbuffer != null)
                {
                    System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Brushes.Black);
                    g.DrawImage(track.track, 0, 0, 1024, 768);
                    Invalidate();
                    g.DrawImage(player1.rotateCenter(), player1.carPos);
                    g.DrawImage(player2.rotateCenter(), player2.carPos);
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
                label3.Text = "00:00:00:00";
            }
            if (countDownTimer < -0.3) //Waarom -0.3, ==-1 werkt ook toch?
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
            total = total.Add(TimeSpan.FromMilliseconds(10));
            label3.Text = total.ToString(); //Betere naam voor label3, zoals labelTijdPlayer1 ofzo?
            label5.Text = player1.checkPointtime();//idem
            //label12.Text = player2.time.ToString(); //idem
            label1.Text = Convert.ToString(player1.fuel);
            label13.Text = Convert.ToString(player2.fuel);
            player1.Race();
            player2.Race();
            player1.Checkpoints();
            player2.Checkpoints();
            player1.Finish();
            player2.Finish();
            Draw();
        }

        void timerFuel_Tick_1(object sender, EventArgs e)         
        {
            player1.Fuel();
            player2.Fuel();
            fuelBar.Value = player1.fuel;
            progressBar1.Value = player2.fuel;
            fuelBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBar1.BackColor = Color.Silver;
            fuelBar.BackColor = Color.Silver;
            progressBar1.ForeColor = player2.GetFuelColor();
            fuelBar.ForeColor = player1.GetFuelColor();           
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void myForm_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e) //Waarvoor is dit?
        {
            int myX = e.X;
            int myY = e.Y;

            Console.WriteLine("X: " + myX + " Y: " + myY);
        }
    }
}
