using System;
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
        byte i = 0;
        double countDownTimer = 3;
        System.Windows.Forms.Timer GameTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerFuel = new System.Windows.Forms.Timer();
        TimeSpan total = new TimeSpan();
        TimeSpan Player1 = new TimeSpan(); //Player1 is een TimeSpan en player1 is een Player, is dit niet ingewikkeld?
        TimeSpan Player2 = new TimeSpan(); // Same as above, maar Player player2 word nooit aangemaakt?
        bool noFuel = false; //Moet nog per player worden gedaan.
        byte checkpointcounter = 0;
        string bestLab = ""; //Moet dit per persoon, of is dit beste rondetijd die speelbeurt?
        public Form1()
        {
            InitializeComponent();
            player1.carPos= new PointF(545f, 515f);
            player1.carSpeed = new PointF(0, 0);

            player2.carPos = new PointF(545f, 535f);
            player2.carSpeed = new PointF(0, 0);

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

            //Maakt het fullscreen (Y)
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
                progressBarPlayer1Fuel.Visible = false;
                labelPlayer1Fuel.Visible = false;
                label2.Visible = false;
                labelPlayer1FuelHoeveel.Visible = false;
                labelCountdown.Visible = false;
                labelTimer.Visible = false;
                i++;
            }
            else
            {
                panel1.Visible = false;
                GameTimer.Start();
                timerFuel.Start();
                timer1.Start();
                progressBarPlayer1Fuel.Visible = true;
                labelPlayer1Fuel.Visible = true;
                label2.Visible = true;
                labelPlayer1FuelHoeveel.Visible = true;
                labelCountdown.Visible = true;
                labelTimer.Visible = true;
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
        #region timers
        void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            if (countDownTimer != 0)
            {
                timer1.Interval = 1000;
                countDownTimer = countDownTimer - 0.5;
                labelCountdown.Text = Convert.ToString(countDownTimer);
                labelTimer.Text = "00:00:00:00";
            }
            if (countDownTimer < -0.3) //Waarom -0.3, ==-1 werkt ook toch?
            {
                timer1.Stop();
                labelCountdown.Text = "";
               
            }
            if (countDownTimer == 0)
            {               
                labelCountdown.Text = "GO!";                               
                GameTimer.Start();
                timerFuel.Start();
                countDownTimer--;                
            }
            
        }
        
        void GameTimer_Tick(object sender, EventArgs e)
        {
            total = total.Add(TimeSpan.FromMilliseconds(10));
            labelTimer.Text = total.ToString(); //Betere naam voor label3, zoals labelTijdPlayer1 ofzo?
            labelPlayer1RondeTijd.Text = player1.time.ToString();
            labelPlayer2RondeTijd.Text = player2.time.ToString();
            labelPlayer1FuelHoeveel.Text = Convert.ToString(player1.fuel);
            player1.Race();
            player2.Race();
            player1.Finish();
            player2.Finish();
            Draw();
            player1.Checkpoints();
            player2.Checkpoints();
        }

        void timerFuel_Tick_1(object sender, EventArgs e)         
        {
            player1.Fuel();
            progressBarPlayer1Fuel.Value = player1.fuel;
            progressBarPlayer1Fuel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBarPlayer1Fuel.BackColor = Color.Silver;
            progressBarPlayer1Fuel.ForeColor = player1.GetFuelColor();
            
         }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void myForm_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int myX = e.X;
            int myY = e.Y;

            Console.WriteLine("X: " + myX + " Y: " + myY);
        }

        private void checkPointtimeplayer1()
        {
            for (int i = 0; i < checkpointcounter; )
            {
                labelPlayer1RondeTijd.Text = Player1.ToString();
                i++;
            }

        }
        private void checkPoint()
        {
            //checkpoint 1. op track 1, deze punten moeten dus in class voor track1 komen te staan ofzo.
            if ((player1.carPos.X + 25 >= 275 & player1.carPos.X + 25 <= 280) & (player1.carPos.Y >= 588 & player1.carPos.Y <= 668))
            {
                player1.SetCheckpoint(1);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 2???
            if ((player1.carPos.X + 25 >= 165 & player1.carPos.X <= 170) & (player1.carPos.Y >= 74 & player1.carPos.Y <= 148) & player1.CheckCheckpoint(1) == true)
            {
                player1.SetCheckpoint(2);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 3???
            if ((player1.carPos.X >= 434 & player1.carPos.X <= 499) & (player1.carPos.Y >= 192 & player1.carPos.Y <= 197) & player1.CheckCheckpoint(2) == true)
            {
                player1.SetCheckpoint(3);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 4???
            if ((player1.carPos.X >= 578 & player1.carPos.X <= 583) & (player1.carPos.Y >= 414 & player1.carPos.Y <= 488) & player1.CheckCheckpoint(3) == true)
            {
                player1.SetCheckpoint(4);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 5???
            if ((player1.carPos.X >= 852 & player1.carPos.X <= 857) & (player1.carPos.Y >= 0 & player1.carPos.Y <= 69) & player1.CheckCheckpoint(4) == true)
            {
                player1.SetCheckpoint(5);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 6???
            if ((player1.carPos.X >= 793 & player1.carPos.X <= 798) & (player1.carPos.Y >= 589 & player1.carPos.Y <= 672) & player1.CheckCheckpoint(5) == true)
            {
                player1.SetCheckpoint(6);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
        }
    }
}
